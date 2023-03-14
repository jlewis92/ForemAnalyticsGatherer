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
    ///  Class for testing ArticleShow
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ArticleShowTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ArticleShow
        //private ArticleShow instance;

        public ArticleShowTests()
        {
            // TODO uncomment below to create an instance of ArticleShow
            //instance = new ArticleShow();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ArticleShow
        /// </summary>
        [Fact]
        public void ArticleShowInstanceTest()
        {
            // TODO uncomment below to test "IsType" ArticleShow
            //Assert.IsType<ArticleShow>(instance);
        }


        /// <summary>
        /// Test the property 'TypeOf'
        /// </summary>
        [Fact]
        public void TypeOfTest()
        {
            // TODO unit test for the property 'TypeOf'
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
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
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
        /// Test the property 'CoverImage'
        /// </summary>
        [Fact]
        public void CoverImageTest()
        {
            // TODO unit test for the property 'CoverImage'
        }
        /// <summary>
        /// Test the property 'ReadablePublishDate'
        /// </summary>
        [Fact]
        public void ReadablePublishDateTest()
        {
            // TODO unit test for the property 'ReadablePublishDate'
        }
        /// <summary>
        /// Test the property 'SocialImage'
        /// </summary>
        [Fact]
        public void SocialImageTest()
        {
            // TODO unit test for the property 'SocialImage'
        }
        /// <summary>
        /// Test the property 'TagList'
        /// </summary>
        [Fact]
        public void TagListTest()
        {
            // TODO unit test for the property 'TagList'
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
        /// Test the property 'Slug'
        /// </summary>
        [Fact]
        public void SlugTest()
        {
            // TODO unit test for the property 'Slug'
        }
        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
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
        /// Test the property 'CommentsCount'
        /// </summary>
        [Fact]
        public void CommentsCountTest()
        {
            // TODO unit test for the property 'CommentsCount'
        }
        /// <summary>
        /// Test the property 'PositiveReactionsCount'
        /// </summary>
        [Fact]
        public void PositiveReactionsCountTest()
        {
            // TODO unit test for the property 'PositiveReactionsCount'
        }
        /// <summary>
        /// Test the property 'PublicReactionsCount'
        /// </summary>
        [Fact]
        public void PublicReactionsCountTest()
        {
            // TODO unit test for the property 'PublicReactionsCount'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'EditedAt'
        /// </summary>
        [Fact]
        public void EditedAtTest()
        {
            // TODO unit test for the property 'EditedAt'
        }
        /// <summary>
        /// Test the property 'CrosspostedAt'
        /// </summary>
        [Fact]
        public void CrosspostedAtTest()
        {
            // TODO unit test for the property 'CrosspostedAt'
        }
        /// <summary>
        /// Test the property 'PublishedAt'
        /// </summary>
        [Fact]
        public void PublishedAtTest()
        {
            // TODO unit test for the property 'PublishedAt'
        }
        /// <summary>
        /// Test the property 'LastCommentAt'
        /// </summary>
        [Fact]
        public void LastCommentAtTest()
        {
            // TODO unit test for the property 'LastCommentAt'
        }
        /// <summary>
        /// Test the property 'PublishedTimestamp'
        /// </summary>
        [Fact]
        public void PublishedTimestampTest()
        {
            // TODO unit test for the property 'PublishedTimestamp'
        }
        /// <summary>
        /// Test the property 'BodyHtml'
        /// </summary>
        [Fact]
        public void BodyHtmlTest()
        {
            // TODO unit test for the property 'BodyHtml'
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
        /// Test the property 'User'
        /// </summary>
        [Fact]
        public void UserTest()
        {
            // TODO unit test for the property 'User'
        }
        /// <summary>
        /// Test the property 'ReadingTimeMinutes'
        /// </summary>
        [Fact]
        public void ReadingTimeMinutesTest()
        {
            // TODO unit test for the property 'ReadingTimeMinutes'
        }
        /// <summary>
        /// Test the property 'Organization'
        /// </summary>
        [Fact]
        public void OrganizationTest()
        {
            // TODO unit test for the property 'Organization'
        }
        /// <summary>
        /// Test the property 'FlareTag'
        /// </summary>
        [Fact]
        public void FlareTagTest()
        {
            // TODO unit test for the property 'FlareTag'
        }

    }

}