using Application.Model;
using Application.Model.Request;
using System;

namespace Application.Service
{
    public interface IApplicationService
    {
        (bool status, string message) CreateInformation(InformationRequest information);
        (bool status, int informationId, string message) UpdateTitle(int informationId, string title);
        (bool status, int informationId, string message) UpdateFirstname(int informationId, string firstname);
        (bool status, int informationId, string message) UpdateLastname(int informationId, string lastname);
        (bool status, int informationId, string message) UpdateDateofBirth(int informationId, DateTime dateOfBirth);
        (bool status, int informationId, string message) UpdateCountry(int informationId, string country);
        (bool status, int informationId, string message) UpdateAddress(int informationId, AddressRequest address);
        (bool status, int informationId, string message) UpdateOccupation(int informationId, OccupationRequest occupation);
    }
}
