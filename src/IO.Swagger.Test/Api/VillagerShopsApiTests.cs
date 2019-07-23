/* 
 * Web-API
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/v5...  As a quick test try reaching the route http:/localhost:8080/api/v5/info (remember that you can only access \\\"localhost\\\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # List endpoints Lots of objects offer an endpoint to list all objects (e.g. `GET: /world` to get all worlds). These endpoints return only the properties marked 'required' by default, because the list might be quite large. If you want to return ALL data for a list endpoint add the query parameter `details`, (e.g. `GET: /world?details`).  > Remember that in this case the data returned by the endpoint might be quite large.  # Debugging endpoints Apart from the `?details` flag you can also pass some other flags for debugging purposes. Remember that you must include the first query parameter with `?`, and further ones with `&`:  `details`: Includes details for list endpoints  `accept=[json/xml]`: Manually set the accept content type. This is good for browser testing, **BUT DON'T USE THIS IN PRODUCTION, YOU CAN SUPPLY THE `Accepts` HEADER FOR THAT**  `pretty`: Pretty prints the data, also good for debugging in the browser.  An example request might look like this: `http://localhost:8080/api/v5/world?details&accpet=json&pretty&key=MY-API-KEY`  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md)
 *
 * OpenAPI spec version: 5.4.2-S7.1.0
 * Contact: inithilian@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing VillagerShopsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VillagerShopsApiTests
    {
        private VillagerShopsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VillagerShopsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VillagerShopsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VillagerShopsApi
            //Assert.IsInstanceOfType(typeof(VillagerShopsApi), instance, "instance is a VillagerShopsApi");
        }

        
        /// <summary>
        /// Test AddShopItem
        /// </summary>
        [Test]
        public void AddShopItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //VillagerShopsStockItem body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.AddShopItem(id, body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsStockItem> (response, "response is VillagerShopsStockItem");
        }
        
        /// <summary>
        /// Test AddShopItem_0
        /// </summary>
        [Test]
        public void AddShopItem_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //VillagerShopsStockItem body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.AddShopItem_0(id, body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsStockItem> (response, "response is VillagerShopsStockItem");
        }
        
        /// <summary>
        /// Test CreateShop
        /// </summary>
        [Test]
        public void CreateShopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VillagerShopsShop body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.CreateShop(body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test CreateShop_0
        /// </summary>
        [Test]
        public void CreateShop_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VillagerShopsShop body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.CreateShop_0(body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test DeleteShop
        /// </summary>
        [Test]
        public void DeleteShopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteShop(id, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test DeleteShopItem
        /// </summary>
        [Test]
        public void DeleteShopItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //int? item = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteShopItem(id, item, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test DeleteShopItem_0
        /// </summary>
        [Test]
        public void DeleteShopItem_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //int? item = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteShopItem_0(id, item, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test DeleteShop_0
        /// </summary>
        [Test]
        public void DeleteShop_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteShop_0(id, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test GetShop
        /// </summary>
        [Test]
        public void GetShopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetShop(id, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test GetShopItem
        /// </summary>
        [Test]
        public void GetShopItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //int? item = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetShopItem(id, item, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsStockItem> (response, "response is VillagerShopsStockItem");
        }
        
        /// <summary>
        /// Test GetShopItem_0
        /// </summary>
        [Test]
        public void GetShopItem_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //int? item = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetShopItem_0(id, item, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsStockItem> (response, "response is VillagerShopsStockItem");
        }
        
        /// <summary>
        /// Test GetShop_0
        /// </summary>
        [Test]
        public void GetShop_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetShop_0(id, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test ListShopItems
        /// </summary>
        [Test]
        public void ListShopItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListShopItems(id, details, accept, pretty);
            //Assert.IsInstanceOf<List<VillagerShopsStockItem>> (response, "response is List<VillagerShopsStockItem>");
        }
        
        /// <summary>
        /// Test ListShopItems_0
        /// </summary>
        [Test]
        public void ListShopItems_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListShopItems_0(id, details, accept, pretty);
            //Assert.IsInstanceOf<List<VillagerShopsStockItem>> (response, "response is List<VillagerShopsStockItem>");
        }
        
        /// <summary>
        /// Test ListShops
        /// </summary>
        [Test]
        public void ListShopsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListShops(details, accept, pretty);
            //Assert.IsInstanceOf<List<VillagerShopsShop>> (response, "response is List<VillagerShopsShop>");
        }
        
        /// <summary>
        /// Test ListShops_0
        /// </summary>
        [Test]
        public void ListShops_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListShops_0(details, accept, pretty);
            //Assert.IsInstanceOf<List<VillagerShopsShop>> (response, "response is List<VillagerShopsShop>");
        }
        
        /// <summary>
        /// Test UpdateShop
        /// </summary>
        [Test]
        public void UpdateShopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //VillagerShopsShop body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.UpdateShop(id, body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
        /// <summary>
        /// Test UpdateShopItem
        /// </summary>
        [Test]
        public void UpdateShopItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //int? item = null;
            //VillagerShopsStockItem body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.UpdateShopItem(id, item, body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsStockItem> (response, "response is VillagerShopsStockItem");
        }
        
        /// <summary>
        /// Test UpdateShopItem_0
        /// </summary>
        [Test]
        public void UpdateShopItem_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //int? item = null;
            //VillagerShopsStockItem body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.UpdateShopItem_0(id, item, body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsStockItem> (response, "response is VillagerShopsStockItem");
        }
        
        /// <summary>
        /// Test UpdateShop_0
        /// </summary>
        [Test]
        public void UpdateShop_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //VillagerShopsShop body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.UpdateShop_0(id, body, details, accept, pretty);
            //Assert.IsInstanceOf<VillagerShopsShop> (response, "response is VillagerShopsShop");
        }
        
    }

}
