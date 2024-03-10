//-----------------------------------------------------------------------
// <copyright file="ContractValidatorManager.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public class ContractValidatorManager
    {
        private readonly IEnumerable<IContractRuleCheck<ContractValidatorRequest>> rules;

        public ContractValidatorManager(IEnumerable<IContractRuleCheck<ContractValidatorRequest>> rules)
        {
            this.rules = rules;
        }

        public IReadOnlyCollection<RuleResponse> Validate(ContractValidatorRequest request)
        {
            return this.rules
                .Select(validator => validator.Check(request))
                .Where(ruleResponse => ruleResponse.IsInViolation)
                .ToArray();
        }
    }
}
