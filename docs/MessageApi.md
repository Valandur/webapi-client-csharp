# IO.Swagger.Api.MessageApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMessage**](MessageApi.md#getmessage) | **GET** /message/{uuid} | Detailed message info
[**GetMessages**](MessageApi.md#getmessages) | **GET** /message | Message list
[**SendMessage**](MessageApi.md#sendmessage) | **POST** /message | Send an interactive message


<a name="getmessage"></a>
# **GetMessage**
> void GetMessage (string uuid)

Detailed message info

Get detailed information about a message.  > Required permission: message.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessageExample
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

            var apiInstance = new MessageApi();
            var uuid = uuid_example;  // string | The uuid of the message to get detailed information about.

            try
            {
                // Detailed message info
                apiInstance.GetMessage(uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageApi.GetMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the message to get detailed information about. | 

### Return type

void (empty response body)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessages"></a>
# **GetMessages**
> MessagesResponse GetMessages (string details = null)

Message list

Get a list of all the messages that were sent through the message endpoint since the server started.  > Required permission: message.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessagesExample
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

            var apiInstance = new MessageApi();
            var details = details_example;  // string | Pass this parameter to receive the full details for each message. (optional) 

            try
            {
                // Message list
                MessagesResponse result = apiInstance.GetMessages(details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageApi.GetMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **details** | **string**| Pass this parameter to receive the full details for each message. | [optional] 

### Return type

[**MessagesResponse**](MessagesResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessage"></a>
# **SendMessage**
> MessageResponse SendMessage (MessageRequest request)

Send an interactive message

Send an interactive message to a player. Make sure to have an event hook for \"custom_message\" to receive the response.  > Required permission: message.create 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendMessageExample
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

            var apiInstance = new MessageApi();
            var request = new MessageRequest(); // MessageRequest | Details of the message sent to the player

            try
            {
                // Send an interactive message
                MessageResponse result = apiInstance.SendMessage(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MessageRequest**](MessageRequest.md)| Details of the message sent to the player | 

### Return type

[**MessageResponse**](MessageResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

