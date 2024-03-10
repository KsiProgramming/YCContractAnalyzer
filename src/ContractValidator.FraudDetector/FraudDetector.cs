//-----------------------------------------------------------------------
// <copyright file="FraudDetector.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalLib.PulledFromNuget.FraudDetection
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Request: SACRED INDIAN LAND : DON'T TOUCH
    /// Response: Sorry, I had to touch, but just to surpass some warnings.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public sealed class FraudDetector
    {
        public bool IsCustomerDeclaredAsFraud(string firstName, string lastName, DateTime dateOfBirth)
        {
#pragma warning disable S6561 // Avoid using "DateTime.Now" for benchmarking or timing operations
            int milliSecondsSinceMidnight = (DateTime.Now - DateTime.Today).Milliseconds;
#pragma warning restore S6561 // Avoid using "DateTime.Now" for benchmarking or timing operations
            return milliSecondsSinceMidnight % 2 == 0;
        }
    }
}
