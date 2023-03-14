/*
 * DEV API (beta)
 *
 *  Access Forem articles, users and other resources via API.  For a real-world example of Forem in action, check out [DEV](https://www.dev.to).  All endpoints that don't require authentication are CORS enabled.  All requests must send a user-agent header.  Dates and date times, unless otherwise specified, must be in the [RFC 3339](https://tools.ietf.org/html/rfc3339) format. 
 *
 * The version of the OpenAPI document: 0.9.7
 * Contact: yo@dev.to
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

using ForemVersionZero.Client;
using ForemVersionZero.Api;
// uncomment below to import models
//using ForemVersionZero.Model;

namespace ForemVersionZero.Test.Api
{
    /// <summary>
    ///  Class for testing ProfileImagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProfileImagesApiTests : IDisposable
    {
        private ProfileImagesApi instance;

        public ProfileImagesApiTests()
        {
            instance = new ProfileImagesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProfileImagesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProfileImagesApi
            //Assert.IsType<ProfileImagesApi>(instance);
        }

        /// <summary>
        /// Test GetProfileImage
        /// </summary>
        [Fact]
        public void GetProfileImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetProfileImage(username);
            //Assert.IsType<ProfileImage>(response);
        }
    }
}
