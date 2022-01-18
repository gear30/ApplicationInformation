using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Request
{
    public class AddressRequest
    {
        public string HouseAddressString { get; set; }
        public string WorkAddressString { get; set; }
    }
}
