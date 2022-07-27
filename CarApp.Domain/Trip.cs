namespace CarApp.Domain;

public class Trip
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Distance { get; set; }
    public ICollection<Car> Cars { get; set; } = new List<Car>();
}
