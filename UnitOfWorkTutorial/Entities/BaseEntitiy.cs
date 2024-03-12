namespace UnitOfWorkTutorial.Entities
{
    public class BaseEntitiy
    {
        public int Id { get; set; }
        public DateTime CreatedAt => DateTime.Now;
    }
}
