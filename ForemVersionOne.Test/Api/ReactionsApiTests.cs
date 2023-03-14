/*
 * Forem API V1
 *
 * Access Forem articles, users and other resources via API.         For a real-world example of Forem in action, check out [DEV](https://www.dev.to).         All endpoints can be accessed with the 'api-key' header and a accept header, but         some of them are accessible publicly without authentication.          Dates and date times, unless otherwise specified, must be in         the [RFC 3339](https://tools.ietf.org/html/rfc3339) format.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ForemVersionOne.Client;
using ForemVersionOne.Api;

namespace ForemVersionOne.Test.Api
{
    /// <summary>
    ///  Class for testing ReactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReactionsApiTests : IDisposable
    {
        private ReactionsApi instance;

        public ReactionsApiTests()
        {
            instance = new ReactionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReactionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReactionsApi
            //Assert.IsType<ReactionsApi>(instance);
        }

        /// <summary>
        /// Test ApiReactionsPost
        /// </summary>
        [Fact]
        public void ApiReactionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //int reactableId = null;
            //string reactableType = null;
            //instance.ApiReactionsPost(category, reactableId, reactableType);
        }

        /// <summary>
        /// Test ApiReactionsTogglePost
        /// </summary>
        [Fact]
        public void ApiReactionsTogglePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //int reactableId = null;
            //string reactableType = null;
            //instance.ApiReactionsTogglePost(category, reactableId, reactableType);
        }
    }
}