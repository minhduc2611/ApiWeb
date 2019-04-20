using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetangular.Models
{
    public class Make
    {
        public int Id {get;set;}

        [Required]
        [StringLength(225)]
        public string Name {get;set;}
        public ICollection<DemoModel> Models {get; set;}

        public Make(){
            Models = new Collection<DemoModel>();
        }
    }
}