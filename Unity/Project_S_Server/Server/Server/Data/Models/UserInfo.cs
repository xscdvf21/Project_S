using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data.Models
{
    public class UserInfo
    {
        public int iIndex { get; set; }
        [Key]
        public string userID { get; set; }
        public string password { get; set; }
        public string userName { get; set; }

        public DateTime date { get; set; }
    }
}
