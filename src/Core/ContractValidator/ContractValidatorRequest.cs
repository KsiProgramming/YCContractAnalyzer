//-----------------------------------------------------------------------
// <copyright file="ContractValidatorRequest.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public class ContractValidatorRequest
    {
        public ContractValidatorRequest(UserInformation userInformation)
        {
            this.UserInformation = userInformation;
        }

        public UserInformation UserInformation { get; }
    }

    public record UserInformation(string firstName, string lastName, DateTime dateOfBirth);
}
