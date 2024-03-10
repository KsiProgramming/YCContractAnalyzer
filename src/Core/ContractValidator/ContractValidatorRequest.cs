//-----------------------------------------------------------------------
// <copyright file="ContractValidatorRequest.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public class ContractValidatorRequest
    {
        public ContractValidatorRequest(DateOnly userBirthDate)
        {
            this.UserBirthDate = userBirthDate;
        }

        public DateOnly UserBirthDate { get; }
    }
}
