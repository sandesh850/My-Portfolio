using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models.EntityModels;

namespace MyPortfolio.Data
{
    public class AppDb:DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) :base (options)
        {

        }

        public DbSet<TblLogin> TblLogins { get; set; }

        public DbSet<TblPersonal_Project_Details> TblPersonal_Project_Details { get; set; }

        public DbSet<TblServices_Details> TblServices_Details { get; set; }

        public DbSet<TblContact> TblContacts { get; set; }
    }
}
