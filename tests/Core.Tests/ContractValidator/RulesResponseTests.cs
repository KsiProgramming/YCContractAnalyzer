//-----------------------------------------------------------------------
// <copyright file="RulesResponseTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Tests
{
    using FluentAssertions;

    public class RulesResponseTests
    {
        [Fact]
        public void ShouldBeInitializedWithCorrectProperties()
        {
            var rule = new RuleResponse(name: "Rule Number 1", isInViolation: true);

            rule.Name.Should().Be("Rule Number 1");
            rule.IsInViolation.Should().BeTrue();
        }
    }
}
