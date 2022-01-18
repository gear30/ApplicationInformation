using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public interface IInformationDto
    {
        (bool status, string message) CreateInformation(Information information);
        (bool status, int informationId, string message) UpdateTitle(int informationId, string title);
        (bool status, int informationId, string message) UpdateFirstname(int informationId, string firstname);
        (bool status, int informationId, string message) UpdateLastname(int informationId, string lastname);
        (bool status, int informationId, string message) UpdateDateofBirth(int informationId, DateTime dateOfBirth);
        (bool status, int informationId, string message) UpdateCountry(int informationId, string country);
        (bool status, int informationId, string message) UpdateAddress(int informationId, Address address);
        (bool status, int informationId, string message) UpdateOccupation(int informationId, Occupation occupation);

    }
}
