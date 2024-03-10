//-----------------------------------------------------------------------
// <copyright file="FraudRuleTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Rules.Tests
{
    using FluentAssertions;
    using Moq;

    public class FraudRuleTests
    {
        [Fact]
        public void CheckShouldReturnRuleResponseInViolationWhenIsCustomerDeclaredAsFraud_True()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2007, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var fraudDetectionProvider = new Mock<IFraudDetectionProvider>(MockBehavior.Strict);
            fraudDetectionProvider
                .Setup(f => f.IsFraudDetected(userInformation))
                .Returns(true);

            var rule = new FraudRule(fraudDetectionprovider: fraudDetectionProvider.Object);

            var result = rule.Check(request);

            result.Name.Should().Be("FraudRule");
            result.IsInViolation.Should().BeTrue();
        }

        [Fact]
        public void CheckShouldReturnRuleResponseNotInViolationWhenIsCustomerDeclaredAsFraud_False()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2007, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var fraudDetectionProvider = new Mock<IFraudDetectionProvider>(MockBehavior.Strict);
            fraudDetectionProvider
                .Setup(f => f.IsFraudDetected(userInformation))
                .Returns(false);

            var rule = new FraudRule(fraudDetectionprovider: fraudDetectionProvider.Object);

            var result = rule.Check(request);

            result.Name.Should().Be("FraudRule");
            result.IsInViolation.Should().BeFalse();

            fraudDetectionProvider.VerifyAll();
        }
    }
}
