﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTour.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnTourEntities1 : DbContext
    {
        public OnTourEntities1()
            : base("name=OnTourEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<ActividadTuristica> ActividadTuristica { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Apoderado> Apoderado { get; set; }
        public virtual DbSet<Colegio> Colegio { get; set; }
        public virtual DbSet<ContratoPrestacionServicio> ContratoPrestacionServicio { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<DepositoAlumno> DepositoAlumno { get; set; }
        public virtual DbSet<DepositoCurso> DepositoCurso { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<PaqueteTuristico> PaqueteTuristico { get; set; }
        public virtual DbSet<Representante> Representante { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Seguro> Seguro { get; set; }
        public virtual DbSet<Transporte> Transporte { get; set; }
    }
}
