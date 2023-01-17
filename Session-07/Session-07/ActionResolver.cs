using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }

        public ActionResolver()
        {
           
        }

        public void Execute(ActionRequest action) 
        {
            if(action.Action == ActionEnum.Convert) 
            {

            }
            else if (action.Action == ActionEnum.Uppercase)
            {

            }

            else if (action.Action == ActionEnum.Reverse)
            {

            }
            else { }
        }
    }
}
