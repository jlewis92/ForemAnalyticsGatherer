/*
 * DEV API (beta)
 *
 *  Access Forem articles, users and other resources via API.  For a real-world example of Forem in action, check out [DEV](https://www.dev.to).  All endpoints that don't require authentication are CORS enabled.  All requests must send a user-agent header.  Dates and date times, unless otherwise specified, must be in the [RFC 3339](https://tools.ietf.org/html/rfc3339) format. 
 *
 * The version of the OpenAPI document: 0.9.7
 * Contact: yo@dev.to
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ForemVersionZero.Api;
using ForemVersionZero.Model;
using ForemVersionZero.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ForemVersionZero.Test.Model
{
    /// <summary>
    ///  Class for testing Tag
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TagTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Tag
        //private Tag instance;

        public TagTests()
        {
            // TODO uncomment below to create an instance of Tag
            //instance = new Tag();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Tag
        /// </summary>
        [Fact]
        public void TagInstanceTest()
        {
            // TODO uncomment below to test "IsType" Tag
            //Assert.IsType<Tag>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'BgColorHex'
        /// </summary>
        [Fact]
        public void BgColorHexTest()
        {
            // TODO unit test for the property 'BgColorHex'
        }
        /// <summary>
        /// Test the property 'TextColorHex'
        /// </summary>
        [Fact]
        public void TextColorHexTest()
        {
            // TODO unit test for the property 'TextColorHex'
        }

    }

}
