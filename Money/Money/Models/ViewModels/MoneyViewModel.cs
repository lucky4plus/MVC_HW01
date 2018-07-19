using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models.ViewModels
{
    public class MoneyViewModel
    {
        [Required]
        [DisplayName("類別")]
        public int Category { get; set; }
        [Required]
        [DisplayName("金額")]
        [Range(0, int.MaxValue)]
        public int Money { get; set; }
        [Required]
        [DisplayName("日期")]
        public DateTime Date { get; set; }
        [Required]
        [DisplayName("備註")]
        [MaxLength(100, ErrorMessage = "長度不可超過100字")]
        public string Remark { get; set; }
    }
    public enum MyCategory { 支出 = 1, 收入 };
}