//-----------------------------------------------------------------------
// <copyright file="ContractValidatorRequestTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ContractAnalyzer.ContractValidator.Tests
{
    using FluentAssertions;
    using FluentAssertions.Extensions;

    public class ContractValidatorRequestTests
    {
        [Fact]
        public void ShouldBeInitializedWithUserDateOfBirth()
        {
            var userInformation = new UserInformation(default!, default!, dateOfBirth: new DateTime(2000, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var request = new ContractValidatorRequest(userInformation: userInformation);

            request.UserInformation.dateOfBirth.Should().Be(01.January(2000));
        }
    }
}
