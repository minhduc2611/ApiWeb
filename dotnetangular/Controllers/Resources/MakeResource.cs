using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dotnetangular.Controllers.Resources
{
    public class MakeResource
    {
        public int Id {get;set;}

        public string Name {get;set;}
        public ICollection<DemoModelResource> Models {get; set;}

        public MakeResource(){
            Models = new Collection<DemoModelResource>();
        }
    }
}