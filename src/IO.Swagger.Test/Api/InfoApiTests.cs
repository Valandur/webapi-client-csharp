/* 
 * WebAPI
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/...  As a quick test try reaching the route http:/localhost:8080/api/info (remember that you can only access \"localhost\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md) 
 *
 * OpenAPI spec version: <version>
 * 
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
    ///  Class for testing InfoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InfoApiTests
    {
        private InfoApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InfoApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InfoApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InfoApi
            //Assert.IsInstanceOfType(typeof(InfoApi), instance, "instance is a InfoApi");
        }

        
        /// <summary>
        /// Test GetInfo
        /// </summary>
        [Test]
        public void GetInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInfo();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetServerProperties
        /// </summary>
        [Test]
        public void GetServerPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServerProperties();
            //Assert.IsInstanceOf<ServerPropertiesList> (response, "response is ServerPropertiesList");
        }
        
        /// <summary>
        /// Test GetStats
        /// </summary>
        [Test]
        public void GetStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStats();
            //Assert.IsInstanceOf<StatsResponse> (response, "response is StatsResponse");
        }
        
    }

}
