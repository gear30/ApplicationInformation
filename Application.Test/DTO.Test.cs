using Application.DTO;
using Application.DTO.Repositories;
using Application.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    [TestClass]
    public class DTO
    {
        [TestMethod]
        public void TestCreateInformationPermitted()
        {
            IApplicationRepository appRepo = new MockApplicationRepository();
            IInformationDto informationDto = new InformationDto(appRepo);
            var information = new Information()
            {
                Title = "Mr.",
                FirstName = "Test",
                LastName = "Test",
                CountryOfResidence = "South Korea",
                DateOfBirth = new System.DateTime(2002, 1, 1),
                InformationAddress = new Address()
                {
                    HouseAddressString = "Gumnum South Korea",
                    WorkAddressString = "Gumnum South Korea"
                },
                InformationOccupation = new Occupation()
                {
                    BusinessType = "Information Technology",
                    JobTitle = "Devloper",
                    OccupationCode = "Dev"
                }
            };
            var result = informationDto.CreateInformation(information);
            Assert.AreEqual(result.status, true);
            Assert.AreEqual(result.message, "");
        }

        [TestMethod]
        public void TestCreateInformationNotPermitted()
        {
            IApplicationRepository appRepo = new MockApplicationRepository();
            IInformationDto informationDto = new InformationDto(appRepo);
            var information = new Information()
            {
                Title = "Mr.",
                FirstName = "Test",
                LastName = "Test",
                CountryOfResidence = "Cambodia",
                DateOfBirth = new System.DateTime(2002, 1, 1),
                InformationAddress = new Address()
                {
                    HouseAddressString = "Sem-rib Cambodia",
                    WorkAddressString = "Sem-rib Cambodia"
                },
                InformationOccupation = new Occupation()
                {
                    BusinessType = "Information Technology",
                    JobTitle = "Devloper",
                    OccupationCode = "Dev"
                }
            };
            var result = informationDto.CreateInformation(information);
            Assert.AreEqual(result.status, true);
            Assert.AreEqual(result.message, "Country is not permitted.");
        }

        [TestMethod]
        public void TestCreateInformationMultipleStepPermitted()
        {
            IApplicationRepository appRepo = new MockApplicationRepository();
            IInformationDto informationDto = new InformationDto(appRepo);
            var informationId = 0;
            var result1 = informationDto.UpdateTitle(informationId, "Mr.");
            informationId = result1.informationId;
            Assert.AreEqual(result1.status, true);
            Assert.AreEqual(result1.message, "");
            var result2 = informationDto.UpdateFirstname(informationId, "Test");
            Assert.AreEqual(result2.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result2.message, "");
            var result3 = informationDto.UpdateLastname(informationId, "Test");
            Assert.AreEqual(result3.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result3.message, "");
            var result4 = informationDto.UpdateDateofBirth(informationId, new System.DateTime(2002, 1, 1));
            Assert.AreEqual(result4.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result4.message, "");
            var result5 = informationDto.UpdateCountry(informationId, "South Korea");
            Assert.AreEqual(result5.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result5.message, "");
            var result6 = informationDto.UpdateAddress(informationId, new Address()
                                                                            {
                                                                                HouseAddressString = "Gumnum South Korea",
                                                                                WorkAddressString = "Gumnum South Korea"
                                                                            });
            Assert.AreEqual(result6.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result6.message, "");
            var result7 = informationDto.UpdateOccupation(informationId, new Occupation()
                                                                            {
                                                                                BusinessType = "Information Technology",
                                                                                JobTitle = "Devloper",
                                                                                OccupationCode = "Dev"
                                                                            });
            Assert.AreEqual(result7.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result7.message, "");
        }

        [TestMethod]
        public void TestCreateInformationMultipleStepNotPermitted()
        {
            IApplicationRepository appRepo = new MockApplicationRepository();
            IInformationDto informationDto = new InformationDto(appRepo);
            var informationId = 0;
            var result1 = informationDto.UpdateTitle(informationId, "Mr.");
            informationId = result1.informationId;
            Assert.AreEqual(result1.status, true);
            Assert.AreEqual(result1.message, "");
            var result2 = informationDto.UpdateFirstname(informationId, "Test");
            Assert.AreEqual(result2.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result2.message, "");
            var result3 = informationDto.UpdateLastname(informationId, "Test");
            Assert.AreEqual(result3.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result3.message, "");
            var result4 = informationDto.UpdateDateofBirth(informationId, new System.DateTime(2002, 1, 1));
            Assert.AreEqual(result4.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result4.message, "");
            var result5 = informationDto.UpdateCountry(informationId, "Cambodia");
            Assert.AreEqual(result5.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result5.message, "");
            var result6 = informationDto.UpdateAddress(informationId, new Address()
            {
                HouseAddressString = "Sem-rib Cambodia",
                WorkAddressString = "Sem-rib Cambodia"
            });
            Assert.AreEqual(result6.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result6.message, "");
            var result7 = informationDto.UpdateOccupation(informationId, new Occupation()
            {
                BusinessType = "Information Technology",
                JobTitle = "Devloper",
                OccupationCode = "Dev"
            });
            Assert.AreEqual(result7.status, true);
            Assert.AreEqual(result1.informationId, informationId);
            Assert.AreEqual(result7.message, "Country is not permitted.");
        }
    }
}
