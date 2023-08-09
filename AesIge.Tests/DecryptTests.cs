namespace System.Security.Cryptography
{
    public class DecryptTests
    {

        [Test]
        public void TestVector1()
        {
            var aesEng = new AesIge
            {
                IV = TestData.IVTest1,
                Key = TestData.KeyTest1
            };
            var plainText = aesEng.Decrypt(TestData.CipherText1);
            Assert.That(plainText, Is.EqualTo(TestData.PlainText1));
        }

        [Test]
        public void TestVector2()
        {
            var aesEng = new AesIge
            {
                IV = TestData.IVTest2,
                Key = TestData.KeyTest2
            };
            var plainText = aesEng.Decrypt(TestData.CipherText2);
            Assert.That(plainText, Is.EqualTo(TestData.PlainText2));
        }
    }
}
