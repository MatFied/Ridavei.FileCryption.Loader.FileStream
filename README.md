# Ridavei.FileCryption.Loader.FileStream

Builder extension for loading file through FileStream for file decryption/encryption.

## Example of use

```csharp
using System.IO;
using System.Net.Mime;

using Ridavei.FileCryption;
using Ridavei.FileCryption.Loader.FileStream;

namespace TestProgram
{
    class Program
    {
        public static void Main (string[] args)
        {
            ContentType contentType;
            string fileInfo = "YOUR_PATH_TO_THE_FILE";
            string password;
            
            /*
              Setting the variables above
            */
            using (Stream decryptedFile = FileDecryptionBuilder
                .CreateBuilder()
                .UseFileStreamLoader()
                .AddDecryptionMethod(contentType, DecryptionMethod)
                .Decrypt(fileInfo, contentType, password))
            {
                //Saving the file
            }
        }
        
        private static Stream DecryptionMethod(Stream file, string password)
        {
            //Return decrypted Stream
        }
    }
}
```
