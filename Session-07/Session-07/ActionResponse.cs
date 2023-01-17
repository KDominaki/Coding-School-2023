using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResponse
    {
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }


        public ActionResponse()
        {
              
        }

        public string Convert()
        {
            string text = "Convert Works!!!";
            return text;
        }
        public string Uppercase()
        {
            string text = "Uppercase Works!!!";
            return text;
        }
        public string Reverse()
        {
            string text = "Reverse Works!!!";
            return text;
        }
    }

   

}
