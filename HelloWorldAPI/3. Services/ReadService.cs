using HelloWorldAPI.Data;
using HelloWorldAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Services
{
    /// <summary>
    /// Service for read the message
    /// </summary>
    public class ReadService
    {
        IRepository DataRepository;
        
        public ReadService()
        {
            DataRepository = new HardCodeRepository();
        }

        public MessageDto Read()
        {
            return DataRepository.GetMessage();
        }
    }
}
