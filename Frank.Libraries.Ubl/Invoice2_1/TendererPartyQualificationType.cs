﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TendererPartyQualificationType
    {

        private ProcurementProjectLotType[] interestedProcurementProjectLotField;

        private QualifyingPartyType mainQualifyingPartyField;

        private QualifyingPartyType[] additionalQualifyingPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot")]
        public ProcurementProjectLotType[] InterestedProcurementProjectLot
        {
            get
            {
                return interestedProcurementProjectLotField;
            }
            set
            {
                interestedProcurementProjectLotField = value;
            }
        }

        /// <remarks/>
        public QualifyingPartyType MainQualifyingParty
        {
            get
            {
                return mainQualifyingPartyField;
            }
            set
            {
                mainQualifyingPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty")]
        public QualifyingPartyType[] AdditionalQualifyingParty
        {
            get
            {
                return additionalQualifyingPartyField;
            }
            set
            {
                additionalQualifyingPartyField = value;
            }
        }
    }
}