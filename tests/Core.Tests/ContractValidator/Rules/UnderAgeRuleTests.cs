//-----------------------------------------------------------------------
// <copyright file="UnderAgeRuleTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules.Tests
{
    using FluentAssertions;

    public class UnderAgeRuleTests
    {
        [Fact]
        public void CheckShouldBeInViolationWhenIsUnderAgeIsTrue()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2007, 01, 01));

            var rule = new UnderAgeRule(currentDate: new DateOnly(2024, 03, 10));

            var result = rule.Check(request);

            result.Name.Should().Be("UnderAgeRule");
            result.IsInViolation.Should().Be(true);
        }

        [Fact]
        public void CheckShouldNotBeInViolationWhenIsUnderAgeIsFalse()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2006, 01, 01));

            var rule = new UnderAgeRule(currentDate: new DateOnly(2024, 03, 10));

            var result = rule.Check(request);

            result.Name.Should().Be("UnderAgeRule");
            result.IsInViolation.Should().Be(false);
        }
    }
}
