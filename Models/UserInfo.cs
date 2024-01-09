using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email alanı zorunlu")]
        [EmailAddress(ErrorMessage = "Hatalı email")]

        public string? Email { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunlu")]

        public string? Phone { get; set; }
        [Required(ErrorMessage = "Katılım durumu alanı zorunlu")]

        public bool? WillAttend { get; set; }

    }
}