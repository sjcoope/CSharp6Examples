using System;
using System.Net.Http;
using SJCNet.CSharp6.Utility;
using static System.Console;

namespace SJCNet.CSharp6.ExceptionFilter
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Exception Filter Example");

            var httpStatusCode = "404";
            WriteLine($"Http Status Code = {httpStatusCode}");

            // Previous Approach
            try
            {
                throw new Exception(httpStatusCode);
            }
            catch (Exception ex)
            {
                switch(ex.Message)
                {
                    case "401":
                        WriteLine("Unauthorized");
                        break;
                    case "402": 
                        WriteLine("Payment Required");
                        break;
                    case "403":
                        WriteLine("Forbidden");
                        break;
                    case "404":
                        WriteLine("Not Found");
                        break;
                }
            }

            // New Approach
            try
            {
                throw new Exception(httpStatusCode);
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                WriteLine("Unauthorized");
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                WriteLine("Payment Required");
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                WriteLine("Forbidden");
            }
            catch (Exception ex) when (ex.Message.Equals("404"))
            {
                WriteLine("Not Found");
            }
        }
    }
}
