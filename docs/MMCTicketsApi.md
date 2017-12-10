# IO.Swagger.Api.MMCTicketsApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeTicket**](MMCTicketsApi.md#changeticket) | **PUT** /mmctickets/ticket/{id} | Edit ticket
[**GetTicket**](MMCTicketsApi.md#getticket) | **GET** /mmctickets/ticket/{id} | Detailed ticket info
[**GetTickets**](MMCTicketsApi.md#gettickets) | **GET** /mmctickets/ticket | Ticket list


<a name="changeticket"></a>
# **ChangeTicket**
> MMCTicketsTicketResponse ChangeTicket (string id, MMCUpdateTicketRequest updateTicketRequest)

Edit ticket

Update the properties of an existing ticket.  > Required permission: mmctickets.ticket.change 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeTicketExample
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

            var apiInstance = new MMCTicketsApi();
            var id = id_example;  // string | The id of the ticket.
            var updateTicketRequest = new MMCUpdateTicketRequest(); // MMCUpdateTicketRequest | The new properties of the ticket

            try
            {
                // Edit ticket
                MMCTicketsTicketResponse result = apiInstance.ChangeTicket(id, updateTicketRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMCTicketsApi.ChangeTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the ticket. | 
 **updateTicketRequest** | [**MMCUpdateTicketRequest**](MMCUpdateTicketRequest.md)| The new properties of the ticket | 

### Return type

[**MMCTicketsTicketResponse**](MMCTicketsTicketResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getticket"></a>
# **GetTicket**
> MMCTicketsTicketResponse GetTicket (string id)

Detailed ticket info

Get detailed information about a ticket.  > Required permission: mmctickets.ticket.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTicketExample
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

            var apiInstance = new MMCTicketsApi();
            var id = id_example;  // string | The id of the ticket to get detailed information about.

            try
            {
                // Detailed ticket info
                MMCTicketsTicketResponse result = apiInstance.GetTicket(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMCTicketsApi.GetTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the ticket to get detailed information about. | 

### Return type

[**MMCTicketsTicketResponse**](MMCTicketsTicketResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettickets"></a>
# **GetTickets**
> MMCTicketsTicketsResponse GetTickets (string details = null)

Ticket list

Get a list of all the tickets on the server.  > Required permission: mmtickets.ticket.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTicketsExample
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

            var apiInstance = new MMCTicketsApi();
            var details = details_example;  // string | Pass this parameter to receive the full details for each ticket. (optional) 

            try
            {
                // Ticket list
                MMCTicketsTicketsResponse result = apiInstance.GetTickets(details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMCTicketsApi.GetTickets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **details** | **string**| Pass this parameter to receive the full details for each ticket. | [optional] 

### Return type

[**MMCTicketsTicketsResponse**](MMCTicketsTicketsResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

