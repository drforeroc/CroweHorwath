using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Entities;

namespace HelloWorldAPI.Data
{
    /// <summary>
    /// Interface for the data access repositories
    /// </summary>
    interface IRepository
    {
        MessageDto GetMessage();
    }
}
