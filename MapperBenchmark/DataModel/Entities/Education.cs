using System;

namespace MapperBenchmark.DataModel.Entities
{
    public class Education
	{
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Degree { get; set; }
		public	string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
        public string[] Courses { get; set; }

    }
}
