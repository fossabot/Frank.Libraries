﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UblExtensionsType
    {

        private UblExtensionType[] _uBlExtensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UBLExtension")]
        public UblExtensionType[] UblExtension
        {
            get
            {
                return _uBlExtensionField;
            }
            set
            {
                _uBlExtensionField = value;
            }
        }
    }
}