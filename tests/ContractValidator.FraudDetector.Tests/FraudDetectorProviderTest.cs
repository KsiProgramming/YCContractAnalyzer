//-----------------------------------------------------------------------
// <copyright file="FraudDetectorProviderTest.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.FraudDetector.Tests
{
    using FluentAssertions;

    public class FraudDetectorProviderTest
    {
        [Fact]
        public void IsFraudDetectedShouldReturnTrueWhenDiffOfMillisIsaPaiNumber()
        {
            var userInformation = new UserInformation(
                firstName: "First Name",
                lastName: "Last Name",
                dateOfBirth: new DateTime(2024, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var provider = new FraudDetectorProvider();

            var result = provider.IsFraudDetected(userInformation);

            result.Should().BeTrue();
        }
    }
}
