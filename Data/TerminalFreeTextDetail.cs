using System;
namespace OrdersReaderBlazorApp.Data
{
    public class TerminalFreeTextDetail
    {
        public string terminalId { get; set; }
        public string terminalFreeText { get; set; } // most important property here
        public string terminalCompanyId { get; set; }
        public string terminalShopId { get; set; }
        public string action { get; set; }

        public string backgroundPopupColorCssClass { get; set; }
    }
}

