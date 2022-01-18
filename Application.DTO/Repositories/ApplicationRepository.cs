using Application.DTO.AppDbContext;
using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Repositories
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ApplicationRepository(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }
        public int AddInformation(Information information)
        {
            this._applicationDbContext.Informations.Add(information);
            this._applicationDbContext.SaveChanges();
            return information.ID;
        }

        public bool CheckCountryPermitted(string CountryName)
        {
            var countries = this._applicationDbContext.Countries;
            return countries.Where(x => x.CountryName.Equals(CountryName) && x.Permitted).Any();
        }

        public Information GetInforation(int informationId)
        {
            return this._applicationDbContext.Informations.Where(x=> x.ID == informationId).FirstOrDefault();
        }

        public int Updatenformation(Information information)
        {
            this._applicationDbContext.Informations.Update(information);
            this._applicationDbContext.SaveChanges();
            return information.ID;
        }
    }
}
