using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using static System.Console;

namespace Lab2
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            var config = new ConfigurationBuilder().AddJsonFile(path: "appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<DbConnection>();
            DbConnection db = new DbConnection(optionsBuilder.UseSqlServer(config.GetConnectionString("DbConnection")).Options);

            var result = db.Receipts.Include(p => p.Consumer).Include(p => p.Consumer.Address).Include(p => p.Service).OrderBy(p => p.Consumer.LastName);

            WriteLine("#\tLastName\tName\tAddress\tService\tFinalAmount");

            foreach (var info in result)
            {
                WriteLine($"{info.ID}\t{info.Consumer.LastName}\t{info.Consumer.Name}\t" +
                    $"{info.Consumer.Address.Street} {info.Consumer.Address.House} {info.Consumer.Address.Apartment}\t" +
                    $"{info.Service.ServiceName}\t{info.FinalAmount}");
            }

        }
    }
}
