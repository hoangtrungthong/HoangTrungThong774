using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HoangTrungThong774.Models
{
    public class HTT0774
    {
        [Key]
        public string HTTId { get; set; }
         [Display(Name = "Tên")]
        public string HTTName { get; set; }
         [Display(Name = "Giới Tính")]
        public string HTTGender { get; set; }
    }
    public class StringProcessHTT774 : HTT0774
    {
       
        public string HTTName { get; set; }
    }
}
