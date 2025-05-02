namespace Mock_Test_01.Models;

public class SearchResultDto
{
    public string Name { get; set; }
    public List<string> Countries { get; set; }
    public List<CurrencyDto> Currencies { get; set; } 
}