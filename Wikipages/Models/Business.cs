
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wikipages.Models
{
    [Table("business")]
    public class Business
    {
        [Key]
        public int Id { get; set; }
        public int Business_Type_Id { get; set; }
        public string Name { get; set; }
    }
}
