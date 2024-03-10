//-----------------------------------------------------------------------
// <copyright file="FraudDetectorProvider.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.FraudDetector
{
    using ExternalLib.PulledFromNuget.FraudDetection;

    public class FraudDetectorProvider : IFraudDetectionProvider
    {
        private readonly FraudDetector fraudDetector;

        public FraudDetectorProvider()
        {
            this.fraudDetector = new FraudDetector();
        }

        public bool IsFraudDetected(UserInformation userInformation)
        {
            var result = this.fraudDetector.IsCustomerDeclaredAsFraud(
                firstName: userInformation.firstName,
                lastName: userInformation.lastName,
                dateOfBirth: userInformation.dateOfBirth);

            return result;
        }
    }
}
