using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Citas
    {
        public int CitasID { get; set; }
        public int MedicoID { get; set; }
        public int UsersxdID { get; set; }
        //public int Id_medico { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre_Medico { get; set; }
        public string Fecha { get; set; }
        public TimeSpan Tiempo { get; set; }

        //public virtual ICollection<Medico> Medicos { get; set; }
        //public virtual ICollection<Usersxd> Usersxd { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Usersxd Usersxd { get; set; }
    }
}