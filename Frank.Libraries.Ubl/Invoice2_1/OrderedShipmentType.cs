﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("OrderedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class OrderedShipmentType
    {

        private ShipmentType _shipmentField;

        private PackageType[] _packageField;

        /// <remarks/>
        public ShipmentType Shipment
        {
            get
            {
                return _shipmentField;
            }
            set
            {
                _shipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Package")]
        public PackageType[] Package
        {
            get
            {
                return _packageField;
            }
            set
            {
                _packageField = value;
            }
        }
    }
}