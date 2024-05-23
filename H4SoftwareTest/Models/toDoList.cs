using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace H4SoftwareTest.Models
{
    public class toDoList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        [MaxLength (500)]
        public string Item { get; set; }
        [ForeignKey("UserId")]
        public cpr cpr { get; set; }
    }
}
