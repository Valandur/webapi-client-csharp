# IO.Swagger.Api.RegistryApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCatalogValues**](RegistryApi.md#getcatalogvalues) | **GET** /registry/{className} | List catalog values


<a name="getcatalogvalues"></a>
# **GetCatalogValues**
> CatalogTypesResponse GetCatalogValues (string className)

List catalog values

Lists all the catalog values of a specified CatalogType.  > Required permission: registry.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCatalogValuesExample
    {
        public void main()
        {
            // Configure API key authorization: headerKey
            Configuration.Default.ApiKey.Add("x-webapi-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-webapi-key", "Bearer");
            // Configure API key authorization: queryKey
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new RegistryApi();
            var className = className_example;  // string | The fully qualified class name of the CatalogType to get.

            try
            {
                // List catalog values
                CatalogTypesResponse result = apiInstance.GetCatalogValues(className);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistryApi.GetCatalogValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **className** | **string**| The fully qualified class name of the CatalogType to get. | 

### Return type

[**CatalogTypesResponse**](CatalogTypesResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

