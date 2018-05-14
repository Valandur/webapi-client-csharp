# IO.Swagger - the C# library for the Web-API

Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/v5...  As a quick test try reaching the route http:/localhost:8080/api/v5/info (remember that you can only access \\\"localhost\\\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # List endpoints Lots of objects offer an endpoint to list all objects (e.g. `GET: /world` to get all worlds). These endpoints return only the properties marked 'required' by default, because the list might be quite large. If you want to return ALL data for a list endpoint add the query parameter `details`, (e.g. `GET: /world?details`).  > Remember that in this case the data returned by the endpoint might be quite large.  # Debugging endpoints Apart from the `?details` flag you can also pass some other flags for debugging purposes. Remember that you must include the first query parameter with `?`, and further ones with `&`:  `details`: Includes details for list endpoints  `accept=[json/xml]`: Manually set the accept content type. This is good for browser testing, **BUT DON'T USE THIS IN PRODUCTION, YOU CAN SUPPLY THE `Accepts` HEADER FOR THAT**  `pretty`: Pretty prints the data, also good for debugging in the browser.  An example request might look like this: `http://localhost:8080/api/v5/world?details&accpet=json&pretty&key=MY-API-KEY`  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: @version@
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/Valandur](https://github.com/Valandur)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
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

            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("X-WebAPI-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-WebAPI-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new ActiveTimeApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Server report
                ServerReport result = apiInstance.GetServerReport(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveTimeApi.GetServerReport: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost/api/v5*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActiveTimeApi* | [**GetServerReport**](docs/ActiveTimeApi.md#getserverreport) | **GET** /active-time | Server report
*ActiveTimeApi* | [**GetUserReport**](docs/ActiveTimeApi.md#getuserreport) | **GET** /active-time/user/{uuid} | User report
*BlockApi* | [**CreateBlockOperation**](docs/BlockApi.md#createblockoperation) | **POST** /block/op | Create a block operation
*BlockApi* | [**DeleteBlockOperation**](docs/BlockApi.md#deleteblockoperation) | **DELETE** /block/op/{uuid} | Stop a block operation
*BlockApi* | [**GetBlock**](docs/BlockApi.md#getblock) | **GET** /block/{world}/{x}/{y}/{z} | Get a block
*BlockApi* | [**GetBlockOperation**](docs/BlockApi.md#getblockoperation) | **GET** /block/op/{uuid} | Get a block operation
*BlockApi* | [**ListBlockOperations**](docs/BlockApi.md#listblockoperations) | **GET** /block/op | List block operations
*BlockApi* | [**ModifyBlockOperation**](docs/BlockApi.md#modifyblockoperation) | **PUT** /block/op/{uuid} | Modify a block operation
*ChunkApi* | [**CreateChunkAt**](docs/ChunkApi.md#createchunkat) | **POST** /chunk/{world}/{x}/{z} | Load & Generate a chunk
*ChunkApi* | [**GetChunkAt**](docs/ChunkApi.md#getchunkat) | **GET** /chunk/{world}/{x}/{z} | Get a chunk
*ChunkApi* | [**ListChunks**](docs/ChunkApi.md#listchunks) | **GET** /chunk/{world} | List chunks
*CommandApi* | [**GetCommand**](docs/CommandApi.md#getcommand) | **GET** /cmd/{cmd} | Get a command
*CommandApi* | [**ListCommands**](docs/CommandApi.md#listcommands) | **GET** /cmd | List commands
*CommandApi* | [**RunCommands**](docs/CommandApi.md#runcommands) | **POST** /cmd | Execute a command
*EconomyApi* | [**GetAccount**](docs/EconomyApi.md#getaccount) | **GET** /economy/account/{id} | List currencies
*EconomyApi* | [**GetCurrencies**](docs/EconomyApi.md#getcurrencies) | **GET** /economy/currency | List currencies
*EntityApi* | [**CreateEntity**](docs/EntityApi.md#createentity) | **POST** /entity | Spawn an entity
*EntityApi* | [**ExecuteMethod**](docs/EntityApi.md#executemethod) | **POST** /entity/{entity}/method | Execute a method
*EntityApi* | [**GetEntity**](docs/EntityApi.md#getentity) | **GET** /entity/{entity} | Get entity
*EntityApi* | [**ListEntities**](docs/EntityApi.md#listentities) | **GET** /entity | List entities
*EntityApi* | [**ModifyEntity**](docs/EntityApi.md#modifyentity) | **PUT** /entity/{entity} | Modify an entity
*EntityApi* | [**RemoveEntity**](docs/EntityApi.md#removeentity) | **DELETE** /entity/{entity} | Destroy an entity
*HistoryApi* | [**GetChat**](docs/HistoryApi.md#getchat) | **GET** /history/message | Get message history
*HistoryApi* | [**GetCommands**](docs/HistoryApi.md#getcommands) | **GET** /history/cmd | Get command history
*HuskyCratesApi* | [**CreateCrate**](docs/HuskyCratesApi.md#createcrate) | **POST** /husky-crates/crate | Create a crate
*HuskyCratesApi* | [**DeleteCrate**](docs/HuskyCratesApi.md#deletecrate) | **DELETE** /husky-crates/crate/{id} | Delete a crate
*HuskyCratesApi* | [**GetCrate**](docs/HuskyCratesApi.md#getcrate) | **GET** /husky-crates/crate/{id} | Get a crate
*HuskyCratesApi* | [**ListCrates**](docs/HuskyCratesApi.md#listcrates) | **GET** /husky-crates/crate | List crates
*HuskyCratesApi* | [**ModifyCrate**](docs/HuskyCratesApi.md#modifycrate) | **PUT** /husky-crates/crate/{id} | Change a crate
*InfoApi* | [**GetInfo**](docs/InfoApi.md#getinfo) | **GET** /info | Server info
*InfoApi* | [**GetStats**](docs/InfoApi.md#getstats) | **GET** /info/stats | Server stats
*InfoApi* | [**ListServlets**](docs/InfoApi.md#listservlets) | **GET** /info/servlets | List servlets
*InteractiveMessageApi* | [**GetMessage**](docs/InteractiveMessageApi.md#getmessage) | **GET** /interactive-message/{uuid} | Get a message
*InteractiveMessageApi* | [**ListMessages**](docs/InteractiveMessageApi.md#listmessages) | **GET** /interactive-message | List messages
*InteractiveMessageApi* | [**SendMessage**](docs/InteractiveMessageApi.md#sendmessage) | **POST** /interactive-message | Send a message
*MMCRestrictApi* | [**AddItem**](docs/MMCRestrictApi.md#additem) | **POST** /mmc-restrict/item | Add an item
*MMCRestrictApi* | [**DeleteItem**](docs/MMCRestrictApi.md#deleteitem) | **DELETE** /mmc-restrict/item/{id} | Delete an item
*MMCRestrictApi* | [**ListItems**](docs/MMCRestrictApi.md#listitems) | **GET** /mmc-restrict/item | List items
*MMCRestrictApi* | [**ModifyItem**](docs/MMCRestrictApi.md#modifyitem) | **PUT** /mmc-restrict/item/{id} | Modify an item
*MMCTicketsApi* | [**GetTicket**](docs/MMCTicketsApi.md#getticket) | **GET** /mmc-tickets/ticket/{id} | Get a ticket
*MMCTicketsApi* | [**ListTickets**](docs/MMCTicketsApi.md#listtickets) | **GET** /mmc-tickets/ticket | List tickets
*MMCTicketsApi* | [**ModifyTicket**](docs/MMCTicketsApi.md#modifyticket) | **PUT** /mmc-tickets/ticket/{id} | Modify a ticket
*MapApi* | [**GetMap**](docs/MapApi.md#getmap) | **GET** /map/{world}/{x}/{z} | Get a map tile
*NucleusApi* | [**CreateJail**](docs/NucleusApi.md#createjail) | **POST** /nucleus/jail | Create a jail
*NucleusApi* | [**CreateKit**](docs/NucleusApi.md#createkit) | **POST** /nucleus/kit | Create a kit
*NucleusApi* | [**DeleteJail**](docs/NucleusApi.md#deletejail) | **DELETE** /nucleus/jail/{name} | Delete a jail
*NucleusApi* | [**DeleteKit**](docs/NucleusApi.md#deletekit) | **DELETE** /nucleus/kit/{name} | Delete a kit
*NucleusApi* | [**GetJail**](docs/NucleusApi.md#getjail) | **GET** /nucleus/jail/{name} | Get a jail
*NucleusApi* | [**GetKit**](docs/NucleusApi.md#getkit) | **GET** /nucleus/kit/{name} | Get a kit
*NucleusApi* | [**ListHomes**](docs/NucleusApi.md#listhomes) | **GET** /nucleus/home/{player} | List homes
*NucleusApi* | [**ListJails**](docs/NucleusApi.md#listjails) | **GET** /nucleus/jail | List jails
*NucleusApi* | [**ListKits**](docs/NucleusApi.md#listkits) | **GET** /nucleus/kit | List kits
*NucleusApi* | [**ListMail**](docs/NucleusApi.md#listmail) | **GET** /nucleus/mail/{player} | List mail
*NucleusApi* | [**ListMail_0**](docs/NucleusApi.md#listmail_0) | **GET** /nucleus/module | List modules
*NucleusApi* | [**ModifyJail**](docs/NucleusApi.md#modifyjail) | **PUT** /nucleus/jail/{name} | Modify a jail
*NucleusApi* | [**ModifyKit**](docs/NucleusApi.md#modifykit) | **PUT** /nucleus/kit/{name} | Modify a kit
*PermissionApi* | [**GetCollection**](docs/PermissionApi.md#getcollection) | **GET** /permission/collection/{id} | Get collection
*PermissionApi* | [**GetSubject**](docs/PermissionApi.md#getsubject) | **GET** /permission/collection/{id}/subject/{subId} | Get subject
*PermissionApi* | [**ListCollections**](docs/PermissionApi.md#listcollections) | **GET** /permission/collection | List collections
*PermissionApi* | [**ListSubjects**](docs/PermissionApi.md#listsubjects) | **GET** /permission/collection/{id}/subject | List subjects
*PlayerApi* | [**ExecuteMethod**](docs/PlayerApi.md#executemethod) | **POST** /player/{player}/method | Execute a method
*PlayerApi* | [**GetPlayer**](docs/PlayerApi.md#getplayer) | **GET** /player/{player} | Get a player
*PlayerApi* | [**ListPlayers**](docs/PlayerApi.md#listplayers) | **GET** /player | List players
*PlayerApi* | [**ModifyPlayer**](docs/PlayerApi.md#modifyplayer) | **PUT** /player/{player} | Modify a player
*PluginApi* | [**ChangePluginConfig**](docs/PluginApi.md#changepluginconfig) | **POST** /plugin/{plugin}/config | Change plugin configs
*PluginApi* | [**GetPlugin**](docs/PluginApi.md#getplugin) | **GET** /plugin/{plugin} | Get a plugin
*PluginApi* | [**GetPluginConfig**](docs/PluginApi.md#getpluginconfig) | **GET** /plugin/{plugin}/config | Get plugin configs
*PluginApi* | [**ListPlugins**](docs/PluginApi.md#listplugins) | **GET** /plugin | List plugins
*PluginApi* | [**TogglePlugin**](docs/PluginApi.md#toggleplugin) | **PUT** /plugin/{plugin} | Toggle a plugin
*RecipeApi* | [**ListRecipes**](docs/RecipeApi.md#listrecipes) | **GET** /recipe | List recipes
*RedProtectApi* | [**CreateRegion**](docs/RedProtectApi.md#createregion) | **POST** /red-protect/region | Create a region
*RedProtectApi* | [**DeleteRegion**](docs/RedProtectApi.md#deleteregion) | **DELETE** /red-protect/region/{id} | Delete a region
*RedProtectApi* | [**GetRegion**](docs/RedProtectApi.md#getregion) | **GET** /red-protect/region/{id} | Get a region
*RedProtectApi* | [**ListRegions**](docs/RedProtectApi.md#listregions) | **GET** /red-protect/region | List regions
*RedProtectApi* | [**ModifyRegion**](docs/RedProtectApi.md#modifyregion) | **PUT** /red-protect/region/{id} | Modify a region
*RegistryApi* | [**GetRegistry**](docs/RegistryApi.md#getregistry) | **GET** /registry/{class} | Get a catalog type
*ServerApi* | [**ListProperties**](docs/ServerApi.md#listproperties) | **GET** /server/properties | List server properties
*ServerApi* | [**ModifyProperties**](docs/ServerApi.md#modifyproperties) | **PUT** /server/properties | Modify server properties
*TileEntityApi* | [**ExecuteMethod**](docs/TileEntityApi.md#executemethod) | **POST** /tile-entity/{world}/{x}/{y}/{z}/method | Execute a method
*TileEntityApi* | [**GetTileEntity**](docs/TileEntityApi.md#gettileentity) | **GET** /tile-entity/{world}/{x}/{y}/{z} | Get tile entity
*TileEntityApi* | [**ListTileEntities**](docs/TileEntityApi.md#listtileentities) | **GET** /tile-entity | List tile entities
*UniversalMarketApi* | [**ListMarketItems**](docs/UniversalMarketApi.md#listmarketitems) | **GET** /universal-market/item | List items
*UserApi* | [**GetUserDetails**](docs/UserApi.md#getuserdetails) | **GET** /user | Check info
*UserApi* | [**Login**](docs/UserApi.md#login) | **POST** /user | Login
*UserApi* | [**Logout**](docs/UserApi.md#logout) | **POST** /user/logout | Logout
*WebBooksApi* | [**CreateWebBook**](docs/WebBooksApi.md#createwebbook) | **POST** /web-books/book | Create a book
*WebBooksApi* | [**DeleteWebBook**](docs/WebBooksApi.md#deletewebbook) | **DELETE** /web-books/book/{id} | Delete a book
*WebBooksApi* | [**GetWebBook**](docs/WebBooksApi.md#getwebbook) | **GET** /web-books/book/{id} | Get a book
*WebBooksApi* | [**GetWebBookContent**](docs/WebBooksApi.md#getwebbookcontent) | **GET** /web-books/book/{id}/html | Book HTML
*WebBooksApi* | [**GetWebBookContentPost**](docs/WebBooksApi.md#getwebbookcontentpost) | **POST** /web-books/book/{id}/html | Book HTML
*WebBooksApi* | [**ListWebBooks**](docs/WebBooksApi.md#listwebbooks) | **GET** /web-books/book | List books
*WebBooksApi* | [**ModifyWebBook**](docs/WebBooksApi.md#modifywebbook) | **PUT** /web-books/book/{id} | Modify a book
*WorldApi* | [**CreateWorld**](docs/WorldApi.md#createworld) | **POST** /world | Create a world
*WorldApi* | [**DeleteWorld**](docs/WorldApi.md#deleteworld) | **DELETE** /world/{world} | Delete a world
*WorldApi* | [**ExecuteMethod**](docs/WorldApi.md#executemethod) | **POST** /world/{world}/method | Execute a method
*WorldApi* | [**GetWorld**](docs/WorldApi.md#getworld) | **GET** /world/{world} | Get a world
*WorldApi* | [**ListWorlds**](docs/WorldApi.md#listworlds) | **GET** /world | List worlds
*WorldApi* | [**ModifyWorld**](docs/WorldApi.md#modifyworld) | **PUT** /world/{world} | Modify a world


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AcceptsItems](docs/AcceptsItems.md)
 - [Model.Account](docs/Account.md)
 - [Model.Advancement](docs/Advancement.md)
 - [Model.AgeableData](docs/AgeableData.md)
 - [Model.ArmorSlotType](docs/ArmorSlotType.md)
 - [Model.ArmorStandData](docs/ArmorStandData.md)
 - [Model.AuthenticationRequest](docs/AuthenticationRequest.md)
 - [Model.BannerData](docs/BannerData.md)
 - [Model.BeaconData](docs/BeaconData.md)
 - [Model.BlockOperation](docs/BlockOperation.md)
 - [Model.BlockState](docs/BlockState.md)
 - [Model.BreathingData](docs/BreathingData.md)
 - [Model.BrewingStandData](docs/BrewingStandData.md)
 - [Model.CachedObject](docs/CachedObject.md)
 - [Model.Career](docs/Career.md)
 - [Model.CatalogType](docs/CatalogType.md)
 - [Model.CatalogTypeAdvancementTree](docs/CatalogTypeAdvancementTree.md)
 - [Model.CatalogTypeDifficulty](docs/CatalogTypeDifficulty.md)
 - [Model.CatalogTypeDimensionType](docs/CatalogTypeDimensionType.md)
 - [Model.CatalogTypeGameMode](docs/CatalogTypeGameMode.md)
 - [Model.CatalogTypeGeneratorType](docs/CatalogTypeGeneratorType.md)
 - [Model.CatalogTypeItemType](docs/CatalogTypeItemType.md)
 - [Model.CatalogTypeWeather](docs/CatalogTypeWeather.md)
 - [Model.Cause](docs/Cause.md)
 - [Model.Chunk](docs/Chunk.md)
 - [Model.Color](docs/Color.md)
 - [Model.Command](docs/Command.md)
 - [Model.CommandCall](docs/CommandCall.md)
 - [Model.CommandData](docs/CommandData.md)
 - [Model.CommandResult](docs/CommandResult.md)
 - [Model.CreateBlockOperationRequest](docs/CreateBlockOperationRequest.md)
 - [Model.CreateEntityRequest](docs/CreateEntityRequest.md)
 - [Model.CreateWorldRequest](docs/CreateWorldRequest.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.DamageRequest](docs/DamageRequest.md)
 - [Model.DamageableData](docs/DamageableData.md)
 - [Model.DespawnDelayData](docs/DespawnDelayData.md)
 - [Model.DurabilityData](docs/DurabilityData.md)
 - [Model.DyeColor](docs/DyeColor.md)
 - [Model.Enchantment](docs/Enchantment.md)
 - [Model.EndGatewayData](docs/EndGatewayData.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.EntityArchtype](docs/EntityArchtype.md)
 - [Model.EntitySnapshot](docs/EntitySnapshot.md)
 - [Model.EquipmentSlotType](docs/EquipmentSlotType.md)
 - [Model.ExecuteCommandRequest](docs/ExecuteCommandRequest.md)
 - [Model.ExecuteCommandResponse](docs/ExecuteCommandResponse.md)
 - [Model.ExecuteMethodParam](docs/ExecuteMethodParam.md)
 - [Model.ExecuteMethodRequest](docs/ExecuteMethodRequest.md)
 - [Model.ExecuteMethodResponse](docs/ExecuteMethodResponse.md)
 - [Model.ExperienceHolderData](docs/ExperienceHolderData.md)
 - [Model.FallingBlockData](docs/FallingBlockData.md)
 - [Model.FireworkEffect](docs/FireworkEffect.md)
 - [Model.FireworkRocketData](docs/FireworkRocketData.md)
 - [Model.FluidStack](docs/FluidStack.md)
 - [Model.FoodData](docs/FoodData.md)
 - [Model.FurnaceData](docs/FurnaceData.md)
 - [Model.FuseData](docs/FuseData.md)
 - [Model.GameMode](docs/GameMode.md)
 - [Model.GrowthData](docs/GrowthData.md)
 - [Model.GuiIdProperty](docs/GuiIdProperty.md)
 - [Model.HealthData](docs/HealthData.md)
 - [Model.HideData](docs/HideData.md)
 - [Model.HorseData](docs/HorseData.md)
 - [Model.HuskyCratesCrate](docs/HuskyCratesCrate.md)
 - [Model.HuskyCratesCrateReward](docs/HuskyCratesCrateReward.md)
 - [Model.HuskyCratesCrateRewardObject](docs/HuskyCratesCrateRewardObject.md)
 - [Model.Identifiable](docs/Identifiable.md)
 - [Model.IgniteableData](docs/IgniteableData.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.InlineResponse401](docs/InlineResponse401.md)
 - [Model.InlineResponse403](docs/InlineResponse403.md)
 - [Model.InlineResponse404](docs/InlineResponse404.md)
 - [Model.InlineResponse500](docs/InlineResponse500.md)
 - [Model.InlineResponse501](docs/InlineResponse501.md)
 - [Model.InteractiveMessage](docs/InteractiveMessage.md)
 - [Model.InteractiveMessageOption](docs/InteractiveMessageOption.md)
 - [Model.Inventory](docs/Inventory.md)
 - [Model.InventoryCapacity](docs/InventoryCapacity.md)
 - [Model.InventoryDimension](docs/InventoryDimension.md)
 - [Model.InventoryTitle](docs/InventoryTitle.md)
 - [Model.InvisibilityData](docs/InvisibilityData.md)
 - [Model.InvulnerabilityData](docs/InvulnerabilityData.md)
 - [Model.ItemStack](docs/ItemStack.md)
 - [Model.JoinData](docs/JoinData.md)
 - [Model.LeashData](docs/LeashData.md)
 - [Model.LocalDate](docs/LocalDate.md)
 - [Model.Location](docs/Location.md)
 - [Model.MMCRestrictItem](docs/MMCRestrictItem.md)
 - [Model.MMCTicketsTicket](docs/MMCTicketsTicket.md)
 - [Model.Message](docs/Message.md)
 - [Model.MinecartBlockData](docs/MinecartBlockData.md)
 - [Model.MobSpawnerData](docs/MobSpawnerData.md)
 - [Model.ModifyBlockOperationRequest](docs/ModifyBlockOperationRequest.md)
 - [Model.NucleusKit](docs/NucleusKit.md)
 - [Model.NucleusMailMessage](docs/NucleusMailMessage.md)
 - [Model.NucleusNamedLocation](docs/NucleusNamedLocation.md)
 - [Model.PatternLayer](docs/PatternLayer.md)
 - [Model.PermissionStruct](docs/PermissionStruct.md)
 - [Model.PickupDelayData](docs/PickupDelayData.md)
 - [Model.Player](docs/Player.md)
 - [Model.PluginContainer](docs/PluginContainer.md)
 - [Model.PluginDependency](docs/PluginDependency.md)
 - [Model.PotionEffect](docs/PotionEffect.md)
 - [Model.RedProtectRegion](docs/RedProtectRegion.md)
 - [Model.ServerInfo](docs/ServerInfo.md)
 - [Model.ServerProperty](docs/ServerProperty.md)
 - [Model.ServerReport](docs/ServerReport.md)
 - [Model.ServerStat](docs/ServerStat.md)
 - [Model.ServerStatDouble](docs/ServerStatDouble.md)
 - [Model.ServerStatInteger](docs/ServerStatInteger.md)
 - [Model.ServerStats](docs/ServerStats.md)
 - [Model.SlimeData](docs/SlimeData.md)
 - [Model.SlotIndex](docs/SlotIndex.md)
 - [Model.SlotPos](docs/SlotPos.md)
 - [Model.SlotSide](docs/SlotSide.md)
 - [Model.Stat](docs/Stat.md)
 - [Model.StructureData](docs/StructureData.md)
 - [Model.Subject](docs/Subject.md)
 - [Model.SubjectCollection](docs/SubjectCollection.md)
 - [Model.TableEntry](docs/TableEntry.md)
 - [Model.TableEntryEntityArchetype](docs/TableEntryEntityArchetype.md)
 - [Model.TameableData](docs/TameableData.md)
 - [Model.TileEntity](docs/TileEntity.md)
 - [Model.TimeHolder](docs/TimeHolder.md)
 - [Model.TradeOffer](docs/TradeOffer.md)
 - [Model.Transform](docs/Transform.md)
 - [Model.UniversalMarketItem](docs/UniversalMarketItem.md)
 - [Model.UpdateEntityRequest](docs/UpdateEntityRequest.md)
 - [Model.UpdatePlayerRequest](docs/UpdatePlayerRequest.md)
 - [Model.UpdateWorldRequest](docs/UpdateWorldRequest.md)
 - [Model.UserReport](docs/UserReport.md)
 - [Model.Vector2i](docs/Vector2i.md)
 - [Model.Vector3d](docs/Vector3d.md)
 - [Model.Vector3i](docs/Vector3i.md)
 - [Model.VehicleData](docs/VehicleData.md)
 - [Model.WebBooksBook](docs/WebBooksBook.md)
 - [Model.WireAttachmentData](docs/WireAttachmentData.md)
 - [Model.World](docs/World.md)
 - [Model.WorldBorder](docs/WorldBorder.md)
 - [Model.ChatMessage](docs/ChatMessage.md)
 - [Model.HuskyCratesCommandReward](docs/HuskyCratesCommandReward.md)
 - [Model.HuskyCratesItemReward](docs/HuskyCratesItemReward.md)
 - [Model.PlayerFull](docs/PlayerFull.md)
 - [Model.WorldFull](docs/WorldFull.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyHeader"></a>
### ApiKeyHeader

- **Type**: API key
- **API key parameter name**: X-WebAPI-Key
- **Location**: HTTP header

<a name="ApiKeyQuery"></a>
### ApiKeyQuery

- **Type**: API key
- **API key parameter name**: key
- **Location**: URL query string

