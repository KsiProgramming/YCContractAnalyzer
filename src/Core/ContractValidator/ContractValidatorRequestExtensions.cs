//-----------------------------------------------------------------------
// <copyright file="ContractValidatorRequestExtensions.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public static class ContractValidatorRequestExtensions
    {
        public static bool IsUnderAgeFrom(this ContractValidatorRequest request, DateTime fromDate)
        {
            var totalDays = fromDate.Subtract(request.UserInformation.dateOfBirth).Days;

            var age = totalDays / 365.25;
            if (age < 18)
            {
                return true;
            }

            return false;
        }
    }
}
