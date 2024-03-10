//-----------------------------------------------------------------------
// <copyright file="UserTests.cs" company="KsiProgramming">
//     Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.Tests
{
    using FluentAssertions;

    public class UserTests
    {
        [Fact]
        public void ShouldBeInitializedWithCorrectNames()
        {
            var user = new User(
                firstName: "First Name",
                lastName: "Last Name");

            user.FirstName.Should().Be("First Name");
            user.LastName.Should().Be("Last Name");
        }
    }
}
