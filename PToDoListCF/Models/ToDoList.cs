using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PToDoListCF.Models
{
    public class ToDoList : DbContext
    {
        public DbSet<Citas> Citas { set; get; }
        public DbSet<Especialidad> Especialidad { set; get; }
        public DbSet<Medico> Medico { set; get; }
        public DbSet<Pagos> Pagos { set; get; }
        public DbSet<Preguntas> Preguntas { set; get; }
        public DbSet<Procedimiento> Procedimiento { set; get; }
        public DbSet<Usersxd> Usersxd { set; get; }
    }
}