using Microsoft.Data.SqlClient;

namespace Mock_Test_01.Application;
using Models;

public class CurrencyService : ICurrencyService
{
    private string _connectionString;

    public CurrencyService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public SearchResultDto SearchByCountry(string countryName)
    {
        var result = new SearchResultDto
        {
            Name = countryName,
            Currencies = new List<CurrencyDto>()
        };
        
        var sql = @"SELECT c.Name, c.Rate 
                    FROM Currency c 
                    JOIN Currency_Country cc ON c.Id = cc.Currency_Id
                    JOIN Country co ON co.id = cc.Country_Id
                    WHERE co.name = @countryName";

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@countryName", countryName);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            if(reader.HasRows)
                while (reader.Read())
                {
                    result.Currencies.Add( new CurrencyDto
                        {
                            Name = reader.GetString(0),
                            Rate = reader.GetFloat(1)
                        }
                    );
                }
        }
        return result;
    }

    public SearchResultDto SearchByCurrency(string currencyName)
    {
        var result = new SearchResultDto
        {
            Name = currencyName,
            Countries = new List<string>()
        };

        var sql = @"SELECT co.Name FROM Country co
                    JOIN Currency_Contry cc ON co.Id = cc.Country_Id
                    JOIN Currency c ON c.Id = cc.Currency_Id
                    WHERE c.Name = @currencyName";

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@currencyName", currencyName);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            if(reader.HasRows)
                while (reader.Read())
                {
                    result.Countries.Add(reader.GetString(0));
                }
        }
        return result;
    }
}