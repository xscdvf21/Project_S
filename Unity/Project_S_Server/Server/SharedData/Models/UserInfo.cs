using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedData.Models
{
    public class UserInfo
    {
        [Key]
        public string userID { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
        public DateTime date { get; set; }

        
    }
}
