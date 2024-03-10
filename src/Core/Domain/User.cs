//-----------------------------------------------------------------------
// <copyright file="User.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer
{
    public class User
    {
        public User(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public DateTime BirthDate { get; }
    }
}
