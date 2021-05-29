using System.IO;

namespace Cursach
{
    public static class FileManager
    {
        public static void Write(string path, string text)
        {
            using (StreamWriter streamWriter = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {
                streamWriter.Write(text);
            }
        }
        
        public static string Read(string path)
        {
            if (File.Exists(path))
            {
                string result = "";
                using (StreamReader streamReader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    string line;
                    while (streamReader.Peek()>-1)
                    {
                        line = streamReader.ReadLine();
                        result += line + ' ';
                    }
                }

                return result;
            }
            else
            {
                return "File is not found";
            }
        }
    }
}