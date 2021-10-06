using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HoangTrungThong774.Models
{
    public class PersonHTT774
    {
        [Key]
        public string PersonId { get; set; }
        [Required(ErrorMessage="Please enter product name.")]
         [Display(Name = "Tên")]
        public string PersonName { get; set; }
    }
}
