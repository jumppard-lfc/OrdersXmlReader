using System;
namespace OrdersReaderBlazorApp.Data
{

    /*
	 
	<gmft:element name="terminalAcqCode" type="xsd:Number" style="Default">5000</gmft:element>
	<gmft:element name="terminalCompanyId" type="xsd:String" style="Default">ZELSPOL</gmft:element>
	<gmft:element name="terminalShopId" type="xsd:String" style="Default">3503016</gmft:element>
	<gmft:element name="terminalId" type="xsd:String" style="Default">OBS14032</gmft:element>
	<gmft:element name="terminalRecActionId" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalPhysicalTerminalId" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalType" type="xsd:String" style="Default">MPOS</gmft:element>
	<gmft:element name="terminalEquipmentType" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalContactPerson" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalFuncContactPerson" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalPinBasedIndicator" type="xsd:String" style="Default">Y</gmft:element>
	<gmft:element name="terminalChipReadTermInd" type="xsd:String" style="Default">Y</gmft:element>
	<gmft:element name="terminalConnectionType" type="xsd:String" style="Default">OL</gmft:element>
	<gmft:element name="terminalPrinterType" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalInstallationType" type="xsd:String" style="Default">000</gmft:element>
	<gmft:element name="terminalInstallationDate" type="xsd:DateTime" style="sShortDate">2021-07-13</gmft:element>
	<gmft:element name="terminalTechData" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalHandlerId" type="xsd:String" style="Default">003</gmft:element>
	<gmft:element name="terminalOwner" type="xsd:String" style="Default">000</gmft:element>
	<gmft:element name="terminalAssignDate" type="xsd:DateTime" style="sShortDate">0001-01-01</gmft:element>
	<gmft:element name="terminalProcessingMode" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalRecurringTransFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalAuthTandemFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalCancelAuthFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalAuthWithPrintFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalCashFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalCancelCashFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalDataCaptureFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalDataCaptureAfterAuthFl" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalCancelDataCaptureFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalStatusFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalMailOrderFlag" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalCancelMailOrderFlag" type="xsd:String" style="Default">N</gmft:element>
	<gmft:element name="terminalInsertionDate" type="xsd:DateTime" style="sShortDate">2021-07-13</gmft:element>
	<gmft:element name="terminalLastUpdateDate" type="xsd:DateTime" style="sShortDate">2021-07-13</gmft:element>
	<gmft:element name="terminalLastUserUpdating" type="xsd:String" style="Default">CSOB276</gmft:element>
	<gmft:element name="terminalMachineCityName" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalstatus" type="xsd:String" style="Default">V</gmft:element>
	<gmft:element name="terminalInsertionUser" type="xsd:String" style="Default">CSOB276</gmft:element>
	<gmft:element name="terminalInsertionDate2" type="xsd:DateTime" style="sShortDate">2021-07-13</gmft:element>
	<gmft:element name="terminalInsertionUser2" type="xsd:String" style="Default">CSOB276</gmft:element>
	<gmft:element name="terminalLastUpdateDate2" type="xsd:DateTime" style="sShortDate">2021-07-13</gmft:element>
	<gmft:element name="terminalLastUserUpdating2" type="xsd:String" style="Default">CSOB276</gmft:element>
	<gmft:element name="terminalBase24TerminalProfile" type="xsd:String" style="Default">EMV</gmft:element>
	<gmft:element name="terminalFreeText" type="xsd:String" style="Default"></gmft:element>
	<gmft:element name="terminalTransactCurrencyCode" type="xsd:Number" style="Default">978</gmft:element>
	
	*/

    public class Terminal
	{
        public int?	terminalAcqCode { get; set; }
		public string terminalCompanyId { get; set; }
		public string terminalShopId { get; set; }
		public string terminalId { get; set; }
		public string terminalRecActionId { get; set; }
		public string terminalPhysicalTerminalId { get; set; }
		public string terminalType { get; set; }
		public string terminalEquipmentType { get; set; }
		public string terminalContactPerson { get; set; }
		public string terminalFuncContactPerson { get; set; }
		public string terminalPinBasedIndicator { get; set; }
		public string terminalChipReadTermInd { get; set; }
		public string terminalConnectionType { get; set; }
		public string terminalPrinterType { get; set; }
		public string terminalInstallationType { get; set; }
		public DateTime? terminalInstallationDate { get; set; }
		public string terminalTechData { get; set; }
		public string terminalHandlerId { get; set; }
		public string terminalOwner { get; set; }
		public DateTime? terminalAssignDate { get; set; }
		public string terminalProcessingMode { get; set; }
		public string terminalRecurringTransFlag { get; set; }
		public string terminalAuthTandemFlag { get; set; }
		public string terminalCancelAuthFlag { get; set; }
		public string terminalAuthWithPrintFlag { get; set; }
		public string terminalCashFlag { get; set; }
		public string terminalCancelCashFlag { get; set; }
		public string terminalDataCaptureFlag { get; set; }
		public string terminalDataCaptureAfterAuthFl { get; set; }
		public string terminalCancelDataCaptureFlag { get; set; }
		public string terminalStatusFlag { get; set; }
		public string terminalMailOrderFlag { get; set; }
		public string terminalCancelMailOrderFlag { get; set; }
		public DateTime? terminalInsertionDate { get; set; }
		public DateTime? terminalLastUpdateDate { get; set; }
		public string terminalLastUserUpdating { get; set; }
		public string terminalMachineCityName { get; set; }
		public string terminalstatus { get; set; }
		public string terminalInsertionUser { get; set; }
		public DateTime? terminalInsertionDate2 { get; set; }
		public string terminalInsertionUser2 { get; set; }
		public DateTime? terminalLastUpdateDate2 { get; set; }
		public string terminalLastUserUpdating2 { get; set; }
		public string terminalBase24TerminalProfile { get; set; }
		public string terminalFreeText { get; set; }
		public int? terminalTransactCurrencyCode { get; set; }

        // custom order helper field
        public string terminalRecActionIdOrderHelper { get; set; }
    }
}

