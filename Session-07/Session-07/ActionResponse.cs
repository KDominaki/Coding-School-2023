using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        public ActionResponse(string output)
        {
           Output= output;
        }

        public string Convert(string input)
        {
            try
            {
               
                decimal text = Decimal.Parse(input);
                decimal binaryNum = text % 2;
                binaryNum /= 2;

                return binaryNum.ToString();
                
            } catch (Exception ex)
            {
                throw;
            }
           
            
        }    
        public string Uppercase(string input)
        {
            
            string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
                else { }


            }
            return word;
           

        }
        public string Reverse(string input)
        {   
            char[] cArray = input.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }

   

}
