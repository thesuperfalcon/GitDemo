namespace TestSSAB.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public string StorageName { get; set; }
        public int? MaxCapacity { get; set; }
        public int? CurrentStock { get; set; }
        public DateTime Created { get; set; }

    }
}
