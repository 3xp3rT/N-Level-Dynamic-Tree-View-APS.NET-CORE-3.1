using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N_Level_Dynamic_Tree_View_APS.NET_CORE_3._1.Models
{
    public class Account
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Account Name")]
        public string NameOfAc { get; set; }
        [Required]
        [Display(Name = "Account Type")]
        public int Type { get; set; }

        [Display(Name = "Parent")]
        public string ParentId { get; set; }
  
    }
    public enum AccountLevel
    {
        Debit = 1,
        Credit = 2

    }
}
