﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UnstructuredPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class UnstructuredPriceType
    {

        private PriceAmountType _priceAmountField;

        private TimeAmountType _timeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType PriceAmount
        {
            get
            {
                return _priceAmountField;
            }
            set
            {
                _priceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeAmountType TimeAmount
        {
            get
            {
                return _timeAmountField;
            }
            set
            {
                _timeAmountField = value;
            }
        }
    }
}