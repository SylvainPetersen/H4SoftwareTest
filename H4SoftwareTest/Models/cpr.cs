using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H4SoftwareTest.Models
{
    public class cpr
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        public string User { get; set; }
        [MaxLength(500)]
        public string? Cpr { get; set; }

    }
}
