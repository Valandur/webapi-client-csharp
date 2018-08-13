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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserRequest body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.CreateUser(body, details, accept, pretty);
            //Assert.IsInstanceOf<UserPermissionStruct> (response, "response is UserPermissionStruct");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.DeleteUser(name, details, accept, pretty);
            //Assert.IsInstanceOf<UserPermissionStruct> (response, "response is UserPermissionStruct");
        }
        
        /// <summary>
        /// Test GetMe
        /// </summary>
        [Test]
        public void GetMeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetMe(details, accept, pretty);
            //Assert.IsInstanceOf<PermissionStruct> (response, "response is PermissionStruct");
        }
        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.GetUsers(details, accept, pretty);
            //Assert.IsInstanceOf<List<UserPermissionStruct>> (response, "response is List<UserPermissionStruct>");
        }
        
        /// <summary>
        /// Test Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthenticationRequest body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.Login(body, details, accept, pretty);
            //Assert.IsInstanceOf<PermissionStruct> (response, "response is PermissionStruct");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.Logout(details, accept, pretty);
            //Assert.IsInstanceOf<PermissionStruct> (response, "response is PermissionStruct");
        }
        
        /// <summary>
        /// Test LogoutRedirect
        /// </summary>
        [Test]
        public void LogoutRedirectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string redirect = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //instance.LogoutRedirect(redirect, details, accept, pretty);
            
        }
        
        /// <summary>
        /// Test ModifyUser
        /// </summary>
        [Test]
        public void ModifyUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //ModifyUserRequest body = null;
            //bool? details = null;
            //string accept = null;
            //bool? pretty = null;
            //var response = instance.ModifyUser(name, body, details, accept, pretty);
            //Assert.IsInstanceOf<UserPermissionStruct> (response, "response is UserPermissionStruct");
        }
        
    }

}
