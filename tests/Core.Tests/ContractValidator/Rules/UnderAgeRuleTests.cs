//-----------------------------------------------------------------------
// <copyright file="UnderAgeRuleTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules.Tests
{
    using FluentAssertions;
    using Moq;

    public class UnderAgeRuleTests
    {
        [Fact]
        public void CheckShouldBeInViolationWhenIsUnderAgeIsTrue()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2007, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var systemClock = new Mock<IsystemClock>(MockBehavior.Strict);
            systemClock.Setup(s => s.UtcNow)
                .Returns(new DateTime(2024, 03, 10, 0, 0, 0, DateTimeKind.Utc));

            var rule = new UnderAgeRule(systemClock: systemClock.Object);

            var result = rule.Check(request);

            result.Name.Should().Be("UnderAgeRule");
            result.IsInViolation.Should().Be(true);

            systemClock.VerifyAll();
        }

        [Fact]
        public void CheckShouldNotBeInViolationWhenIsUnderAgeIsFalse()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2006, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var systemClock = new Mock<IsystemClock>(MockBehavior.Strict);
            systemClock.Setup(s => s.UtcNow)
                .Returns(new DateTime(2024, 03, 10, 0, 0, 0, DateTimeKind.Utc));

            var rule = new UnderAgeRule(systemClock: systemClock.Object);

            var result = rule.Check(request);

            result.Name.Should().Be("UnderAgeRule");
            result.IsInViolation.Should().Be(false);

            systemClock.VerifyAll();
        }
    }
}
