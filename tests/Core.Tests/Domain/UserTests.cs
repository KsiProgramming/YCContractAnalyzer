﻿//-----------------------------------------------------------------------
// <copyright file="UserTests.cs" company="KsiProgramming">
//     Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.Tests
{
    using FluentAssertions;
    using FluentAssertions.Extensions;

    public class UserTests
    {
        [Fact]
        public void ShouldBeInitializedWithCorrectProperties()
        {
            var user = new User(
                firstName: "First Name",
                lastName: "Last Name",
                birthDate: new DateTime(2024, 01, 01, 0, 0, 0, DateTimeKind.Utc));

            user.FirstName.Should().Be("First Name");
            user.LastName.Should().Be("Last Name");
            user.BirthDate.Should().Be(01.January(2024));
        }
    }
}
