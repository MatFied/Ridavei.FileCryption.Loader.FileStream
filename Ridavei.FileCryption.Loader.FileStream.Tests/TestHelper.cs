using System.IO;

namespace Ridavei.FileCryption.Loader.FileStream.Tests
{
    internal class TestHelper
    {
        internal static string ReadTextFromFile(Stream file)
        {
            using (var sr = new StreamReader(file))
                return sr.ReadToEnd();
        }
    }
}
