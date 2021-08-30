using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Models
{
    public partial class AlquilerMaquinariaContext : DbContext
    {
        public AlquilerMaquinariaContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<ADJUNTO> ADJUNTOS { get; set; }
        public virtual DbSet<CLIENTE> CLIENTEs { get; set; }
        public virtual DbSet<CONTRATO> CONTRATOes { get; set; }
        public virtual DbSet<DETALLE_CONTRATO> DETALLE_CONTRATO { get; set; }
        public virtual DbSet<MAQUINARIA> MAQUINARIAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADJUNTO>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUNTO>()
                .Property(e => e.ruta)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.dni_ruc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.nombres_razonsocial)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.ADJUNTOS)
                .WithOptional(e => e.CLIENTE)
                .HasForeignKey(e => e.idCliente);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CONTRATOes)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.idCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATO>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATO>()
                .Property(e => e.monto_adicionales)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTRATO>()
                .HasMany(e => e.DETALLE_CONTRATO)
                .WithRequired(e => e.CONTRATO)
                .HasForeignKey(e => e.idContrato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DETALLE_CONTRATO>()
                .Property(e => e.monto_precio_dia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DETALLE_CONTRATO>()
                .Property(e => e.monto_subtotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DETALLE_CONTRATO>()
                .Property(e => e.monto_descuento)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MAQUINARIA>()
                .Property(e => e.equipo)
                .IsUnicode(false);

            modelBuilder.Entity<MAQUINARIA>()
                .Property(e => e.numero_serie)
                .IsUnicode(false);

            modelBuilder.Entity<MAQUINARIA>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<MAQUINARIA>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<MAQUINARIA>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<MAQUINARIA>()
                .Property(e => e.precio_dia_defecto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MAQUINARIA>()
                .HasMany(e => e.DETALLE_CONTRATO)
                .WithRequired(e => e.MAQUINARIA)
                .HasForeignKey(e => e.idMaquinaria)
                .WillCascadeOnDelete(false);
        }
    }
}
