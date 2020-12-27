using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Usersxd
    {
        public int UsersxdID { get; set; }

        public string name { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        [Range(1,120)]
        public int edad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string celular { get; set; }
        [Required]
        
        public string cedula { get; set; }

        public virtual ICollection<Citas> Citas { get; set; }
    }

}