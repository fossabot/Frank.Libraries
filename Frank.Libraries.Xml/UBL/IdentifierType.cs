﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [XmlInclude(typeof(IdentifierType1))]
    [XmlInclude(typeof(WebsiteURIType))]
    [XmlInclude(typeof(VesselIDType))]
    [XmlInclude(typeof(VersionIDType))]
    [XmlInclude(typeof(VariantIDType))]
    [XmlInclude(typeof(ValidatorIDType))]
    [XmlInclude(typeof(UpperOrangeHazardPlacardIDType))]
    [XmlInclude(typeof(UUIDType))]
    [XmlInclude(typeof(URIType))]
    [XmlInclude(typeof(UBLVersionIDType))]
    [XmlInclude(typeof(TransportationServiceDetailsURIType))]
    [XmlInclude(typeof(TransportExecutionPlanReferenceIDType))]
    [XmlInclude(typeof(TrainIDType))]
    [XmlInclude(typeof(TrackingIDType))]
    [XmlInclude(typeof(TraceIDType))]
    [XmlInclude(typeof(TenderEnvelopeIDType))]
    [XmlInclude(typeof(SupplierAssignedAccountIDType))]
    [XmlInclude(typeof(SuccessiveSequenceIDType))]
    [XmlInclude(typeof(SubscriberIDType))]
    [XmlInclude(typeof(SpecificationIDType))]
    [XmlInclude(typeof(SignatureIDType))]
    [XmlInclude(typeof(ShippingOrderIDType))]
    [XmlInclude(typeof(SerialIDType))]
    [XmlInclude(typeof(SequenceNumberIDType))]
    [XmlInclude(typeof(SequenceIDType))]
    [XmlInclude(typeof(SellerEventIDType))]
    [XmlInclude(typeof(SecurityIDType))]
    [XmlInclude(typeof(SchemeURIType))]
    [XmlInclude(typeof(SalesOrderLineIDType))]
    [XmlInclude(typeof(SalesOrderIDType))]
    [XmlInclude(typeof(RevisedForecastLineIDType))]
    [XmlInclude(typeof(RequiredCustomsIDType))]
    [XmlInclude(typeof(RequestForQuotationLineIDType))]
    [XmlInclude(typeof(ReleaseIDType))]
    [XmlInclude(typeof(RegistrationNationalityIDType))]
    [XmlInclude(typeof(RegistrationIDType))]
    [XmlInclude(typeof(ReferencedConsignmentIDType))]
    [XmlInclude(typeof(ReferenceIDType))]
    [XmlInclude(typeof(RailCarIDType))]
    [XmlInclude(typeof(RadioCallSignIDType))]
    [XmlInclude(typeof(ProfileIDType))]
    [XmlInclude(typeof(ProfileExecutionIDType))]
    [XmlInclude(typeof(ProductTraceIDType))]
    [XmlInclude(typeof(PrimaryAccountNumberIDType))]
    [XmlInclude(typeof(PreviousVersionIDType))]
    [XmlInclude(typeof(PreviousJobIDType))]
    [XmlInclude(typeof(PrepaidPaymentReferenceIDType))]
    [XmlInclude(typeof(PerformingCarrierAssignedIDType))]
    [XmlInclude(typeof(PaymentTermsDetailsURIType))]
    [XmlInclude(typeof(PaymentMeansIDType))]
    [XmlInclude(typeof(PaymentIDType))]
    [XmlInclude(typeof(ParentDocumentVersionIDType))]
    [XmlInclude(typeof(ParentDocumentLineReferenceIDType))]
    [XmlInclude(typeof(ParentDocumentIDType))]
    [XmlInclude(typeof(OriginalJobIDType))]
    [XmlInclude(typeof(OriginalContractingSystemIDType))]
    [XmlInclude(typeof(OpenTenderIDType))]
    [XmlInclude(typeof(OntologyURIType))]
    [XmlInclude(typeof(NetworkIDType))]
    [XmlInclude(typeof(NationalityIDType))]
    [XmlInclude(typeof(MarkingIDType))]
    [XmlInclude(typeof(LowerOrangeHazardPlacardIDType))]
    [XmlInclude(typeof(LotNumberIDType))]
    [XmlInclude(typeof(LogoReferenceIDType))]
    [XmlInclude(typeof(LocationIDType))]
    [XmlInclude(typeof(LoadingSequenceIDType))]
    [XmlInclude(typeof(LineIDType))]
    [XmlInclude(typeof(LicensePlateIDType))]
    [XmlInclude(typeof(LanguageIDType))]
    [XmlInclude(typeof(JourneyIDType))]
    [XmlInclude(typeof(IssuerIDType))]
    [XmlInclude(typeof(IssueNumberIDType))]
    [XmlInclude(typeof(InstructionIDType))]
    [XmlInclude(typeof(InformationURIType))]
    [XmlInclude(typeof(ImmobilizationCertificateIDType))]
    [XmlInclude(typeof(IdentificationIDType))]
    [XmlInclude(typeof(IDType))]
    [XmlInclude(typeof(HazardClassIDType))]
    [XmlInclude(typeof(FreightForwarderAssignedIDType))]
    [XmlInclude(typeof(ExtendedIDType))]
    [XmlInclude(typeof(ExchangeMarketIDType))]
    [XmlInclude(typeof(EndpointIDType))]
    [XmlInclude(typeof(EconomicOperatorRegistryURIType))]
    [XmlInclude(typeof(DocumentIDType))]
    [XmlInclude(typeof(CustomizationIDType))]
    [XmlInclude(typeof(CustomerAssignedAccountIDType))]
    [XmlInclude(typeof(ContractedCarrierAssignedIDType))]
    [XmlInclude(typeof(ContractFolderIDType))]
    [XmlInclude(typeof(ConsumptionReportIDType))]
    [XmlInclude(typeof(ConsumptionIDType))]
    [XmlInclude(typeof(ConsignorAssignedIDType))]
    [XmlInclude(typeof(ConsigneeAssignedIDType))]
    [XmlInclude(typeof(CompanyIDType))]
    [XmlInclude(typeof(ChipApplicationIDType))]
    [XmlInclude(typeof(CarrierAssignedIDType))]
    [XmlInclude(typeof(CV2IDType))]
    [XmlInclude(typeof(BuyerProfileURIType))]
    [XmlInclude(typeof(BuyerEventIDType))]
    [XmlInclude(typeof(BusinessIdentityEvidenceIDType))]
    [XmlInclude(typeof(BusinessClassificationEvidenceIDType))]
    [XmlInclude(typeof(BrokerAssignedIDType))]
    [XmlInclude(typeof(BarcodeSymbologyIDType))]
    [XmlInclude(typeof(AwardingCriterionIDType))]
    [XmlInclude(typeof(AuctionURIType))]
    [XmlInclude(typeof(AttributeIDType))]
    [XmlInclude(typeof(AircraftIDType))]
    [XmlInclude(typeof(AgencyIDType))]
    [XmlInclude(typeof(AdditionalAccountIDType))]
    [XmlInclude(typeof(AccountIDType))]
    [XmlInclude(typeof(ExtensionVersionIDType))]
    [XmlInclude(typeof(ExtensionURIType))]
    [XmlInclude(typeof(ExtensionAgencyURIType))]
    [XmlInclude(typeof(ExtensionAgencyIDType))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class IdentifierType
    {

        /// <remarks/>
        [XmlAttribute(DataType = "normalizedString")]
        public string? schemeID;

        /// <remarks/>
        [XmlAttribute]
        public string? schemeName;

        /// <remarks/>
        [XmlAttribute(DataType = "normalizedString")]
        public string? schemeAgencyID;

        /// <remarks/>
        [XmlAttribute]
        public string? schemeAgencyName;

        /// <remarks/>
        [XmlAttribute(DataType = "normalizedString")]
        public string? schemeVersionID;

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string? schemeDataURI;

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string? schemeURI;

        /// <remarks/>
        [XmlText(DataType = "normalizedString")]
        public string? Value;
    }
}
