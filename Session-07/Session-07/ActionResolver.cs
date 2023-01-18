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
            Logger = new MessageLogger();
        }


        public ActionResponse Execute(ActionRequest request)
        {


            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            Log("EXECUTION START");

            try
            {

                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("CONVERT");
                        response.Output = response.Convert(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                        response.Output = response.Uppercase(request.Input);
                        break;

                    case ActionEnum.Reverse:
                        Log("REVERSE");
                        response.Output = response.Reverse(request.Input);
                        break;

                    default:
                        Log("Error");
                        break;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);

            }
            finally
            {
                Log("EXECUTION END");
            }


            return response;
        }

        private void Log(string text)
        {

            Logger.Write(new Message("------------"));

            Message message = new Message(text);
            Logger.Write(message);


        }


    }
}
