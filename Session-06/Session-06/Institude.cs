using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Institude
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public Institude()
        {
            
        }

        public Institude(Guid id)
        {
            ID = id;
        }

        public Institude(Guid id, string name, int yearsInService)
        {
            Name = name;
            YearsInService = yearsInService;
            ID = id;
        }

        public Institude(Guid id, string name)
        {
            Name= name;
            ID = id;
        }

        public void GetName() { }
        public void SetName(string name) { }
    }
}
