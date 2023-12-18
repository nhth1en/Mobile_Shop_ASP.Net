using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class Account
    {
        [Key]
        public int Account_Id { get; set; }

        public string Account_Email { get; set; }

        public string Account_FullName { get; set; }

        public string Account_Password { get; set; }

        [NotMapped]
        public string Account_ConfirmPassword { get; set; }

        public string Account_PhoneNumber { get; set; }

        public string Account_Sex { get; set; }

        public string Account_Permission { get; set; }

        public bool? Account_IsBlocked { get; set; }
    }
}
