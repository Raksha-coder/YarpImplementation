namespace ProviderApplication.Entities
{
    public class Provider
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Designation { get; set; }
    }
}
