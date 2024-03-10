//-----------------------------------------------------------------------
// <copyright file="IFraudDetectionProvider.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator
{
    public interface IFraudDetectionProvider
    {
        bool IsFraudDetected(UserInformation userInformation);
    }
}
