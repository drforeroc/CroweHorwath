using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Entities;

namespace HelloWorldAPI.Data
{
    /// <summary>
    /// Repository to obtain the message for the Business rule 01
    /// </summary>
    public class HardCodeRepository : IRepository
    {
        public MessageDto GetMessage()
        {
            return new MessageDto("Hello World");
        }
    }
}
