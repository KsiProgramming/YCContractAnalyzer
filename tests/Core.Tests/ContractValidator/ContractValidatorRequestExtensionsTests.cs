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
        public void IsUnderAgeFromShouldBeTrueWhenUserBirthDateIsUnder18()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            var result = request.IsUnderAgeFrom(new DateOnly(2017, 12, 31));

            result.Should().BeTrue();
        }

        [Fact]
        public void IsUnderAgeFromShouldBeFalseWhenUserBirthDateEquals18()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            var result = request.IsUnderAgeFrom(new DateOnly(2018, 01, 01));

            result.Should().BeFalse();
        }

        [Fact]
        public void IsUnderAgeFromShouldBeTrueWhenUserBirthDateIsAbove18()
        {
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            var result = request.IsUnderAgeFrom(new DateOnly(2018, 01, 02));

            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("1990-01-01", "2024-03-10", false)]
        [InlineData("2006-03-09", "2024-03-10", false)]
        [InlineData("2006-03-10", "2024-03-10", false)]
        [InlineData("2006-03-11", "2024-03-10", true)]
        [InlineData("2030-01-01", "2024-03-10", true)]
        public void IsUnderAge(string userBirthDateString, string fromDateString, bool expectedResult)
        {
            var userBirthDate = DateOnly.Parse(userBirthDateString, default);
            var fromDate = DateOnly.Parse(fromDateString, default);

            var request = new ContractValidatorRequest(userBirthDate: userBirthDate);
            var result = request.IsUnderAgeFrom(fromDate);

            result.Should().Be(expectedResult);
        }
    }
}
