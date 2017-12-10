# IO.Swagger - the C# library for the WebAPI

Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/...  As a quick test try reaching the route http:/localhost:8080/api/info (remember that you can only access \"localhost\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md) 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: &lt;version&gt;
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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

            var apiInstance = new BlockApi();
            var uuid = uuid_example;  // string | The uuid of the block operation.

            try
            {
                // Cancel block operation
                BlockOperationResponse result = apiInstance.CancelBlockOperation(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.CancelBlockOperation: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://<host>/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BlockApi* | [**CancelBlockOperation**](docs/BlockApi.md#cancelblockoperation) | **DELETE** /block/op/{uuid} | Cancel block operation
*BlockApi* | [**ChangeBlockOperation**](docs/BlockApi.md#changeblockoperation) | **PUT** /block/op/{uuid} | Modify block operation
*BlockApi* | [**GetBlock**](docs/BlockApi.md#getblock) | **GET** /block/{world}/{x}/{y}/{z} | Get one block
*BlockApi* | [**GetBlockOperation**](docs/BlockApi.md#getblockoperation) | **GET** /block/op/{uuid} | Block operation details
*BlockApi* | [**GetBlockOperations**](docs/BlockApi.md#getblockoperations) | **GET** /block/op | List block operations
*BlockApi* | [**StartBlockOperation**](docs/BlockApi.md#startblockoperation) | **POST** /block/op | Create block operation
*ChunkApi* | [**GetChunk**](docs/ChunkApi.md#getchunk) | **GET** /world/{uuid}/chunk/{x}/{z} | Detailed chunk info
*ChunkApi* | [**GetChunks**](docs/ChunkApi.md#getchunks) | **GET** /world/{uuid}/chunk | Loaded chunk list
*CommandApi* | [**ExecuteCommand**](docs/CommandApi.md#executecommand) | **POST** /cmd | Execute command
*CommandApi* | [**GetCommand**](docs/CommandApi.md#getcommand) | **GET** /cmd/{name} | Detailed command info
*CommandApi* | [**GetCommands**](docs/CommandApi.md#getcommands) | **GET** /cmd | Command list
*EntityApi* | [**ChangeEntity**](docs/EntityApi.md#changeentity) | **PUT** /entity/{uuid} | Edit entity
*EntityApi* | [**CreateEntity**](docs/EntityApi.md#createentity) | **POST** /entity | Create an entity
*EntityApi* | [**DestroyEntity**](docs/EntityApi.md#destroyentity) | **DELETE** /entity/{uuid} | Destroy an entity
*EntityApi* | [**ExecuteEntityMethod**](docs/EntityApi.md#executeentitymethod) | **POST** /entity/{uuid} | Execute entity method
*EntityApi* | [**GetEntities**](docs/EntityApi.md#getentities) | **GET** /entity | Entities list
*EntityApi* | [**GetEntity**](docs/EntityApi.md#getentity) | **GET** /entity/{uuid} | Detailed entity info
*HistoryApi* | [**GetChatHistory**](docs/HistoryApi.md#getchathistory) | **GET** /history/chat | Chat History
*HistoryApi* | [**GetCommandHistory**](docs/HistoryApi.md#getcommandhistory) | **GET** /history/cmd | Command History
*HuskyCratesApi* | [**GetCrate**](docs/HuskyCratesApi.md#getcrate) | **GET** /husky/crate/{id} | Detailed crate info
*HuskyCratesApi* | [**GetCrates**](docs/HuskyCratesApi.md#getcrates) | **GET** /husky/crate | Crate list
*InfoApi* | [**GetInfo**](docs/InfoApi.md#getinfo) | **GET** /info | Server info
*MMCTicketsApi* | [**ChangeTicket**](docs/MMCTicketsApi.md#changeticket) | **PUT** /mmctickets/ticket/{id} | Edit ticket
*MMCTicketsApi* | [**GetTicket**](docs/MMCTicketsApi.md#getticket) | **GET** /mmctickets/ticket/{id} | Detailed ticket info
*MMCTicketsApi* | [**GetTickets**](docs/MMCTicketsApi.md#gettickets) | **GET** /mmctickets/ticket | Ticket list
*MessageApi* | [**GetMessage**](docs/MessageApi.md#getmessage) | **GET** /message/{uuid} | Detailed message info
*MessageApi* | [**GetMessages**](docs/MessageApi.md#getmessages) | **GET** /message | Message list
*MessageApi* | [**SendMessage**](docs/MessageApi.md#sendmessage) | **POST** /message | Send an interactive message
*NationsApi* | [**GetNation**](docs/NationsApi.md#getnation) | **GET** /nations/nation/{id} | Detailed nation info
*NationsApi* | [**GetNations**](docs/NationsApi.md#getnations) | **GET** /nations/nation | Nations list
*NucleusApi* | [**GetJail**](docs/NucleusApi.md#getjail) | **GET** /nucleus/jail/{name} | Detailed jail info
*NucleusApi* | [**GetJails**](docs/NucleusApi.md#getjails) | **GET** /nucleus/jail | Jail list
*NucleusApi* | [**GetKit**](docs/NucleusApi.md#getkit) | **GET** /nucleus/kit/{name} | Detailed kit info
*NucleusApi* | [**GetKits**](docs/NucleusApi.md#getkits) | **GET** /nucleus/kit | Kit list
*PlayerApi* | [**ChangePlayer**](docs/PlayerApi.md#changeplayer) | **PUT** /player/{uuid} | Edit player
*PlayerApi* | [**ExecutePlayerMethod**](docs/PlayerApi.md#executeplayermethod) | **POST** /player/{uuid} | Execute player method
*PlayerApi* | [**GetPlayer**](docs/PlayerApi.md#getplayer) | **GET** /player/{uuid} | Detailed player info
*PlayerApi* | [**GetPlayers**](docs/PlayerApi.md#getplayers) | **GET** /player | Player list
*PluginApi* | [**GetPlugin**](docs/PluginApi.md#getplugin) | **GET** /plugin/{id} | Detailed plugin info
*PluginApi* | [**GetPlugins**](docs/PluginApi.md#getplugins) | **GET** /plugin | Plugin list
*RegistryApi* | [**GetCatalogValues**](docs/RegistryApi.md#getcatalogvalues) | **GET** /registry/{className} | List catalog values
*ServletApi* | [**GetLoadedServlets**](docs/ServletApi.md#getloadedservlets) | **GET** /servlet | Loaded servlets
*TileEntityApi* | [**ExecuteTileEntityMethod**](docs/TileEntityApi.md#executetileentitymethod) | **POST** /tile-entity/{worldUuid}/{x}/{y}/{z} | Execute tile entity methods
*TileEntityApi* | [**GetTileEntities**](docs/TileEntityApi.md#gettileentities) | **GET** /tile-entity | Tile entities list
*TileEntityApi* | [**GetTileEntity**](docs/TileEntityApi.md#gettileentity) | **GET** /tile-entity/{worldUuid}/{x}/{y}/{z} | Detailed tile entity info
*UserApi* | [**CheckUser**](docs/UserApi.md#checkuser) | **GET** /user | Check a user key
*UserApi* | [**Login**](docs/UserApi.md#login) | **POST** /user | Login
*WorldApi* | [**ChangeWorld**](docs/WorldApi.md#changeworld) | **PUT** /world/{uuid} | Edit world
*WorldApi* | [**CreateWorld**](docs/WorldApi.md#createworld) | **POST** /world | Create a world
*WorldApi* | [**DeleteWorld**](docs/WorldApi.md#deleteworld) | **DELETE** /world/{uuid} | Delete a world
*WorldApi* | [**ExecuteWorldMethod**](docs/WorldApi.md#executeworldmethod) | **POST** /world/{uuid} | Execute world methods
*WorldApi* | [**GetChunk**](docs/WorldApi.md#getchunk) | **GET** /world/{uuid}/chunk/{x}/{z} | Detailed chunk info
*WorldApi* | [**GetChunks**](docs/WorldApi.md#getchunks) | **GET** /world/{uuid}/chunk | Loaded chunk list
*WorldApi* | [**GetWorld**](docs/WorldApi.md#getworld) | **GET** /world/{uuid} | Detailed world info
*WorldApi* | [**GetWorlds**](docs/WorldApi.md#getworlds) | **GET** /world | World list


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BlockFull](docs/BlockFull.md)
 - [Model.BlockOperation](docs/BlockOperation.md)
 - [Model.BlockOperationNew](docs/BlockOperationNew.md)
 - [Model.BlockOperationResponse](docs/BlockOperationResponse.md)
 - [Model.BlockOperationsList](docs/BlockOperationsList.md)
 - [Model.CatalogType](docs/CatalogType.md)
 - [Model.CatalogTypesResponse](docs/CatalogTypesResponse.md)
 - [Model.ChatHistoryResponse](docs/ChatHistoryResponse.md)
 - [Model.ChatMessage](docs/ChatMessage.md)
 - [Model.Chunk](docs/Chunk.md)
 - [Model.ChunkResponse](docs/ChunkResponse.md)
 - [Model.ChunksResponse](docs/ChunksResponse.md)
 - [Model.Command](docs/Command.md)
 - [Model.CommandCall](docs/CommandCall.md)
 - [Model.CommandHistoryResponse](docs/CommandHistoryResponse.md)
 - [Model.CommandRequest](docs/CommandRequest.md)
 - [Model.CommandResponse](docs/CommandResponse.md)
 - [Model.CommandResponse1](docs/CommandResponse1.md)
 - [Model.CommandResult](docs/CommandResult.md)
 - [Model.CommandsResponse](docs/CommandsResponse.md)
 - [Model.CreateEntityRequest](docs/CreateEntityRequest.md)
 - [Model.CreateWorldRequest](docs/CreateWorldRequest.md)
 - [Model.DamageRequest](docs/DamageRequest.md)
 - [Model.DamageRequest1](docs/DamageRequest1.md)
 - [Model.Data](docs/Data.md)
 - [Model.EntitiesList](docs/EntitiesList.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.EntityMethodResult](docs/EntityMethodResult.md)
 - [Model.EntityResponse](docs/EntityResponse.md)
 - [Model.ExecuteCommandResponse](docs/ExecuteCommandResponse.md)
 - [Model.ExecutePlayerMethodResponse](docs/ExecutePlayerMethodResponse.md)
 - [Model.ExecuteTileEntityMethodResponse](docs/ExecuteTileEntityMethodResponse.md)
 - [Model.ExecuteWorldMethodResponse](docs/ExecuteWorldMethodResponse.md)
 - [Model.HuskyCrate](docs/HuskyCrate.md)
 - [Model.HuskyCrateFullRewards](docs/HuskyCrateFullRewards.md)
 - [Model.HuskyCrateResponse](docs/HuskyCrateResponse.md)
 - [Model.HuskyCratesResponse](docs/HuskyCratesResponse.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.Inventory](docs/Inventory.md)
 - [Model.ItemStack](docs/ItemStack.md)
 - [Model.Location](docs/Location.md)
 - [Model.LoginRequest](docs/LoginRequest.md)
 - [Model.LoginResponse](docs/LoginResponse.md)
 - [Model.MMCTicket](docs/MMCTicket.md)
 - [Model.MMCTicketsTicketResponse](docs/MMCTicketsTicketResponse.md)
 - [Model.MMCTicketsTicketsResponse](docs/MMCTicketsTicketsResponse.md)
 - [Model.MMCUpdateTicketRequest](docs/MMCUpdateTicketRequest.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageOption](docs/MessageOption.md)
 - [Model.MessageRequest](docs/MessageRequest.md)
 - [Model.MessageResponse](docs/MessageResponse.md)
 - [Model.MessagesResponse](docs/MessagesResponse.md)
 - [Model.NationsNation](docs/NationsNation.md)
 - [Model.NationsNationResponse](docs/NationsNationResponse.md)
 - [Model.NationsNationsResponse](docs/NationsNationsResponse.md)
 - [Model.NationsRect](docs/NationsRect.md)
 - [Model.NationsZone](docs/NationsZone.md)
 - [Model.NucleusJailFull](docs/NucleusJailFull.md)
 - [Model.NucleusJailResponse](docs/NucleusJailResponse.md)
 - [Model.NucleusJailsResponse](docs/NucleusJailsResponse.md)
 - [Model.NucleusKit](docs/NucleusKit.md)
 - [Model.NucleusKitResponse](docs/NucleusKitResponse.md)
 - [Model.NucleusKitsResponse](docs/NucleusKitsResponse.md)
 - [Model.Ok](docs/Ok.md)
 - [Model.Player](docs/Player.md)
 - [Model.PlayerFullAchievements](docs/PlayerFullAchievements.md)
 - [Model.PlayerFullArmour](docs/PlayerFullArmour.md)
 - [Model.PlayerFullConnection](docs/PlayerFullConnection.md)
 - [Model.PlayerFullExperience](docs/PlayerFullExperience.md)
 - [Model.PlayerFullFood](docs/PlayerFullFood.md)
 - [Model.PlayerFullHealth](docs/PlayerFullHealth.md)
 - [Model.PlayerFullJoined](docs/PlayerFullJoined.md)
 - [Model.PlayerResponse](docs/PlayerResponse.md)
 - [Model.PlayersList](docs/PlayersList.md)
 - [Model.Plugin](docs/Plugin.md)
 - [Model.PluginResponse](docs/PluginResponse.md)
 - [Model.PluginsResponse](docs/PluginsResponse.md)
 - [Model.RawRequest](docs/RawRequest.md)
 - [Model.RawRequestParam](docs/RawRequestParam.md)
 - [Model.RawResponse](docs/RawResponse.md)
 - [Model.ServerInfo](docs/ServerInfo.md)
 - [Model.ServerInfoDetail](docs/ServerInfoDetail.md)
 - [Model.ServletsResponse](docs/ServletsResponse.md)
 - [Model.SingleBlock](docs/SingleBlock.md)
 - [Model.TileEntitiesResponse](docs/TileEntitiesResponse.md)
 - [Model.TileEntity](docs/TileEntity.md)
 - [Model.TileEntityResponse](docs/TileEntityResponse.md)
 - [Model.UpdateEntityRequest](docs/UpdateEntityRequest.md)
 - [Model.UpdatePlayerRequest](docs/UpdatePlayerRequest.md)
 - [Model.UpdateWorldRequest](docs/UpdateWorldRequest.md)
 - [Model.User](docs/User.md)
 - [Model.UserResponse](docs/UserResponse.md)
 - [Model.Vector3](docs/Vector3.md)
 - [Model.World](docs/World.md)
 - [Model.WorldFullBorder](docs/WorldFullBorder.md)
 - [Model.WorldFullDimension](docs/WorldFullDimension.md)
 - [Model.WorldFullDimensionType](docs/WorldFullDimensionType.md)
 - [Model.WorldFullGenerator](docs/WorldFullGenerator.md)
 - [Model.WorldResponse](docs/WorldResponse.md)
 - [Model.WorldsResponse](docs/WorldsResponse.md)
 - [Model.BlockOperationFull](docs/BlockOperationFull.md)
 - [Model.ChunkFull](docs/ChunkFull.md)
 - [Model.CommandFull](docs/CommandFull.md)
 - [Model.EntityFull](docs/EntityFull.md)
 - [Model.HuskyCrateFull](docs/HuskyCrateFull.md)
 - [Model.MMCTicketFull](docs/MMCTicketFull.md)
 - [Model.MessageFull](docs/MessageFull.md)
 - [Model.NationsNationFull](docs/NationsNationFull.md)
 - [Model.NucleusKitFull](docs/NucleusKitFull.md)
 - [Model.PlayerFull](docs/PlayerFull.md)
 - [Model.PluginFull](docs/PluginFull.md)
 - [Model.TileEntityFull](docs/TileEntityFull.md)
 - [Model.WorldFull](docs/WorldFull.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="headerKey"></a>
### headerKey

- **Type**: API key
- **API key parameter name**: x-webapi-key
- **Location**: HTTP header

<a name="queryKey"></a>
### queryKey

- **Type**: API key
- **API key parameter name**: key
- **Location**: URL query string

