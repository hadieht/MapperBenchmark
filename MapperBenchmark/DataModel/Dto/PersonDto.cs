using System;
using System.Collections.Generic;

namespace MapperBenchmark.DataModel.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string[] PhoneNumbers { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMarrid { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? MarrigeDate { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public byte[] IdCard { get; set; }
        public List<EmailDto> Emails { get; set; }
        public List<AddressDto> Addresses { get; set; }
        public List<EducationDto> EductionHistory { get; set; }
    }
}
