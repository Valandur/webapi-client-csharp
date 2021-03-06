/* 
 * Web-API
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/v5...  As a quick test try reaching the route http:/localhost:8080/api/v5/info (remember that you can only access \\\"localhost\\\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # List endpoints Lots of objects offer an endpoint to list all objects (e.g. `GET: /world` to get all worlds). These endpoints return only the properties marked 'required' by default, because the list might be quite large. If you want to return ALL data for a list endpoint add the query parameter `details`, (e.g. `GET: /world?details`).  > Remember that in this case the data returned by the endpoint might be quite large.  # Debugging endpoints Apart from the `?details` flag you can also pass some other flags for debugging purposes. Remember that you must include the first query parameter with `?`, and further ones with `&`:  `details`: Includes details for list endpoints  `accept=[json/xml]`: Manually set the accept content type. This is good for browser testing, **BUT DON'T USE THIS IN PRODUCTION, YOU CAN SUPPLY THE `Accepts` HEADER FOR THAT**  `pretty`: Pretty prints the data, also good for debugging in the browser.  An example request might look like this: `http://localhost:8080/api/v5/world?details&accpet=json&pretty&key=MY-API-KEY`  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md)
 *
 * OpenAPI spec version: @version@
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
    ///  Class for testing NucleusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NucleusApiTests
    {
        private NucleusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NucleusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NucleusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NucleusApi
            //Assert.IsInstanceOfType(typeof(NucleusApi), instance, "instance is a NucleusApi");
        }

        
        /// <summary>
        /// Test CreateJail
        /// </summary>
        [Test]
        public void CreateJailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NucleusNamedLocation body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.CreateJail(body, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusNamedLocation> (response, "response is NucleusNamedLocation");
        }
        
        /// <summary>
        /// Test CreateKit
        /// </summary>
        [Test]
        public void CreateKitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NucleusKit body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.CreateKit(body, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusKit> (response, "response is NucleusKit");
        }
        
        /// <summary>
        /// Test DeleteJail
        /// </summary>
        [Test]
        public void DeleteJailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteJail(name, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusNamedLocation> (response, "response is NucleusNamedLocation");
        }
        
        /// <summary>
        /// Test DeleteKit
        /// </summary>
        [Test]
        public void DeleteKitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteKit(name, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusKit> (response, "response is NucleusKit");
        }
        
        /// <summary>
        /// Test GetJail
        /// </summary>
        [Test]
        public void GetJailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetJail(name, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusNamedLocation> (response, "response is NucleusNamedLocation");
        }
        
        /// <summary>
        /// Test GetKit
        /// </summary>
        [Test]
        public void GetKitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetKit(name, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusKit> (response, "response is NucleusKit");
        }
        
        /// <summary>
        /// Test ListHomes
        /// </summary>
        [Test]
        public void ListHomesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string player = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListHomes(player, details, accept, pretty);
            //Assert.IsInstanceOf<List<NucleusNamedLocation>> (response, "response is List<NucleusNamedLocation>");
        }
        
        /// <summary>
        /// Test ListJails
        /// </summary>
        [Test]
        public void ListJailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListJails(details, accept, pretty);
            //Assert.IsInstanceOf<List<NucleusNamedLocation>> (response, "response is List<NucleusNamedLocation>");
        }
        
        /// <summary>
        /// Test ListKits
        /// </summary>
        [Test]
        public void ListKitsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListKits(details, accept, pretty);
            //Assert.IsInstanceOf<List<NucleusKit>> (response, "response is List<NucleusKit>");
        }
        
        /// <summary>
        /// Test ListMail
        /// </summary>
        [Test]
        public void ListMailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string player = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListMail(player, details, accept, pretty);
            //Assert.IsInstanceOf<List<NucleusMailMessage>> (response, "response is List<NucleusMailMessage>");
        }
        
        /// <summary>
        /// Test ListMail_0
        /// </summary>
        [Test]
        public void ListMail_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ListMail_0(details, accept, pretty);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test ModifyJail
        /// </summary>
        [Test]
        public void ModifyJailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ModifyJail(details, accept, pretty);
            //Assert.IsInstanceOf<NucleusNamedLocation> (response, "response is NucleusNamedLocation");
        }
        
        /// <summary>
        /// Test ModifyKit
        /// </summary>
        [Test]
        public void ModifyKitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //NucleusKit body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ModifyKit(name, body, details, accept, pretty);
            //Assert.IsInstanceOf<NucleusKit> (response, "response is NucleusKit");
        }
        
    }

}
