﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PricingReferenceType
    {

        private ItemLocationQuantityType _originalItemLocationQuantityField;

        private PriceType[] _alternativeConditionPriceField;

        /// <remarks/>
        public ItemLocationQuantityType OriginalItemLocationQuantity
        {
            get
            {
                return _originalItemLocationQuantityField;
            }
            set
            {
                _originalItemLocationQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice")]
        public PriceType[] AlternativeConditionPrice
        {
            get
            {
                return _alternativeConditionPriceField;
            }
            set
            {
                _alternativeConditionPriceField = value;
            }
        }
    }
}