using System;
namespace OrdersReaderBlazorApp.Data
{

    /*
	<gmfc:element name="companyAcqCode" type="xsd:Number" style="Default">5000</gmfc:element>
	<gmfc:element name="companyId" type="xsd:String" style="Default">ZELSPOL</gmfc:element>
	<gmfc:element name="companyName" type="xsd:String" style="Default">ZELEZNICNA SPOLOCNOST SLOVENSKO</gmfc:element>
	<gmfc:element name="companyStatus" type="xsd:String" style="Default">V</gmfc:element>
	<gmfc:element name="companyContactPerson" type="xsd:String" style="Default"></gmfc:element>
	<gmfc:element name="companyContactPersonFunction" type="xsd:String" style="Default"></gmfc:element>
	<gmfc:element name="companyNickname" type="xsd:String" style="Default"></gmfc:element>
	<gmfc:element name="companyAddressType" type="xsd:String" style="Default">PH</gmfc:element>
	<gmfc:element name="companyStreet" type="xsd:String" style="Default">ROZNAVSKA</gmfc:element>
	<gmfc:element name="companyHouseNum" type="xsd:String" style="Default">1</gmfc:element>
	<gmfc:element name="companyProvinceCode" type="xsd:String" style="Default"></gmfc:element>
	<gmfc:element name="companyCity" type="xsd:String" style="Default">BRATISLAVA</gmfc:element>
	<gmfc:element name="companyCountry" type="xsd:String" style="Default">SVK</gmfc:element>
	<gmfc:element name="companyZip" type="xsd:String" style="Default">832 72</gmfc:element>
	 */
    public class Company
	{
		public int? companyAcqCode { get; set; }
		public string companyId { get; set; }
		public string companyName { get; set; }
		public string companyStatus { get; set; }
		public string companyContactPerson { get; set; }
		public string companyContactPersonFunction { get; set; }
		public string companyNickname { get; set; }
		public string companyAddressType { get; set; }
		public string companyStreet { get; set; }
		public string companyHouseNum { get; set; }
		public string companyProvinceCode { get; set; }
		public string companyCity { get; set; }
		public string companyCountry { get; set; }
		public string companyZip { get; set; }

		public string companyAddress { get; set; } // companyStreet + companyHouseNum + companyZip + companyCity

        public Company() { }
    }
}

