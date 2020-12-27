using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Especialidad
    {
        public int EspecialidadID { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}