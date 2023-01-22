using System;
namespace OrdersReaderBlazorApp.Data
{

    /*
	<gmfs:element name="shopAcqCode" type="xsd:Number" style="Default">5000</gmfs:element>
	<gmfs:element name="shopCompanyId" type="xsd:String" style="Default">ZELSPOL</gmfs:element>
	<gmfs:element name="shopId" type="xsd:String" style="Default">3503016</gmfs:element>
	<gmfs:element name="shopRecordAction" type="xsd:String" style="Default">U</gmfs:element>
	<gmfs:element name="shopName" type="xsd:String" style="Default">ZSSK -KOSICE</gmfs:element>
	<gmfs:element name="shopStatus" type="xsd:String" style="Default">V</gmfs:element>
	<gmfs:element name="shopContactPerson" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopContactPersonFunction" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopAgentCode" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopRegisterNumber" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopRegisterProvince" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopMCC" type="xsd:Number" style="Default">4112</gmfs:element>
	<gmfs:element name="shopEnablePAN" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopDefaultRefundFlag" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopDefaultAuthFlag" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopDefaultSignaturePin" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopDefaultOfflineFloorLimit" type="xsd:Number" style="Default">0</gmfs:element>
	<gmfs:element name="shopDefaultOfflineFloorCurrenc" type="xsd:Number" style="Default">978</gmfs:element>
	<gmfs:element name="shopDefaultOfflineTipParameter" type="xsd:Number" style="Default">0</gmfs:element>
	<gmfs:element name="shopDefaultRandNum" type="xsd:Number" style="Default">0</gmfs:element>
	<gmfs:element name="shopDefaultOfflineKeyed" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopDefaultCATInd" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopDefaultCATMaxNum" type="xsd:Number" style="Default">0</gmfs:element>
	<gmfs:element name="shopHotelReserv" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopQuasiCash" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopCash" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopTurnoverLetterFlag" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopAggrCode" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopGeoSectorCode" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopStatementType" type="xsd:String" style="Default">ST</gmfs:element>
	<gmfs:element name="shopStatementCycle" type="xsd:String" style="Default">D</gmfs:element>
	<gmfs:element name="shopAdmContacPerson" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopAdmTitleOfThePerson" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopNickname" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopFirstContactMobileNumber" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopFirstContactEmailAddress" type="xsd:String" style="Default">DOPLPOKL.ZAHL@SLOVAKRAIL.SK</gmfs:element>
	<gmfs:element name="shopSecondContactMobileNumber" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopSecondContactEmailAddress" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopPreAuthorization" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopTip" type="xsd:String" style="Default">N</gmfs:element>
	<gmfs:element name="shopNumberOfActiveTerminals" type="xsd:String" style="Default">00000</gmfs:element>
	<gmfs:element name="shopFreeText" type="xsd:String" style="Default">NASTAVENIE LIMITOV AKO PILOT</gmfs:element>
	<gmfs:element name="shopAddressType" type="xsd:String" style="Default">PH</gmfs:element>
	<gmfs:element name="shopStreet" type="xsd:String" style="Default">LETNA</gmfs:element>
	<gmfs:element name="shopHouseNum" type="xsd:String" style="Default">27</gmfs:element>
	<gmfs:element name="shopProvinceCode" type="xsd:String" style="Default"></gmfs:element>
	<gmfs:element name="shopCity" type="xsd:String" style="Default">KOSICE</gmfs:element>
	<gmfs:element name="shopCountry" type="xsd:String" style="Default">SVK</gmfs:element>
	<gmfs:element name="shopZip" type="xsd:String" style="Default">040 01</gmfs:element> 
	*/

    public class Shop
	{
        public int shopAcqCode { get; set; }
        public string shopCompanyId { get; set; }
        public string shopId { get; set; }
        public string shopRecordAction { get; set; }
        public string shopName { get; set; }
        public string shopStatus { get; set; }
        public string shopContactPerson { get; set; }
        public string shopContactPersonFunction { get; set; }
        public string shopAgentCode { get; set; }
        public int? shopRegisterNumber { get; set; }
        public string shopRegisterProvince { get; set; }
        public int? shopMCC { get; set; }
        public string shopEnablePAN { get; set; }
        public string shopDefaultRefundFlag { get; set; }
        public string shopDefaultAuthFlag { get; set; }
        public string shopDefaultSignaturePin { get; set; }
        public int? shopDefaultOfflineFloorLimit { get; set; }
        public int? shopDefaultOfflineFloorCurrenc { get; set; }
        public int? shopDefaultOfflineTipParameter { get; set; }
        public int? shopDefaultRandNum { get; set; }
        public string shopDefaultOfflineKeyed { get; set; }
        public string shopDefaultCATInd { get; set; }
        public int? shopDefaultCATMaxNum { get; set; }
        public string shopHotelReserv { get; set; }
        public string shopQuasiCash { get; set; }
        public string shopCash { get; set; }
        public string shopTurnoverLetterFlag { get; set; }
        public string shopAggrCode { get; set; }
        public string shopGeoSectorCode { get; set; }
        public string shopStatementType { get; set; }
        public string shopStatementCycle { get; set; }
        public string shopAdmContacPerson { get; set; }
        public string shopAdmTitleOfThePerson { get; set; }
        public string shopNickname { get; set; }
        public string shopFirstContactMobileNumber { get; set; }
        public string shopFirstContactEmailAddress { get; set; }
        public string shopSecondContactMobileNumber { get; set; }
        public string shopSecondContactEmailAddress { get; set; }
        public string shopPreAuthorization { get; set; }
        public string shopTip { get; set; }
        public string shopNumberOfActiveTerminals { get; set; }
        public string shopFreeText { get; set; }
        public string shopAddressType { get; set; }
        public string shopStreet { get; set; }
        public string shopHouseNum { get; set; }
        public string shopProvinceCode { get; set; }
        public string shopCity { get; set; }
        public string shopCountry { get; set; }
        public string shopZip { get; set; }
    }
}

