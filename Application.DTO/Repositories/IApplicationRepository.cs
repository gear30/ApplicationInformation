using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Repositories
{
    public interface IApplicationRepository
    {
        public int AddInformation(Information information);
        public Information GetInforation(int informationId);
        public int Updatenformation(Information information);
        public bool CheckCountryPermitted(string CountryName);

    }
}
