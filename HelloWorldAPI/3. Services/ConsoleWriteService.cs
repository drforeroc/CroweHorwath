using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Data;
using HelloWorldAPI.Entities;

namespace HelloWorldAPI.Services
{
    /// <summary>
    /// Service to support writing in console
    /// </summary>
    public class ConsoleWriteService : IWriteService
    {       
        public void Write(MessageDto _message)
        {
            Console.Write(_message.Message);
        }
    }
}
