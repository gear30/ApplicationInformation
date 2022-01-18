using Application.DTO;
using Application.Model;
using Application.Model.Request;
using AutoMapper;
using System;

namespace Application.Service
{
    public class ApplicationService : IApplicationService
    {
        private readonly IInformationDto _informationDto;
        private readonly IMapper _mapper;
        public ApplicationService(IInformationDto informationDto, IMapper mapper)
        {
            this._informationDto = informationDto;
            this._mapper = mapper;
        }
        public (bool status, string message) CreateInformation(InformationRequest information)
        {
            return _informationDto.CreateInformation(_mapper.Map<Information>(information));
        }

        public (bool status, int informationId, string message) UpdateTitle(int informationId, string title)
        {
            return _informationDto.UpdateTitle(informationId, title);
        }

        public (bool status, int informationId, string message) UpdateAddress(int informationId, AddressRequest address)
        {
            return _informationDto.UpdateAddress(informationId, _mapper.Map<Address>(address));
        }

        public (bool status, int informationId, string message) UpdateCountry(int informationId, string country)
        {
            return _informationDto.UpdateCountry(informationId, country);
        }

        public (bool status, int informationId, string message) UpdateDateofBirth(int informationId, DateTime dateOfBirth)
        {
            return _informationDto.UpdateDateofBirth(informationId, dateOfBirth);
        }

        public (bool status, int informationId, string message) UpdateFirstname(int informationId, string firstname)
        {
            return _informationDto.UpdateFirstname(informationId, firstname);
        }

        public (bool status, int informationId, string message) UpdateLastname(int informationId, string lastname)
        {
            return _informationDto.UpdateLastname(informationId, lastname);
        }

        public (bool status, int informationId, string message) UpdateOccupation(int informationId, OccupationRequest occupation)
        {
            return _informationDto.UpdateOccupation(informationId, _mapper.Map<Occupation>(occupation));
        }
    }
    public class MapRequestToDBModel : Profile
    {
        public MapRequestToDBModel()
        {
            CreateMap<InformationRequest, Information>();
            CreateMap<AddressRequest, Address>();
            CreateMap<OccupationRequest, Occupation>();
        }
    }
}
