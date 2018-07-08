using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Money.Models.ViewModels
{
    public class MoneyViewModel
    {
        public int Category { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
    }
    public enum MyCategory { 支出 = 1, 收入 };
}