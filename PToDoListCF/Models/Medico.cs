using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Medico
    {
        public int MedicoID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_especialidad { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string cedula { get; set; }
        public virtual Especialidad EspecialidadID { get; set; }
        public virtual ICollection<Citas> Citas { get; set; }
    }
}