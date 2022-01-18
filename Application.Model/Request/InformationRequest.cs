using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Model.Request
{
    public class InformationRequest
    {

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryOfResidence { get; set; }
        public AddressRequest InformationAddress { get; set; }
        public OccupationRequest InformationOccupation { get; set; }
    }
}
