using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region One

            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");

            #region Two

            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");

            #region Three

            try
            {
                using (var streamRead = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamRead.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops");
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");

            #region Four

            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
            Console.ReadLine();
        }
    }
}
