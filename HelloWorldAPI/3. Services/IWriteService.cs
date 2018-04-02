using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Entities;

namespace HelloWorldAPI.Services
{
    /// <summary>
    /// Interface to support write in different means
    /// </summary>
    public interface IWriteService
    {
        void Write(MessageDto _message);
    }
}
