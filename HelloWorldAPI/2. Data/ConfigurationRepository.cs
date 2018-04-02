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
    /// Repository to obtain the message from the configuration file
    /// </summary>
    public class ConfigurationRepository : IRepository
    {
        public MessageDto GetMessage()
        {
            return new MessageDto(ConfigurationManager.AppSettings["Message"]);
        }
    }
}
