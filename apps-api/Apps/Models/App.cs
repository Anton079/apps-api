using apps_api.Apps.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apps_api.Apps.Models
{
    [Table("app")]
    public class App
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; } 

        [Required]
        [Column("model")]
        public string Model { get; set; }

        [Required]
        [Column("price")]
        public int Price { get; set; }
    }
}
