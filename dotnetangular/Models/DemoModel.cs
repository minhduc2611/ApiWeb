using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetangular.Models
{
    [Table("Models")]
    public class DemoModel
    {
        public int Id {get;set;}

        [Required]
        [StringLength(225)]
        public string Name {get;set;}

        public Make Make { get; set; }

        public int MakeId { get; set; }
    }

}