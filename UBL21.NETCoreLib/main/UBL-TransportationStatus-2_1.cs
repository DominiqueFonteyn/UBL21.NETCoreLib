﻿

using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;

namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2")]
	[XmlRoot("TransportationStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2", IsNullable = false)]
	public class TransportationStatusType
	{
		[XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
		[XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
		public UBLExtensionType[] UBLExtensions { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UBLVersionIDType UBLVersionID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomizationIDType CustomizationID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProfileIDType ProfileID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProfileExecutionIDType ProfileExecutionID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CarrierAssignedIDType CarrierAssignedID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UUIDType UUID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueTimeType IssueTime { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType Name { get; set; }


		[XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description { get; set; }


		[XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ShippingOrderIDType ShippingOrderID { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OtherInstructionType OtherInstruction { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportationStatusTypeCodeType TransportationStatusTypeCode { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportExecutionStatusCodeType TransportExecutionStatusCode { get; set; }


		[XmlElementAttribute("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ConsignmentType[] Consignment { get; set; }


		[XmlElementAttribute("TransportEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportEventType[] TransportEvent { get; set; }


		[XmlElement("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] DocumentReference { get; set; }


		[XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SignatureType[] Signature { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType SenderParty { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType ReceiverParty { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType TransportationStatusRequestDocumentReference { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType TransportExecutionPlanDocumentReference { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportEventType UpdatedPickupTransportEvent { get; set; }


		[XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportEventType UpdatedDeliveryTransportEvent { get; set; }


		[XmlElementAttribute("StatusLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public LocationType1[] StatusLocation { get; set; }


		[XmlElementAttribute("StatusPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] StatusPeriod { get; set; }
	}
}