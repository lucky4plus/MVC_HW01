using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models
{
    public class AccountBookMetadata
    {
        [MetadataType(typeof(AccountBookMetadata))]
        public partial class AccountBook
        {
            public Guid Id { get; set; }
            
            [DisplayName("類別")]
            public int Categoryyy { get; set; }
            
            [DisplayName("金額")]            
            public int Amounttt { get; set; }
            
            [DisplayName("日期")]
            public DateTime Dateee { get; set; }
           
            [DisplayName("備註")]                                   
            public string Remarkkk { get; set; }
        }

    }
}