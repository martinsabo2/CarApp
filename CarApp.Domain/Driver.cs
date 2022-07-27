namespace CarApp.Domain;

public class Driver
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty; 
    public ICollection<Car> Cars { get; set; } = new List<Car>();
}
