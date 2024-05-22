using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H4SoftwareTest.Models
{

    //id+user+cpr int til id (primary), nvarchar200 til user, nvarchar500 til cpr
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
