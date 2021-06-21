using System.Collections.Generic;
using System.Linq;


namespace MapperBenchmark.Config
{
    public static class ManualMapper
    {
        public static List<DataModel.Dto.PersonDto> ToPersonDtoList(this List<DataModel.Entities.Person> persons)
        {
            return persons.Select(a => a.ToPersonDto()).ToList();
        }

        public static List<DataModel.Dto.AddressDto> ToAddressDtoList(this List<DataModel.Entities.Address> addresses)
        {
            return addresses.Select(a => a.ToAddressDto()).ToList();
        }

        public static List<DataModel.Dto.EducationDto> ToEducationDtoList(this List<DataModel.Entities.Education> educations)
        {
            return educations.Select(a => a.ToEductionDto()).ToList();
        }

        public static List<DataModel.Dto.EmailDto> ToEmailDtoList(this List<DataModel.Entities.Email> emails)
        {
            return emails.Select(a => a.ToEmailDto()).ToList();
        }

        public static DataModel.Dto.PersonDto ToPersonDto(this DataModel.Entities.Person person)
        {
            return new DataModel.Dto.PersonDto()
            {
                Addresses = person.Addresses.ToAddressDtoList(),
                Age = person.Age,
                BirthDate = person.BirthDate,
                Description = person.Description,
                EductionHistory = person.EductionHistory.ToEducationDtoList(),
                Emails = person.Emails.ToEmailDtoList(),
                Id = person.Id,
                IdCard = person.IdCard,
                IsMarrid = person.IsMarrid,
                LastName = person.LastName,
                MarrigeDate = person.MarrigeDate,
                Name = person.Name,
                PhoneNumbers = person.PhoneNumbers,
                Photo = person.Photo,
                Salary = person.Salary
            };
        }

        public static DataModel.Dto.AddressDto ToAddressDto(this DataModel.Entities.Address address)
        {
            return new DataModel.Dto.AddressDto()
            {
                Id = address.Id,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                City = address.City,
                Country = address.Country,
                Picture = address.Picture,
                PostalCode = address.PostalCode,
                Region = address.Region
            };
        }

        public static DataModel.Dto.EducationDto ToEductionDto(this DataModel.Entities.Education education)
        {
            return new DataModel.Dto.EducationDto()
            {
                Id = education.Id,
                Courses = education.Courses,
                Degree = education.Degree,
                EndDate = education.EndDate,
                FieldOfStudy = education.FieldOfStudy,
                SchoolName = education.SchoolName,
                StartDate = education.StartDate
            };
        }

        public static DataModel.Dto.EmailDto ToEmailDto(this DataModel.Entities.Email email)
        {
            return new DataModel.Dto.EmailDto()
            {
                Id = email.Id,
                EmailAdresses = email.EmailAdresses
            };
        }
    }
}
