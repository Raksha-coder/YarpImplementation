namespace PatientApplication.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
