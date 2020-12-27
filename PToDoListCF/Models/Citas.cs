using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //public string Nombre_Usuario { get; set; }
        //public string Nombre_Medico { get; set; }
        //[Required(ErrorMessage = "Se requiere fecha para la cita Ej: 01/01/2020")]
        // [Display(Name = "Fecha de la cita")]
        //[DataType(DataType.Date)]
        //  [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Fecha { get; set; }
        [Required]  
        [DataType(DataType.Time)]
        public TimeSpan hora { get; set; }
        [Required]
        [Range(0,1)]
        public int pagado { get; set; }

        //public virtual ICollection<Medico> Medicos { get; set; }
        //public virtual ICollection<Usersxd> Usersxd { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Usersxd Usersxd { get; set; }
    }
}