using System.Data.Entity;


namespace BMIcalculater.Models
{
    public class BMIContext: DbContext
    {
        public BMIContext(): base()
        {

        }
        public DbSet<BMIForm> forms { get; set; }
        public DbSet<Gender> gender { get; set; }
    }
}