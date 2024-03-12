namespace UnitOfWorkTutorial.Entities
{
    public class Employee : BaseEntitiy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
