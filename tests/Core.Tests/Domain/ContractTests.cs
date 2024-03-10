//-----------------------------------------------------------------------
// <copyright file="ContractTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.Tests
{
    using FluentAssertions;

    public class ContractTests
    {
        [Fact]
        public void ShouldBeInitializedWithCorrectProperties()
        {
            var user = new User(
                firstName: "First Name",
                lastName: "Last Name",
                birthDate: new DateTime(2024, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            var contract = new Contract(
                user: user,
                requestedAmount: 25);

            contract.User.Should().BeSameAs(user);
            contract.RequestedAmount.Should().Be(25);
        }
    }
}
