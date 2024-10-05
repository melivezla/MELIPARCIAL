using System.Net.Http;
using System.Threading.Tasks;

public class CurrencyConverterService
{
    private readonly HttpClient _httpClient;

    public CurrencyConverterService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
    {
        
        return 0; 
    }
}
