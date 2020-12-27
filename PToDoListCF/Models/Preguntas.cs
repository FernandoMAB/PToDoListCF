using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class Preguntas
    {
        public int PreguntasID { get; set; }
        public int id_usuario { get; set; }
        public string pregunta1 { get; set; }
        public string pregunta2 { get; set; }
        public string pregunta3 { get; set; }
        public virtual Usersxd UsersxdID { get; set; }
    }
}