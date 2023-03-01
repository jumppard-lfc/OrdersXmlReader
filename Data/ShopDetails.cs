using System;
namespace OrdersReaderBlazorApp.Data
{
    public class ShopDetails
    {
        public string merchantID { get; set; }
        public string chain { get; set; }
        public string name { get; set; }
        public string streetAddress { get; set; }
        public string town { get; set; }
        public string postCode { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string emails { get; set; }
        public string contact { get; set; }
        public string shopFreeText { get; set; }
        public string mcc { get; set; }
        public string action { get; set; }

        public string backgroundPopupColorCssClass { get; set; }
    }
}

