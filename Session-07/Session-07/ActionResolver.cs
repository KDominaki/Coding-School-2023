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
            try
            {
                switch (action.Action)
                {
                    case ActionEnum.Convert:
                        ActionResponse convert = new ActionResponse();
                        convert.Convert();
                        MessageLogger message = new MessageLogger();
                        message.Messages[0] = new Message("Reverse Done");
                        break;
                    case ActionEnum.Uppercase:
                        ActionResponse uppercase = new ActionResponse();
                        uppercase.Uppercase();
                        MessageLogger upperMessage = new MessageLogger();
                        upperMessage.Messages[0] = new Message("Reverse Done");
                        break;
                    case ActionEnum.Reverse:
                        ActionResponse reverse = new ActionResponse();
                        reverse.Reverse();
                        MessageLogger reverseMessage = new MessageLogger();
                        reverseMessage.Messages[0] = new Message("Reverse Done");
                        break;

                }
            }catch(Exception ex)
            {
                MessageLogger message = new MessageLogger();
                message.Messages[0] = new Message(ex.Message);
                throw;
            }

            



        }
    }
}
