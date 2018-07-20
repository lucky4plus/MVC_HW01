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
        public Guid Id { get; set; }

        [Required(ErrorMessage = "請選擇類別")]
        [DisplayName("類別")]
        public int Category { get; set; }

        [Required]
        [DisplayName("金額")]
        [Range(0, int.MaxValue, ErrorMessage = "請輸入正整數")]
        public int Money { get; set; }

        
        [Required]        
        [DisplayName("日期")]
        [ValidLessThanToday]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "請輸入備註")]
        [DisplayName("備註")]
        [MaxLength(100, ErrorMessage = "長度不可超過100字")]
        public string Remark { get; set; }
    }
    public enum MyCategory { 支出, 收入 };
}