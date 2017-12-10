# IO.Swagger.Api.InfoApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInfo**](InfoApi.md#getinfo) | **GET** /info | Server info


<a name="getinfo"></a>
# **GetInfo**
> Object GetInfo ()

Server info

Get general information about the minecraft server.  > Required permission: info.get 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInfoExample
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

            var apiInstance = new InfoApi();

            try
            {
                // Server info
                Object result = apiInstance.GetInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfoApi.GetInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

