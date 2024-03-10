//-----------------------------------------------------------------------
// <copyright file="IsystemClock.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer
{
    public interface IsystemClock
    {
        DateTimeOffset UtcNow { get; }
    }
}
