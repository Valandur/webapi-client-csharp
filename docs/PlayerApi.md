# IO.Swagger.Api.PlayerApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePlayer**](PlayerApi.md#changeplayer) | **PUT** /player/{uuid} | Edit player
[**ExecutePlayerMethod**](PlayerApi.md#executeplayermethod) | **POST** /player/{uuid} | Execute player method
[**GetPlayer**](PlayerApi.md#getplayer) | **GET** /player/{uuid} | Detailed player info
[**GetPlayers**](PlayerApi.md#getplayers) | **GET** /player | Player list


<a name="changeplayer"></a>
# **ChangePlayer**
> PlayerResponse ChangePlayer (string uuid, UpdatePlayerRequest updatePlayerRequest)

Edit player

Update the properties of an existing player.  > Required permission: player.change 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePlayerExample
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

            var apiInstance = new PlayerApi();
            var uuid = uuid_example;  // string | The uuid of the player.
            var updatePlayerRequest = new UpdatePlayerRequest(); // UpdatePlayerRequest | The new properties of the player

            try
            {
                // Edit player
                PlayerResponse result = apiInstance.ChangePlayer(uuid, updatePlayerRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerApi.ChangePlayer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the player. | 
 **updatePlayerRequest** | [**UpdatePlayerRequest**](UpdatePlayerRequest.md)| The new properties of the player | 

### Return type

[**PlayerResponse**](PlayerResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeplayermethod"></a>
# **ExecutePlayerMethod**
> ExecutePlayerMethodResponse ExecutePlayerMethod (string uuid, RawRequest request)

Execute player method

Provides direct access to the underlaying player object and can execute any method on it.  > Required permission: player.method 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutePlayerMethodExample
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

            var apiInstance = new PlayerApi();
            var uuid = uuid_example;  // string | The uuid of the player.
            var request = new RawRequest(); // RawRequest | Information about which method to execute.

            try
            {
                // Execute player method
                ExecutePlayerMethodResponse result = apiInstance.ExecutePlayerMethod(uuid, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerApi.ExecutePlayerMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the player. | 
 **request** | [**RawRequest**](RawRequest.md)| Information about which method to execute. | 

### Return type

[**ExecutePlayerMethodResponse**](ExecutePlayerMethodResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayer"></a>
# **GetPlayer**
> PlayerResponse GetPlayer (string uuid, string fields = null, string methods = null)

Detailed player info

Get detailed information about a player.  > Required permission: player.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlayerExample
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

            var apiInstance = new PlayerApi();
            var uuid = uuid_example;  // string | The uuid of the player to get detailed information about.
            var fields = fields_example;  // string | An optional list of additional fields to get. (optional) 
            var methods = methods_example;  // string | An optional list of additional methods to get. (optional) 

            try
            {
                // Detailed player info
                PlayerResponse result = apiInstance.GetPlayer(uuid, fields, methods);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the player to get detailed information about. | 
 **fields** | **string**| An optional list of additional fields to get. | [optional] 
 **methods** | **string**| An optional list of additional methods to get. | [optional] 

### Return type

[**PlayerResponse**](PlayerResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayers"></a>
# **GetPlayers**
> PlayersList GetPlayers ()

Player list

Get a list of all the players on the server.  > Required permission: player.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlayersExample
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

            var apiInstance = new PlayerApi();

            try
            {
                // Player list
                PlayersList result = apiInstance.GetPlayers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PlayersList**](PlayersList.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

