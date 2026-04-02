using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GKBS_SUPPORT_UI.Models
{
    public class SingleMasterModel
    {

    }
    public class LoginModel
    {
        public string CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFSD { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }

    public class Homescreen
    {
        public string CollectionDetailEnable { get; set; }
        public string ChequeDetailEnable { get; set; }
        public string TransVariantEnable { get; set; }
        public string Balances { get; set; }
        public string QuickAccess { get; set; }
        public string PendingDraft { get; set; }
        public string TransactionSummary { get; set; }

    }

    public class getsetdates
    {
        public string MinDate { get; set; }
        public string MaxDate { get; set; }
        public string Value { get; set; }
    }

}