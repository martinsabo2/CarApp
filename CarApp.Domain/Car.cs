namespace CarApp.Domain;

public class Car
{
    public int Id { get; set; }
    public string VIN { get; set; } = string.Empty;
    public Model? Model { get; set; }
    public int ModelId { get; set; }
    public ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
