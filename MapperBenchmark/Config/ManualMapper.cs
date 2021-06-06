using System.Collections.Generic;
using System.Linq;
using MapperBenchmark.DataModel.Dto;
using MapperBenchmark.DataModel.Entities;

namespace MapperBenchmark.Config
{
    public static class ManualMapper
    {
        public static List<Person> ToPersonList(this List<PersonDto> personDtos)
        {
            return personDtos.Select(a => a.ToPerson()).ToList();
        }

        public static List<Address> ToAddressList(this List<AddressDto> addressDto)
        {
            return addressDto.Select(a => a.ToAddress()).ToList();
        }

        public static List<Education> ToEducationList(this List<EducationDto> educationDto)
        {
            return educationDto.Select(a => a.ToEduction()).ToList();
        }

        public static List<Email> ToEmailList(this List<EmailDto> emailDto)
        {
            return emailDto.Select(a => a.ToEmail()).ToList();
        }

        public static Person ToPerson(this PersonDto personDto)
        {
            return new()
            {
                Addresses = personDto.Addresses.ToAddressList(),
                Age = personDto.Age,
                BirthDate = personDto.BirthDate,
                Description = personDto.Description,
                EductionHistory = personDto.EductionHistory.ToEducationList(),
                Emails = personDto.Emails.ToEmailList(),
                Id = personDto.Id,
                IdCard = personDto.IdCard,
                IsMarrid = personDto.IsMarrid,
                LastName = personDto.LastName,
                MarrigeDate = personDto.MarrigeDate,
                Name = personDto.Name,
                PhoneNumbers = personDto.PhoneNumbers,
                Photo = personDto.Photo,
                Salary = personDto.Salary
            };
        }

        public static Address ToAddress(this AddressDto addressDto)
        {
            return new()
            {
                Id = addressDto.Id,
                AddressLine1 = addressDto.AddressLine1,
                AddressLine2 = addressDto.AddressLine2,
                City = addressDto.City,
                Country = addressDto.Country,
                Picture = addressDto.Picture,
                PostalCode = addressDto.PostalCode,
                Region = addressDto.Region
            };
        }

        public static Education ToEduction(this EducationDto educationDto)
        {
            return new()
            {
                Id = educationDto.Id,
                Courses = educationDto.Courses,
                Degree = educationDto.Degree,
                EndDate = educationDto.EndDate,
                FieldOfStudy = educationDto.FieldOfStudy,
                SchoolName = educationDto.SchoolName,
                StartDate = educationDto.StartDate
            };
        }

        public static Email ToEmail(this EmailDto emailDto)
        {
            return new()
            {
                Id = emailDto.Id,
                EmailAdresses = emailDto.EmailAdresses
            };
        }
    }
}
