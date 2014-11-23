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
    /// A validator that validates the <see cref="ListUserAccounts"/> contract.
    /// </summary>
    internal partial class ListUserAccountsValidator : AbstractValidator<ListUserAccounts>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ListUserAccountsValidator"/> class.
        /// </summary>
        public ListUserAccountsValidator()
        {
            // Rules defined by request contract

            // Additional custom rules
            this.AddRules();
        }

        /// <summary>
        /// Adds custom rules for the validator
        /// </summary>
        partial void AddRules();
    }
}
