//-----------------------------------------------------------------------
// <copyright file="IContractRuleCheck.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public interface IContractRuleCheck<in T>
        where T : ContractValidatorRequest
    {
        RuleResponse Check(T request);
    }
}