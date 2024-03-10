//-----------------------------------------------------------------------
// <copyright file="ContractValidatorRequestExtensionsTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Tests
{
    using FluentAssertions;

    public class ContractValidatorRequestExtensionsTests
    {
        [Fact]
        public void IsMinorFromShouldBeTrueWhenUserBirthDateIsUnder18()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            var result = request.IsMinorFrom(new DateOnly(2017, 12, 31));

            result.Should().BeTrue();
        }

        [Fact]
        public void IsMinorFromShouldBeFalseWhenUserBirthDateEquals18()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            var result = request.IsMinorFrom(new DateOnly(2000, 01, 01));

            result.Should().BeFalse();
        }

        [Fact]
        public void IsMinorFromShouldBeTrueWhenUserBirthDateIsAbove18()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            var result = request.IsMinorFrom(new DateOnly(2018, 01, 02));

            result.Should().BeFalse();
        }
    }
}
