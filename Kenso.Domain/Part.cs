namespace Kenso.Domain
{
    public class Part
    {
        public Part(string number)
        {
            Number = number;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string Number { get; set; }
        public string? Description { get; set; }

        public Model? Model { get; set; }
    }
}