//-----------------------------------------------------------------------
// <copyright file="UnderAgeRule.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules
{
    public class UnderAgeRule
    {
        private readonly IsystemClock systemClock;

        public UnderAgeRule(IsystemClock systemClock)
        {
            this.systemClock = systemClock;
        }

        public RuleResponse Check(ContractValidatorRequest request)
        {
            if (request.IsUnderAgeFrom(this.systemClock.UtcNow.DateTime))
            {
                return new RuleResponse(this.GetType().Name, true);
            }

            return new RuleResponse(this.GetType().Name, default);
        }
    }
}
