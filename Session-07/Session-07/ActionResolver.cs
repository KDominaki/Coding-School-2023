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


            switch (action.Action)
            {
                case ActionEnum.Convert:
                    ActionResponse convert = new ActionResponse();
                    convert.Convert();
                    break;
                case ActionEnum.Uppercase: 
                    ActionResponse uppercase = new ActionResponse();
                    uppercase.Uppercase();
                    break;
                case ActionEnum.Reverse:
                    ActionResponse reverse = new ActionResponse();
                    reverse.Reverse();
                    break;

            }



        }
    }
}
