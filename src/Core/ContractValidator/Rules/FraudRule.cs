//-----------------------------------------------------------------------
// <copyright file="FraudRule.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules
{
    public class FraudRule
    {
        private bool isBannedPerson;

        public FraudRule(bool isBannedPerson)
        {
            this.isBannedPerson = isBannedPerson;
        }

        public RuleResponse Check(ContractValidatorRequest request)
        {
            if (this.isBannedPerson)
            {
                return new RuleResponse(this.GetType().Name, true);
            }

            return new RuleResponse(this.GetType().Name, false);
        }
    }
}
