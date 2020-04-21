using NUnit.Framework;

using WordDocxEditor.CustomCity;


namespace NUnitTests
{
    public class CityVerifierTests
    {
        [Test]
        public void Verify_NullPostalCode_ShouldReturnFalse()
        {
            var verifier = new CityVerifier();

            var result = verifier.Verify(null, "city");

            Assert.IsFalse(result.IsSuccess);
        }

        [Test]
        public void Verify_WhitespacePostalCode_ShouldReturnFalse()
        {
            var verifier = new CityVerifier();

            var result = verifier.Verify("   ", "city");

            Assert.IsFalse(result.IsSuccess);
        }

        [Test]
        public void Verify_WrongPostalCodeLenght_ShouldReturnFalse()
        {
            var verifier = new CityVerifier();

            var result = verifier.Verify("555-666", "city");

            Assert.IsFalse(result.IsSuccess);
        }

        [TestCase("-11111")]
        [TestCase("2-2222")]
        [TestCase("333-33")]
        [TestCase("4444-4")]
        [TestCase("55555-")]
        [TestCase("55-55-5-")]
        public void Verify_WrongPostalCodeFormat_ShouldReturnFalse(string postalCode)
        {
            var verifier = new CityVerifier();

            var result = verifier.Verify(postalCode, "city");

            Assert.IsFalse(result.IsSuccess);
        }

        [Test]
        public void Verify_CorrectPostalCode_ShouldReturnTrue()
        {
            var verifier = new CityVerifier();

            var result = verifier.Verify("95-060", "city");

            Assert.IsTrue(result.IsSuccess);
        }
    }
}