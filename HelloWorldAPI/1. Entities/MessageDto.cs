using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Entities
{
    public class MessageDto
    {
        private String _message;
        public String Message { get { return _message; } set { _message = value; } }
        public MessageDto(String Message)
        {
            _message = Message;
        }
    }
}
