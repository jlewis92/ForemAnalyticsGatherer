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
// uncomment below to import models
//using ForemVersionOne.Model;

namespace ForemVersionOne.Test.Api
{
    /// <summary>
    ///  Class for testing ArticlesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ArticlesApiTests : IDisposable
    {
        private ArticlesApi instance;

        public ArticlesApiTests()
        {
            instance = new ArticlesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ArticlesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ArticlesApi
            //Assert.IsType<ArticlesApi>(instance);
        }

        /// <summary>
        /// Test GetArticles
        /// </summary>
        [Fact]
        public void GetArticlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string? tag = null;
            //string? tags = null;
            //string? tagsExclude = null;
            //string? username = null;
            //string? state = null;
            //int? top = null;
            //int? collectionId = null;
            //var response = instance.GetArticles(page, perPage, tag, tags, tagsExclude, username, state, top, collectionId);
            //Assert.IsType<List<ArticleIndex>>(response);
        }

        /// <summary>
        /// Test GetUserAllArticles
        /// </summary>
        [Fact]
        public void GetUserAllArticlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetUserAllArticles(page, perPage);
            //Assert.IsType<List<ArticleIndex>>(response);
        }

        /// <summary>
        /// Test GetUserArticles
        /// </summary>
        [Fact]
        public void GetUserArticlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetUserArticles(page, perPage);
            //Assert.IsType<List<ArticleIndex>>(response);
        }

        /// <summary>
        /// Test GetUserPublishedArticles
        /// </summary>
        [Fact]
        public void GetUserPublishedArticlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetUserPublishedArticles(page, perPage);
            //Assert.IsType<List<ArticleIndex>>(response);
        }

        /// <summary>
        /// Test GetUserUnpublishedArticles
        /// </summary>
        [Fact]
        public void GetUserUnpublishedArticlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetUserUnpublishedArticles(page, perPage);
            //Assert.IsType<List<ArticleIndex>>(response);
        }

        /// <summary>
        /// Test UnpublishArticle
        /// </summary>
        [Fact]
        public void UnpublishArticleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string? note = null;
            //instance.UnpublishArticle(id, note);
        }
    }
}
