using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Usersxd
    {
        public int UsersxdID { get; set; }
        public string name { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string celular { get; set; }
        public string cedula { get; set; }

        public virtual ICollection<Citas> Citas { get; set; }
    }
}