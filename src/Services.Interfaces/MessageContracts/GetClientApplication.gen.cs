﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Net;
using Common.Security;
using ServiceStack;

namespace Services.MessageContracts
{
    /// <summary>
    /// Defines the Get request for the 'ClientApplications' resource.
    /// </summary>
    [RequireAuthorization]
    [RequireRoles(@"clientapplication")]
    [Route(@"/clientapplications/{Id}", @"GET", 
        Summary = @"Retrieves the 'ClientApplication' resource", 
        Notes = @"")]
    [Api(Description = @"Manages the ClientApplications resource")]
    [ApiResponse(HttpStatusCode.OK, @"The request succeeded")]
    [ApiResponse(HttpStatusCode.BadRequest, @"The request was formed incorrectly. The request fields are either missing, or the values are invalid for this request")]
    [ApiResponse(HttpStatusCode.NotFound, @"The requested resource does not exist, or the current user may not have access to it")]
    [ApiResponse(HttpStatusCode.Conflict, @"The posted resource may already exist, and cannot be duplicated")]
    [ApiResponse(HttpStatusCode.InternalServerError, @"An unexpected error occured in the service while performing this operation")]
    [ApiResponse(HttpStatusCode.Unauthorized, @"You are not authorized to complete this request. Either you don't have the rights to access this resource for this request, or you have not provided the required Bearer token in the request to be identifed for this request")]
    public partial class GetClientApplication : IReturn<GetClientApplicationResponse>
    {
        /// <summary>
        /// Gets or sets the id of the ClientApplication
        /// </summary>
        [ApiMember(Description = "The Id of the ClientApplication. ", IsRequired = true)]
        public System.String Id { get; set; }

    }
}
