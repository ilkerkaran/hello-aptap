using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.API.Models
{
    public class ClientSigninModel
    {
        public string ClientId { get;  set; }
        public string ClientSecret { get;  set; }
    }
}
