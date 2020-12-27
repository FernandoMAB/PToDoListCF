using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Pagos
    {
        public int PagosID { get; set; }
        public int id_cita { get; set; }
        public int id_procedimiento { get; set; }
        public float valor_total { get; set; }
        public virtual Citas CitasID { get; set; }
        public virtual Procedimiento ProcedimientoID { get; set; }
    }
}