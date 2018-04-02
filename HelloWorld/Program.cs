using HelloWorldAPI.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Declares the writting service to be used according to the configuration parameter
        /// </summary>
        /// <returns></returns>
        static IWriteService GetWriteServiceFromConfiguration()
        {
            if(ConfigurationManager.AppSettings["WriteMean"].Equals("Console"))
                return new ConsoleWriteService();
            
            //Code here the selection of your new WriteService

            //Return ConsoleWriteService by default
            return new ConsoleWriteService();
        }

        static void Main(string[] args)
        {
            
            ReadService readService = new ReadService();
            IWriteService writeService;

            var message = readService.Read();
                   
            writeService = GetWriteServiceFromConfiguration();

            writeService.Write(message);

            Console.ReadKey();
        }
    }
}
