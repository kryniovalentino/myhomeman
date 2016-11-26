using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeManager
{
    public interface IAuthenticator
    {
        Task Authenticate();
    }
}
