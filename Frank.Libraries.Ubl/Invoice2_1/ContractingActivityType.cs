﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContractingActivity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ContractingActivityType
    {

        private ActivityTypeCodeType activityTypeCodeField;

        private ActivityTypeType activityTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActivityTypeCodeType ActivityTypeCode
        {
            get
            {
                return activityTypeCodeField;
            }
            set
            {
                activityTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActivityTypeType ActivityType
        {
            get
            {
                return activityTypeField;
            }
            set
            {
                activityTypeField = value;
            }
        }
    }
}