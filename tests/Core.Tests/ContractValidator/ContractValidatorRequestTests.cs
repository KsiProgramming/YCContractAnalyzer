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
            var request = new ContractValidatorRequest(userBirthDate: new DateOnly(2000, 01, 01));

            request.UserBirthDate.Should().Be(DateOnly.FromDateTime(01.January(2000)));
        }
    }
}
