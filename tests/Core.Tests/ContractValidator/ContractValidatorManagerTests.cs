//-----------------------------------------------------------------------
// <copyright file="ContractValidatorManagerTests.cs" company="KsiProgramming">
// Copyright (c) KsiProgramming. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ContractAnalyzer.ContractValidator.Tests
{
    using FluentAssertions;
    using Moq;

    public class ContractValidatorManagerTests
    {
        [Fact]
        public void ValidateShouldReturnEmptyListWhenNoRuleIsInViolation()
        {
            var request = new ContractValidatorRequest(default!);

            var rule1 = new Mock<IContractRuleCheck<ContractValidatorRequest>>(MockBehavior.Strict);
            rule1.Setup(r => r.Check(request))
                .Returns(new RuleResponse("Rule1", false));
            var rule2 = new Mock<IContractRuleCheck<ContractValidatorRequest>>(MockBehavior.Strict);
            rule2.Setup(r => r.Check(request))
                .Returns(new RuleResponse("Rule2", false));
            var rules = new IContractRuleCheck<ContractValidatorRequest>[2] { rule1.Object, rule2.Object };

            var contractValidator = new ContractValidatorManager(rules);

            var result = contractValidator.Validate(request);

            result.Should().BeEmpty();

            rule1.VerifyAll();
            rule2.VerifyAll();
        }

        [Fact]
        public void ValidateShouldReturnNonEmptyListWhenRuleIsInViolation()
        {
            var request = new ContractValidatorRequest(default!);

            var rule1 = new Mock<IContractRuleCheck<ContractValidatorRequest>>(MockBehavior.Strict);
            rule1.Setup(r => r.Check(request))
                .Returns(new RuleResponse("Rule1", false));
            var rule2 = new Mock<IContractRuleCheck<ContractValidatorRequest>>(MockBehavior.Strict);
            rule2.Setup(r => r.Check(request))
                .Returns(new RuleResponse("Rule2", true));
            var rules = new IContractRuleCheck<ContractValidatorRequest>[2] { rule1.Object, rule2.Object };

            var contractValidator = new ContractValidatorManager(rules);

            var result = contractValidator.Validate(request);

            result.Should().HaveCount(1);
            result.ElementAt(0).Name.Should().Be("Rule2");
            result.ElementAt(0).IsInViolation.Should().Be(true);

            rule1.VerifyAll();
            rule2.VerifyAll();
        }
    }
}
