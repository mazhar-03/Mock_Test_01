namespace Mock_Test_01.Models;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Currency> Currencies { get; set; }
}