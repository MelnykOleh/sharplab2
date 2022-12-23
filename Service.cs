using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2
{
    public class Service
    {
        [Key]
        public int ID { get; set; }
        public string ServiceName { get; set; } = null!;
        public string PricePerSquareMeter { get; set; } = null!;
        public string PricePerPerson { get; set; } = null!;

    }
}
