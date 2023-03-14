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
    ///  Class for testing ArticleCreateArticle
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ArticleCreateArticleTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ArticleCreateArticle
        //private ArticleCreateArticle instance;

        public ArticleCreateArticleTests()
        {
            // TODO uncomment below to create an instance of ArticleCreateArticle
            //instance = new ArticleCreateArticle();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ArticleCreateArticle
        /// </summary>
        [Fact]
        public void ArticleCreateArticleInstanceTest()
        {
            // TODO uncomment below to test "IsType" ArticleCreateArticle
            //Assert.IsType<ArticleCreateArticle>(instance);
        }


        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'BodyMarkdown'
        /// </summary>
        [Fact]
        public void BodyMarkdownTest()
        {
            // TODO unit test for the property 'BodyMarkdown'
        }
        /// <summary>
        /// Test the property 'Published'
        /// </summary>
        [Fact]
        public void PublishedTest()
        {
            // TODO unit test for the property 'Published'
        }
        /// <summary>
        /// Test the property 'Series'
        /// </summary>
        [Fact]
        public void SeriesTest()
        {
            // TODO unit test for the property 'Series'
        }
        /// <summary>
        /// Test the property 'MainImage'
        /// </summary>
        [Fact]
        public void MainImageTest()
        {
            // TODO unit test for the property 'MainImage'
        }
        /// <summary>
        /// Test the property 'CanonicalUrl'
        /// </summary>
        [Fact]
        public void CanonicalUrlTest()
        {
            // TODO unit test for the property 'CanonicalUrl'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'OrganizationId'
        /// </summary>
        [Fact]
        public void OrganizationIdTest()
        {
            // TODO unit test for the property 'OrganizationId'
        }

    }

}
