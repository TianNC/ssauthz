﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net;
using Common.Reflection;
using Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.MessageContracts;
using ServiceStack;
using Testing.Common;

namespace Services.IntTests
{
    /// <summary>
    /// Tests the <see cref="ClientApplications"/> service interface class.
    /// </summary>
    /// <remarks>
    /// These tests are verifying basic service connectivity, things like:
    /// 1. Request validation
    /// 2. Basic request and responses.
    /// 3. Handling of exceptions from service.
    /// 4. Returning correct HTTP response codes.
    /// </remarks>
    public partial class ClientApplicationsSpec
    {
        private static readonly IAssertion Assert = new Assertion();
        private const string RestRoutedNotFoundPartialMessage = "None of the given rest routes matches";

        [TestClass]
        public partial class GivenTheClientApplicationsService : GivenTheClientApplicationsServiceBase { }

        [TestClass]
        public abstract class GivenTheClientApplicationsServiceBase : IntegrationTest
        {
            [TestInitialize]
            public virtual void Initialize()
            {
                base.InitializeContext();
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenGetGetClientApplicationWithNullRequest_ThenThrowsNullReference()
            {
                Assert.Throws<NullReferenceException>(() =>
                    Client.Get((GetClientApplication)null));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenGetGetClientApplicationWithEmptyRequest_ThenThrowsRestRouteNotFound()
            {
                Assert.Throws<InvalidOperationException>(RestRoutedNotFoundPartialMessage, () =>
                    Client.Get(new GetClientApplication()));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenGetGetClientApplicationWithNullId_ThenThrowsRestRouteNotFound()
            {
                Assert.Throws<InvalidOperationException>(RestRoutedNotFoundPartialMessage, () =>
                    Client.Get(this.MakeGetClientApplication(new Dictionary<string, string>() { { "Id", null } })));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenGetGetClientApplicationWithEmptyId_ThenRedirectsToReturnAllResources()
            {
                var httpResponse = Client.Get<HttpWebResponse>(this.MakeGetClientApplication(new Dictionary<string, string>() { { "Id", string.Empty } }));

                Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenGetGetClientApplicationWithUnknownId_ThenThrowsResourceNotFound()
            {
                Assert.Throws<ResourceNotFoundException>(HttpErrorCode.FromHttpStatusCode(HttpStatusCode.NotFound), () =>
                    Client.Get(this.MakeGetClientApplication(new Dictionary<string, string>() { { "Id", this.MakeUnknownId() } })));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenGetGetClientApplication_ThenReturnsResource()
            {
                var created = this.CreateNewClientApplication();
                var fetched = Client.Get(this.MakeGetClientApplication(new Dictionary<string, string> { { "Id", created } }));

                Assert.Equal(created, fetched.ClientApplication.Id);

                var httpResponse = Client.Get<HttpWebResponse>(this.MakeGetClientApplication(new Dictionary<string, string> { { "Id", created } }));

                Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenPostCreateClientApplicationWithNullRequest_ThenThrowsNullReference()
            {
                Assert.Throws<NullReferenceException>(() =>
                    Client.Post((CreateClientApplication)null));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenPostCreateClientApplicationWithEmptyRequest_ThenThrowsBadRequest()
            {
                Assert.Throws<InvalidOperationException>(HttpErrorCode.FromHttpStatusCode(HttpStatusCode.BadRequest), () =>
                    Client.Post(new CreateClientApplication()));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenPostCreateClientApplication_ThenCreatesResource()
            {
                var result = Client.Post<HttpWebResponse>(this.MakeCreateClientApplication());

                Assert.Equal(HttpStatusCode.Created, result.StatusCode);
                Assert.True(new Uri(result.GetResponseHeader(HttpHeaders.Location)).LocalPath.StartsWith(result.ResponseUri.LocalPath.WithTrailingSlash()));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenDeleteDeleteClientApplicationWithNullRequest_ThenThrowsNullReference()
            {
                Assert.Throws<NullReferenceException>(() =>
                    Client.Delete((DeleteClientApplication)null));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenDeleteDeleteClientApplicationWithEmptyRequest_ThenThrowsRestRouteNotFound()
            {
                Assert.Throws<InvalidOperationException>(RestRoutedNotFoundPartialMessage, () =>
                    Client.Delete(new DeleteClientApplication()));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenDeleteDeleteClientApplicationWithNullId_ThenThrowsRestRouteNotFound()
            {
                Assert.Throws<InvalidOperationException>(RestRoutedNotFoundPartialMessage, () =>
                    Client.Delete(this.MakeDeleteClientApplication(new Dictionary<string, string>() { { "Id", null } })));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenDeleteDeleteClientApplicationWithEmptyId_ThenRedirectsToReturnAllResources()
            {
                var httpResponse = Client.Delete<HttpWebResponse>(this.MakeDeleteClientApplication(new Dictionary<string, string>() { { "Id", string.Empty } }));

                Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenDeleteDeleteClientApplicationWithUnknownId_ThenThrowsResourceNotFound()
            {
                Assert.Throws<ResourceNotFoundException>(HttpErrorCode.FromHttpStatusCode(HttpStatusCode.NotFound), () =>
                    Client.Delete(this.MakeDeleteClientApplication(new Dictionary<string, string>() { { "Id", this.MakeUnknownId() } })));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenDeleteDeleteClientApplication_ThenDeletesResource()
            {
                var created = this.CreateNewClientApplication();

                var result = Client.Delete<HttpWebResponse>(this.MakeDeleteClientApplication(new Dictionary<string, string> { { "Id", created } }));

                Assert.Equal(HttpStatusCode.Accepted, result.StatusCode);
            }


            protected virtual string MakeUnknownId()
            {
                return Guid.NewGuid().ToString();
            }

            protected virtual string CreateNewClientApplication()
            {
                return Client.Post(MakeCreateClientApplication()).ClientApplication.Id;
            }

            protected virtual GetClientApplication MakeGetClientApplication(Dictionary<string, string> fields)
            {
                return new GetClientApplication
                {
                    Id = fields.ContainsKey(Reflector<GetClientApplication>.GetPropertyName(x => x.Id)) ? fields[Reflector<GetClientApplication>.GetPropertyName(x => x.Id)] : null,
                };
            }

            protected virtual CreateClientApplication MakeCreateClientApplication()
            {
                return new CreateClientApplication();
            }

            protected virtual DeleteClientApplication MakeDeleteClientApplication(Dictionary<string, string> fields)
            {
                return new DeleteClientApplication
                {
                    Id = fields.ContainsKey(Reflector<DeleteClientApplication>.GetPropertyName(x => x.Id)) ? fields[Reflector<DeleteClientApplication>.GetPropertyName(x => x.Id)] : null,
                };
            }

        }
    }
}