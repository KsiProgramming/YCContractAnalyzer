//-----------------------------------------------------------------------
// <copyright file="UnderAgeRule.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules
{
    public class UnderAgeRule
    {
        private DateOnly currentDate;

        public UnderAgeRule(DateOnly currentDate)
        {
            this.currentDate = currentDate;
        }

        public RuleResponse Check(ContractValidatorRequest request)
        {
            if (request.IsUnderAgeFrom(this.currentDate))
            {
                return new RuleResponse(this.GetType().Name, true);
            }

            return new RuleResponse(this.GetType().Name, default);
        }
    }
}
