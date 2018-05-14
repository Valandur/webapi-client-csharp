# IO.Swagger.Api.EconomyApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](EconomyApi.md#getaccount) | **GET** /economy/account/{id} | List currencies
[**GetCurrencies**](EconomyApi.md#getcurrencies) | **GET** /economy/currency | List currencies


<a name="getaccount"></a>
# **GetAccount**
> Account GetAccount (string id, bool? details = null, string accept = null, bool? pretty = null)

List currencies

Lists all the currencies that the current economy supports.     **Required permissions:**    - **economy.account.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.AddApiKey("X-WebAPI-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-WebAPI-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new EconomyApi();
            var id = id_example;  // string | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List currencies
                Account result = apiInstance.GetAccount(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EconomyApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencies"></a>
# **GetCurrencies**
> List<Currency> GetCurrencies (bool? details = null, string accept = null, bool? pretty = null)

List currencies

Lists all the currencies that the current economy supports.     **Required permissions:**    - **economy.currency.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrenciesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.AddApiKey("X-WebAPI-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-WebAPI-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new EconomyApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List currencies
                List&lt;Currency&gt; result = apiInstance.GetCurrencies(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EconomyApi.GetCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**List<Currency>**](Currency.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

