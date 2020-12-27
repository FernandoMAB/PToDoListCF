using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Procedimiento
    {
        public int ProcedimientoID { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int id_especialidad { get; set; }
        public virtual Especialidad EspecialidadID { get; set; }
    }
}