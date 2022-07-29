namespace CarApp.Domain;
public class Edition
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public Model? Model { get; set; }
}
