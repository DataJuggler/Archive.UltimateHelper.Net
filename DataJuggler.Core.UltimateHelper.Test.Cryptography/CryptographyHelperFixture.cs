using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataJuggler.Core.UltimateHelper.Test.Cryptography
{
    [TestClass]
    public class CryptographyHelperFixture
    {
        [TestMethod]
        public void TestEncryptionDecryption()
        {
            var message = "Some string that has a ↈ weird character in it.";
            var password = "crypto1234";

            var encrypted = CryptographyHelper.EncryptString(message, password);
            var decrypted = CryptographyHelper.DecryptString(encrypted, password);

            Assert.AreEqual(message, decrypted);
        }
    }
}