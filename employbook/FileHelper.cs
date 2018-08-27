using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace employbook
{
    public static class FileHelper
    {
        /// <summary>
        /// write content to the file
        /// </summary>
        /// <param name="filename">name of the file</param>
        /// <param name="content">content to write to the file</param>
        public static async void WriteTextFileAsync(string filename, string content)
        {
            var localFolder = ApplicationData.Current.LocalFolder;
           var textFile = await localFolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);
           var textStream= await textFile.OpenAsync(FileAccessMode.ReadWrite);
            var textWriter = new DataWriter(textStream);
            textWriter.WriteString(content);
            await textWriter.StoreAsync();
        }

    }
}
