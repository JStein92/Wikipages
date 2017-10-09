using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wikipages.Models
{
    [Table("business_type")]
    public class BusinessType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
