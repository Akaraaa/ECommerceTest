using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Lütfen bir email giriniz")]
        [EmailAddress(ErrorMessage ="Lütfen bir email giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Lütfen bu kısmı doldurunuz")]
        public string Password { get; set; }
    }
}