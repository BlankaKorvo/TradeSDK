/*
 * Trade API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: current
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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing IntradayCandlesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IntradayCandlesApiTests : IDisposable
    {
        private IntradayCandlesApi instance;

        public IntradayCandlesApiTests()
        {
            instance = new IntradayCandlesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IntradayCandlesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IntradayCandlesApi
            //Assert.IsType<IntradayCandlesApi>(instance);
        }

        /// <summary>
        /// Test PublicApiV1IntradayCandlesGet
        /// </summary>
        [Fact]
        public void PublicApiV1IntradayCandlesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? securityBoard = null;
            //string? securityCode = null;
            //string? timeFrame = null;
            //DateOnly? intervalFrom = null;
            //DateOnly? intervalTo = null;
            //int? intervalCount = null;
            //var response = instance.PublicApiV1IntradayCandlesGet(securityBoard, securityCode, timeFrame, intervalFrom, intervalTo, intervalCount);
            //Assert.IsType<GetIntradayCandlesResultWebResponse>(response);
        }
    }
}