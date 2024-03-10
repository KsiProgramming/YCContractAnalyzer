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
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2000, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var result = request.IsUnderAgeFrom(new DateTime(2017, 12, 31, 0, 0, 0, DateTimeKind.Utc));

            result.Should().BeTrue();
        }

        [Fact]
        public void IsUnderAgeFromShouldBeFalseWhenUserBirthDateEquals18()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2000, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var result = request.IsUnderAgeFrom(new DateTime(2018, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            result.Should().BeFalse();
        }

        [Fact]
        public void IsUnderAgeFromShouldBeTrueWhenUserBirthDateIsAbove18()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2000, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            var result = request.IsUnderAgeFrom(new DateTime(2018, 01, 02, 0, 0, 0, DateTimeKind.Utc));

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
            var userBirthDate = DateTime.Parse(userBirthDateString, default);
            var fromDate = DateTime.Parse(fromDateString, default);

            var userInformation = new UserInformation(default!, default!, dateOfBirth: userBirthDate);

            var request = new ContractValidatorRequest(userInformation: userInformation);
            var result = request.IsUnderAgeFrom(fromDate);

            result.Should().Be(expectedResult);
        }
    }
}
