/* 
 * WebAPI
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/...  As a quick test try reaching the route http:/localhost:8080/api/info (remember that you can only access \"localhost\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md) 
 *
 * OpenAPI spec version: <version>
 * 
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

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CommandHistoryResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CommandHistoryResponseTests
    {
        // TODO uncomment below to declare an instance variable for CommandHistoryResponse
        //private CommandHistoryResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CommandHistoryResponse
            //instance = new CommandHistoryResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommandHistoryResponse
        /// </summary>
        [Test]
        public void CommandHistoryResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CommandHistoryResponse
            //Assert.IsInstanceOfType<CommandHistoryResponse> (instance, "variable 'instance' is a CommandHistoryResponse");
        }

        /// <summary>
        /// Test the property 'Ok'
        /// </summary>
        [Test]
        public void OkTest()
        {
            // TODO unit test for the property 'Ok'
        }
        /// <summary>
        /// Test the property 'Messages'
        /// </summary>
        [Test]
        public void MessagesTest()
        {
            // TODO unit test for the property 'Messages'
        }

    }

}
