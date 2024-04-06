using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Modelss;
using Modelss.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DatabaseContext
{
  public class CustomDbContext:DbContext
    {
        public CustomDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MExcelFile> MExcelFiles { get; set; }
        public DbSet<PoHeader> PoHeaders { get; set; }
        public DbSet<PoDetail> PoDetails { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
           modelBuilder.Query<SpEmployeeInfo>();          
          //  modelBuilder.Query<spOrderID>();
           

        }
        [Obsolete]
        public ICollection<SpEmployeeInfo> GetSpEmployeeInfo()
        {
            return this.Query<SpEmployeeInfo>().FromSql("Sp_EmployeeInfo").ToList();
        }
        [Obsolete]
        public ICollection<SpEmployeeInfo> GetSpEmployeeInfoID(int id)
        {
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "ID";
            p1.DbType = DbType.Int32;
            p1.Value = id == null ? 0 : id;

            return this.Query<SpEmployeeInfo>().FromSql("Sp_EmployeeInfoID @ID", p1).ToList();

        }
        
    }
}
