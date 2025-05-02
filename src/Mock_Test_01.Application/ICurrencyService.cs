using Mock_Test_01.Models;

namespace Mock_Test_01.Application;

public interface ICurrencyService
{
    // public bool InsertCurrency(CurrencyDto currencyDto);
    public SearchResultDto SearchByCountry(string country);
    public SearchResultDto SearchByCurrency(string currency);
}