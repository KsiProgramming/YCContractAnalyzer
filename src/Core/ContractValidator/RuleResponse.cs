//-----------------------------------------------------------------------
// <copyright file="RuleResponse.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public class RuleResponse
    {
        public RuleResponse(string name, bool isInViolation)
        {
            this.Name = name;
            this.IsInViolation = isInViolation;
        }

        public string Name { get; }

        public bool IsInViolation { get; }
    }
}
