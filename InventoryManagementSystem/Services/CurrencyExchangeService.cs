using System.Net.Http;
using System.Text.Json;

namespace InventoryManagement.Services
{
    public class CurrencyExchangeService
    {
        private readonly HttpClient _httpClient;
        private Dictionary<string, decimal> _exchangeRates;
        private DateTime _lastUpdate;
        private const string BASE_CURRENCY = "AUD"; // Changed to AUD

        // Using Frankfurter API !
        // Data from European Central Bank
        private const string API_URL = "https://api.frankfurter.app/latest";

        public CurrencyExchangeService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(10);
            _exchangeRates = new Dictionary<string, decimal>();
            _lastUpdate = DateTime.MinValue;
        }

        public async Task<bool> UpdateExchangeRatesAsync()
        {
            try
            {
                // Frankfurter API format: https://api.frankfurter.app/latest?from=AUD
                var response = await _httpClient.GetStringAsync($"{API_URL}?from={BASE_CURRENCY}");
                var jsonDoc = JsonDocument.Parse(response);

                _exchangeRates.Clear();

                // Add base currency with rate 1.0
                _exchangeRates[BASE_CURRENCY] = 1.0m;

                // Get rates from response
                var rates = jsonDoc.RootElement.GetProperty("rates");

                foreach (var rate in rates.EnumerateObject())
                {
                    if (rate.Value.ValueKind == JsonValueKind.Number)
                    {
                        _exchangeRates[rate.Name] = rate.Value.GetDecimal();
                    }
                }

                _lastUpdate = DateTime.Now;
                Console.WriteLine($"Exchange rates updated successfully. Base: {BASE_CURRENCY}, Rates loaded: {_exchangeRates.Count}");
                return true;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Network error updating exchange rates: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating exchange rates: {ex.Message}");
                return false;
            }
        }

        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            // Update rates if older than 24 hours or not loaded
            if (_exchangeRates.Count == 0 || (DateTime.Now - _lastUpdate).TotalHours > 24)
            {
                var success = await UpdateExchangeRatesAsync();
                if (!success && _exchangeRates.Count == 0)
                {
                    // If update failed and no cached rates, return original amount
                    Console.WriteLine("Could not load exchange rates, returning original amount");
                    return amount;
                }
            }

            if (fromCurrency == toCurrency)
                return amount;

            try
            {
                if (fromCurrency == BASE_CURRENCY)
                {
                    // Converting from AUD to another currency
                    return _exchangeRates.ContainsKey(toCurrency)
                        ? amount * _exchangeRates[toCurrency]
                        : amount;
                }
                else if (toCurrency == BASE_CURRENCY)
                {
                    // Converting to AUD from another currency
                    return _exchangeRates.ContainsKey(fromCurrency)
                        ? amount / _exchangeRates[fromCurrency]
                        : amount;
                }
                else
                {
                    // Convert through base currency (AUD)
                    // First convert to AUD, then to target currency
                    decimal inBaseCurrency = _exchangeRates.ContainsKey(fromCurrency)
                        ? amount / _exchangeRates[fromCurrency]
                        : amount;

                    return _exchangeRates.ContainsKey(toCurrency)
                        ? inBaseCurrency * _exchangeRates[toCurrency]
                        : inBaseCurrency;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during currency conversion: {ex.Message}");
                return amount;
            }
        }

        public List<string> GetPopularCurrencies()
        {
            // Ordered with AUD first, then by popularity
            return new List<string>
            {
                "AUD",  // Australian Dollar (default)
                "USD",  // US Dollar
                "EUR",  // Euro
                "GBP",  // British Pound
                "NZD",  // New Zealand Dollar
                "JPY",  // Japanese Yen
                "CAD",  // Canadian Dollar
                "SGD",  // Singapore Dollar
                "CNY",  // Chinese Yuan
                "HKD",  // Hong Kong Dollar
                "CHF",  // Swiss Franc
                "INR",  // Indian Rupee
                "KRW",  // South Korean Won
                "THB",  // Thai Baht
                "MYR",  // Malaysian Ringgit
                "IDR",  // Indonesian Rupiah
                "PHP",  // Philippine Peso
                "VND",  // Vietnamese Dong
            };
        }

        public string GetCurrencySymbol(string currencyCode)
        {
            return currencyCode switch
            {
                "AUD" => "A$",
                "USD" => "US$",
                "EUR" => "€",
                "GBP" => "£",
                "JPY" => "¥",
                "CAD" => "C$",
                "CHF" => "Fr",
                "CNY" => "¥",
                "INR" => "₹",
                "NZD" => "NZ$",
                "SGD" => "S$",
                "HKD" => "HK$",
                "KRW" => "₩",
                "THB" => "฿",
                "MYR" => "RM",
                "IDR" => "Rp",
                "PHP" => "₱",
                "VND" => "₫",
                _ => currencyCode
            };
        }

        public string GetCurrencyName(string currencyCode)
        {
            return currencyCode switch
            {
                "AUD" => "Australian Dollar",
                "USD" => "US Dollar",
                "EUR" => "Euro",
                "GBP" => "British Pound",
                "JPY" => "Japanese Yen",
                "CAD" => "Canadian Dollar",
                "CHF" => "Swiss Franc",
                "CNY" => "Chinese Yuan",
                "INR" => "Indian Rupee",
                "NZD" => "New Zealand Dollar",
                "SGD" => "Singapore Dollar",
                "HKD" => "Hong Kong Dollar",
                "KRW" => "South Korean Won",
                "THB" => "Thai Baht",
                "MYR" => "Malaysian Ringgit",
                "IDR" => "Indonesian Rupiah",
                "PHP" => "Philippine Peso",
                "VND" => "Vietnamese Dong",
                _ => currencyCode
            };
        }

        public DateTime GetLastUpdateTime()
        {
            return _lastUpdate;
        }

        public string GetBaseCurrency()
        {
            return BASE_CURRENCY;
        }

        public bool IsRatesLoaded()
        {
            return _exchangeRates.Count > 0;
        }
    }
}