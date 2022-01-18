using Application.DTO.AppDbContext;
using Application.DTO.Repositories;
using Application.Model;
using System;
using System.Linq;

namespace Application.DTO
{
    public class InformationDto: IInformationDto
    {
        private readonly IApplicationRepository _repository;
        public InformationDto(IApplicationRepository repository)
        {
             this._repository = repository;
        }
        #region save one time
        /// <summary>
        /// Save one time
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        public (bool status, string message) CreateInformation(Information information)
        {
            var massage = string.Empty;
            try
            {
                massage = CheckPermittedCountry(information);
                SaveInformation(information);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
            return (true, massage);
        }
        #endregion

        #region Save multiple time
        public (bool status, int informationId, string message) UpdateTitle(int informationId, string title)
        {
            var returnInformationId = informationId;
            try
            {
                var information = GetInformation(informationId);
                information.Title = title;
                returnInformationId = SaveInformation(information);
            }
            catch(Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, String.Empty);
        }

        public (bool status, int informationId, string message) UpdateAddress(int informationId, Address address)
        {
            var returnInformationId = informationId;
            try
            {
                var information = GetInformation(informationId);
                information.InformationAddress = address;
                returnInformationId = SaveInformation(information);
            }
            catch (Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, String.Empty);
        }

        public (bool status, int informationId, string message) UpdateCountry(int informationId, string country)
        {
            var returnInformationId = informationId;
            try
            {
                var information = GetInformation(informationId);
                information.CountryOfResidence = country;
                returnInformationId = SaveInformation(information);
            }
            catch (Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, String.Empty);
        }

        public (bool status, int informationId, string message) UpdateDateofBirth(int informationId, DateTime dateOfBirth)
        {
            var returnInformationId = informationId;
            try
            {
                var information = GetInformation(informationId);
                information.DateOfBirth = dateOfBirth;
                returnInformationId = SaveInformation(information);
            }
            catch (Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, String.Empty);
        }

        public (bool status, int informationId, string message) UpdateFirstname(int informationId, string firstname)
        {
            var returnInformationId = informationId;
            try
            {
                var information = GetInformation(informationId);
                information.FirstName = firstname;
                returnInformationId = SaveInformation(information);
            }
            catch (Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, String.Empty);
        }

        public (bool status, int informationId, string message) UpdateLastname(int informationId, string lastname)
        {
            var returnInformationId = informationId;
            try
            {
                var information = GetInformation(informationId);
                information.LastName = lastname;
                returnInformationId = SaveInformation(information);
            }
            catch (Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, String.Empty);
        }

        public (bool status, int informationId, string message) UpdateOccupation(int informationId, Occupation occupation)
        {
            var returnInformationId = informationId;
            var message = string.Empty;
            try
            {
                var information = GetInformation(informationId);
                information.InformationOccupation = occupation;
                returnInformationId = SaveInformation(information);
                message = CheckPermittedCountry(information);

            }
            catch (Exception ex)
            {
                return (false, returnInformationId, ex.Message);
            }
            return (true, returnInformationId, message);
        }
        #endregion
        #region private function
        private Information GetInformation(int id)
        {
            if (id == 0) return new Information();
            return _repository.GetInforation(id);
        }

        private int SaveInformation(Information information)
        {
            var id = information.ID;
            if (id == 0)
                id = _repository.AddInformation(information);
            else
                id = _repository.Updatenformation(information);
            return id;

        }
        private string CheckPermittedCountry(Information information)
        {
            return !_repository.CheckCountryPermitted(information.CountryOfResidence) ? "Country is not permitted." : string.Empty;
        }
        #endregion
    }
}
