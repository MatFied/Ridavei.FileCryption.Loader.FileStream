using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;

using Ridavei.FileCryption.Loader.FileStream.Tests.Extensions;

using NUnit.Framework;

namespace Ridavei.FileCryption.Loader.FileStream.Tests
{
    [TestFixture]
    public class FileStreamTests
    {
        private FileEncryptionBuilder TestObj;

        private string TestFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "EncryptFile.txt");
        private string ExpectedValue = "eTtsp rhsae";

        [SetUp]
        public void SetUp()
        {
            TestObj = FileEncryptionBuilder
                .CreateBuilder()
                .UseEncryptTxtExt();
        }

        [Test]
        public void UseFileStreamLoader__NoException()
        {
            Assert.DoesNotThrow(() =>
            {
                using (Stream stream = TestObj
                    .UseFileStreamLoader()
                    .Encrypt(TestFilePath, new ContentType(MediaTypeNames.Text.Plain), "pass"))
                {
                    Assert.IsNotNull(stream);
                    Assert.AreEqual(ExpectedValue, TestHelper.ReadTextFromFile(stream));
                }
            });
        }
    }
}