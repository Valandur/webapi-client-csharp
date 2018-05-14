/* 
 * Web-API
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/v5...  As a quick test try reaching the route http:/localhost:8080/api/v5/info (remember that you can only access \\\"localhost\\\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # List endpoints Lots of objects offer an endpoint to list all objects (e.g. `GET: /world` to get all worlds). These endpoints return only the properties marked 'required' by default, because the list might be quite large. If you want to return ALL data for a list endpoint add the query parameter `details`, (e.g. `GET: /world?details`).  > Remember that in this case the data returned by the endpoint might be quite large.  # Debugging endpoints Apart from the `?details` flag you can also pass some other flags for debugging purposes. Remember that you must include the first query parameter with `?`, and further ones with `&`:  `details`: Includes details for list endpoints  `accept=[json/xml]`: Manually set the accept content type. This is good for browser testing, **BUT DON'T USE THIS IN PRODUCTION, YOU CAN SUPPLY THE `Accepts` HEADER FOR THAT**  `pretty`: Pretty prints the data, also good for debugging in the browser.  An example request might look like this: `http://localhost:8080/api/v5/world?details&accpet=json&pretty&key=MY-API-KEY`  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md)
 *
 * OpenAPI spec version: @version@
 * Contact: inithilian@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing HideData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HideDataTests
    {
        // TODO uncomment below to declare an instance variable for HideData
        //private HideData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HideData
            //instance = new HideData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HideData
        /// </summary>
        [Test]
        public void HideDataInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HideData
            //Assert.IsInstanceOfType<HideData> (instance, "variable 'instance' is a HideData");
        }


        /// <summary>
        /// Test the property 'HideAttributes'
        /// </summary>
        [Test]
        public void HideAttributesTest()
        {
            // TODO unit test for the property 'HideAttributes'
        }
        /// <summary>
        /// Test the property 'HideCanDestroy'
        /// </summary>
        [Test]
        public void HideCanDestroyTest()
        {
            // TODO unit test for the property 'HideCanDestroy'
        }
        /// <summary>
        /// Test the property 'HideCanPlace'
        /// </summary>
        [Test]
        public void HideCanPlaceTest()
        {
            // TODO unit test for the property 'HideCanPlace'
        }
        /// <summary>
        /// Test the property 'HideEnchantments'
        /// </summary>
        [Test]
        public void HideEnchantmentsTest()
        {
            // TODO unit test for the property 'HideEnchantments'
        }
        /// <summary>
        /// Test the property 'HideMiscellaneous'
        /// </summary>
        [Test]
        public void HideMiscellaneousTest()
        {
            // TODO unit test for the property 'HideMiscellaneous'
        }
        /// <summary>
        /// Test the property 'HideUnbreakable'
        /// </summary>
        [Test]
        public void HideUnbreakableTest()
        {
            // TODO unit test for the property 'HideUnbreakable'
        }

    }

}