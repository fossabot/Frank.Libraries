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
    [XmlRoot("CorporateRegistrationScheme", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class CorporateRegistrationSchemeType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode;
    
        /// <remarks/>
        [XmlElement("JurisdictionRegionAddress")]
        public AddressType[] JurisdictionRegionAddress;
    }
}