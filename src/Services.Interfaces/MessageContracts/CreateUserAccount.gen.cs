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
    /// Defines the Create request for the 'UserAccounts' resource.
    /// </summary>
    [RequireAuthorization]
    [RequireRoles(@"clientapplication")]
    [Route(@"/useraccounts", @"POST", 
        Summary = @"Creates a new 'UserAccount' resource", 
        Notes = @"")]
    [Api(Description = @"Manages the UserAccounts resource")]
    [ApiResponse(HttpStatusCode.OK, @"The request succeeded")]
    [ApiResponse(HttpStatusCode.BadRequest, @"The request was formed incorrectly. The request fields are either missing, or the values are invalid for this request")]
    [ApiResponse(HttpStatusCode.NotFound, @"The requested resource does not exist, or the current user may not have access to it")]
    [ApiResponse(HttpStatusCode.Conflict, @"The posted resource may already exist, and cannot be duplicated")]
    [ApiResponse(HttpStatusCode.InternalServerError, @"An unexpected error occured in the service while performing this operation")]
    [ApiResponse(HttpStatusCode.Unauthorized, @"You are not authorized to complete this request. Either you don't have the rights to access this resource for this request, or you have not provided the required Bearer token in the request to be identifed for this request")]
    public partial class CreateUserAccount : IReturn<CreateUserAccountResponse>
    {
        /// <summary>
        /// Gets or sets the forenames of the UserAccount
        /// </summary>
        [ApiMember(Description = "The Forenames of the UserAccount. ", IsRequired = true)]
        public System.String Forenames { get; set; }

        /// <summary>
        /// Gets or sets the surname of the UserAccount
        /// </summary>
        [ApiMember(Description = "The Surname of the UserAccount. ", IsRequired = true)]
        public System.String Surname { get; set; }

        /// <summary>
        /// Gets or sets the email of the UserAccount
        /// </summary>
        [ApiMember(Description = "The Email of the UserAccount. ", IsRequired = true)]
        public System.String Email { get; set; }

        /// <summary>
        /// Gets or sets the username of the UserAccount
        /// </summary>
        [ApiMember(Description = "The Username of the UserAccount. ", IsRequired = false)]
        public System.String Username { get; set; }

        /// <summary>
        /// Gets or sets the passwordhash of the UserAccount
        /// </summary>
        [ApiMember(Description = "The PasswordHash of the UserAccount. ", IsRequired = false)]
        public System.String PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the address of the UserAccount
        /// </summary>
        [ApiMember(Description = "The Address of the UserAccount. ", IsRequired = true)]
        public DataContracts.Address Address { get; set; }

        /// <summary>
        /// Gets or sets the mobilephone of the UserAccount
        /// </summary>
        [ApiMember(Description = "The MobilePhone of the UserAccount. ", IsRequired = false)]
        public System.String MobilePhone { get; set; }

    }
}
