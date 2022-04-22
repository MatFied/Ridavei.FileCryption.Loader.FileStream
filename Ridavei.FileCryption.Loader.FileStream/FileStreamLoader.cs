using System;
using System.IO;
using System.Security;

namespace Ridavei.FileCryption.Loader.FileStream
{
    /// <summary>
    /// Static class for extending the <see cref="AFileCryptionBuilderBase{T}"/>.
    /// </summary>
    public static class FileStreamLoader
    {
        /// <summary>
        /// Extension method that uses <see cref="System.IO.FileStream"/> as file loader method.
        /// </summary>
        /// <param name="builder">Builder for file encryption/decryption.</param>
        /// <param name="fileShare">Enum used to determine how the file will be shared by processes.</param>
        /// <returns>Builder</returns>
        public static T UseFileStreamLoader<T>(this AFileCryptionBuilderBase<T> builder, FileShare fileShare = FileShare.Read)
            where T : AFileCryptionBuilderBase<T>
        {
            return builder.SetFileLoaderMethod((object filePath) =>
            {
                return new System.IO.FileStream(filePath.ToString(), FileMode.Open, FileAccess.Read, fileShare);
            });
        }
    }
}