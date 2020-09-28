﻿using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frank.Libraries.Xml
{
    public class XmlContext<T> where T : class, new()
    {
        private List<T> _collection;
        private List<T> _tempCollection;
        private readonly XmlConfiguration _options;
        private readonly string _filePath;
        private bool _unsavedChanges;

        public XmlContext(IOptions<XmlConfiguration>? options = default)
        {
            _options = options.Value;
            if (string.IsNullOrWhiteSpace(_options.DataFolderName))
            {
                _options.DataFolderName = "Data";
            }
            _filePath = Path.Combine(_options.DataFolderName, typeof(T).Name + ".xml");
            Setup();
        }

        private void Setup()
        {
            if (!Directory.Exists(_options.DataFolderName))
            {
                Directory.CreateDirectory(_options.DataFolderName);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, new List<T>().SerializeObjectToXml());
            }

            _collection = new List<T>();
            _tempCollection = new List<T>();

            _collection = File.ReadAllText(_filePath).DeserializeObjectFromXml<List<T>>();
        }

        public IEnumerable<T> GetCollection()
        {
            if (!_collection.Any())
                _collection = File.ReadAllText(_filePath).DeserializeObjectFromXml<List<T>>();

            return _collection;
        }

        public void Add(T item)
        {
            _tempCollection.Add(item);
            _unsavedChanges = true;
        }

        public void Add(List<T> items)
        {
            _tempCollection.AddRange(items);
            _unsavedChanges = true;
        }

        public bool SaveChanges()
        {
            if (!_unsavedChanges) return true;

            GetCollection();
            _collection.AddRange(_tempCollection);
            File.WriteAllText(_filePath, _collection.SerializeObjectToXml());
            _tempCollection.Clear();

            GetCollection();

            _unsavedChanges = false;
            return true;
        }

        public void DiscardChanges()
        {
            _tempCollection.Clear();
            _unsavedChanges = false;
        }
    }
}
