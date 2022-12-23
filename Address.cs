using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2
{
    
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Street { get; set; } = null!;
        public string House { get; set; } = null!;
        public string Apartment { get; set; } = null!;

    }
}
