namespace System.Security.Cryptography
{
    public class EncryptTests
    {

        [Test]
        public void TestVector1()
        {
            var aesEng = new AesIge
            {
                IV = TestData.IVTest1,
                Key = TestData.KeyTest1
            };
            var cipherText = aesEng.Encrypt(TestData.PlainText1);
            Assert.That(cipherText, Is.EqualTo(TestData.CipherText1));
        }

        [Test]
        public void TestVector2()
        {
            var aesEng = new AesIge
            {
                IV = TestData.IVTest2,
                Key = TestData.KeyTest2
            };
            var cipherText = aesEng.Encrypt(TestData.PlainText2);
            Assert.That(cipherText, Is.EqualTo(TestData.CipherText2));
        }
    }
}