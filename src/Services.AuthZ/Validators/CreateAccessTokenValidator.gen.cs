﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Services.MessageContracts;
using ServiceStack.FluentValidation;

namespace Services.AuthZ.Validators
{
    /// <summary>
    /// A validator that validates the <see cref="CreateAccessToken"/> contract.
    /// </summary>
    internal partial class CreateAccessTokenValidator : AbstractValidator<CreateAccessToken>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CreateAccessTokenValidator"/> class.
        /// </summary>
        public CreateAccessTokenValidator()
        {
            // Rules defined by request contract
            RuleFor(dto => dto.GrantType).NotNull();

            // Additional custom rules
            this.AddRules();
        }

        /// <summary>
        /// Adds custom rules for the validator
        /// </summary>
        partial void AddRules();
    }
}
