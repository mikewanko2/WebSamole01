using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSample01.Models
{
    public class User
    {
        [Display(Name = "ＩＤ")]
        public int Id { get; set; }

        [Display(Name = "名前")]
        public string Name { get; set; }

        [Display(Name = "カテゴリ")]
        public int CategoryId { get; set; } 
    }
}