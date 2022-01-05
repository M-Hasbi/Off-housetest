using System.IO;

namespace DownloadingExercise
{
    public class Methods
    {
        public void CreateIfMissing(string subPath)
        {
            bool exists = Directory.Exists(subPath);

            if (!exists)
                Directory.CreateDirectory(subPath);
        }
    }
}
