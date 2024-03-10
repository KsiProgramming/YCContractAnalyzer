//-----------------------------------------------------------------------
// <copyright file="Contract.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer
{
    public class Contract
    {
        public Contract(User user, int requestedAmount)
        {
            this.User = user;
            this.RequestedAmount = requestedAmount;
        }

        public User User { get; }

        public int RequestedAmount { get; }
    }
}
