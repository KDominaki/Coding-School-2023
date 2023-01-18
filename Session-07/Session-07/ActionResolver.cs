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


        public ActionResponse Execute(ActionRequest action) 
        {
            try
            {
                switch (action.Action)
                {
                    case ActionEnum.Convert:
                        ActionResponse convert = new ActionResponse();
                        string convertResult = convert.Convert().ToString();

                        MessageLogger message = new MessageLogger();
                        message.Messages[0] = new Message("Convert Done", DateTime.Now);

                        return new ActionResponse(convertResult);

                    case ActionEnum.Uppercase:
                        ActionResponse uppercase = new ActionResponse();
                        string result = uppercase.Uppercase();
                        MessageLogger upperMessage = new MessageLogger();
                        upperMessage.Messages[0] = new Message("Uppercase Done", DateTime.Now);

                        return new ActionResponse(result);

                        
                    case ActionEnum.Reverse:
                        ActionResponse reverse = new ActionResponse();
                        string reverseResult =reverse.Reverse();

                        MessageLogger reverseMessage = new MessageLogger();
                        reverseMessage.Messages[0] = new Message("Reverse Done", DateTime.Now);

                        return new ActionResponse(reverseResult);
                        

                }
            }
            catch (Exception ex)
            {
                MessageLogger message = new MessageLogger();
                message.Messages[0] = new Message(ex.Message, DateTime.Now);
                return null;
                throw;
            }

            return null;



        }
    }
}
