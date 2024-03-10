//-----------------------------------------------------------------------
// <copyright file="FraudRule.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules
{
    public class FraudRule
    {
        private readonly IFraudDetectionProvider fraudDetectionProvider;

        public FraudRule(IFraudDetectionProvider fraudDetectionprovider)
        {
            this.fraudDetectionProvider = fraudDetectionprovider;
        }

        public RuleResponse Check(ContractValidatorRequest request)
        {
            if (this.fraudDetectionProvider.IsFraudDetected(request.UserInformation))
            {
                return new RuleResponse(this.GetType().Name, true);
            }

            return new RuleResponse(this.GetType().Name, false);
        }
    }
}
