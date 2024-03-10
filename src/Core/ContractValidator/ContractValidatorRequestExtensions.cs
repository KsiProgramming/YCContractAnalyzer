//-----------------------------------------------------------------------
// <copyright file="ContractValidatorRequestExtensions.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public static class ContractValidatorRequestExtensions
    {
        public static bool IsMinorFrom(this ContractValidatorRequest request, DateOnly dateOnly)
        {
            if (dateOnly.Year <= request.UserBirthDate.Year)
            {
                return false;
            }

            var datesDiff = dateOnly.AddYears(-request.UserBirthDate.Year).AddMonths(-request.UserBirthDate.Month + 1);
            if (datesDiff.Year < 18)
            {
                return true;
            }

            return false;
        }
    }
}
