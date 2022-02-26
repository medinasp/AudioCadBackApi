using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioCad.Models
{
    public class AudioCadContext : DbContext
    {
        public AudioCadContext()
        {
        }


        public AudioCadContext(DbContextOptions<AudioCadContext> options) : base(options)
        {

        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<PaymentDetail> paymentDetails { get; set; }
        public DbSet<Project> Projects{ get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=GuiaConstrucao;Integrated Security=True");
        //                optionsBuilder.UseMySql("server=localhost;database=AudioCad;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));
        //                //optionsBuilder.UseMySql("SERVER=50.116.87.169; DATABASE=artes440_AudioTel; UID=artes440_audtel; PWD=~bx]9hVh]A5T;TreatTinyAsBoolean=false", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));

        //            }
        //        }
    }
}
