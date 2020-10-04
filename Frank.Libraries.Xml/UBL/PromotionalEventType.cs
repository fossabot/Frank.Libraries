﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("PromotionalEvent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class PromotionalEventType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PromotionalEventTypeCodeType PromotionalEventTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubmissionDateType SubmissionDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestProposalAcceptanceDateType LatestProposalAcceptanceDate;
    
        /// <remarks/>
        [XmlElement("PromotionalSpecification")]
        public PromotionalSpecificationType[] PromotionalSpecification;
    }
}