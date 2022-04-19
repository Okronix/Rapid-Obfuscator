using System;
using System.IO;
using System.Text;

namespace Rapid_Obfuscator
{
    internal class Obfuscate
    {
        const string tempPath = "temp.ro";
        public void ReplaceVariable(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                File.WriteAllText(tempPath, sr.ReadToEnd(), Encoding.Default);
            }

            string[] allLines = File.ReadAllLines(path);
            
            Random rand = new Random();
            foreach (string line in allLines)
            {
                if (line.Contains("string"))
                {
                    string[] fileLine = line.Split(' ');
                    for (int i = 0; i < fileLine.Length; i++)
                    {
                        if (fileLine[i] == "string") //panel2_DragLeave(string path - не возьмет)
                        {
                            string varName;
                            varName = fileLine[i+1];
                            if (varName[varName.Length-1] == '=')
                            {
                                varName = varName.Substring(0, varName.Length - 1); ;
                            }
                            
                            string varNameRep = "";
                            char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                            for(int k = 0; k < 10; k++)
                            {
                                varNameRep += letters[rand.Next(0, letters.Length - 1)];
                            }
                            string fileData = File.ReadAllText(tempPath, Encoding.Default);
                            fileData = fileData.Replace(varName, varNameRep);
                            File.WriteAllText(tempPath, fileData, Encoding.Default);
                        }
                    }
                }
            }

        }

        public void EncryptVariable()
        {

        }

        public void MakeOneSting()
        {

        }
        public void SaveFile(string path)
        {
            string data = File.ReadAllText(tempPath, Encoding.Default);
            //File.Delete(tempPath);
            File.WriteAllText(path, data, Encoding.Default);
        }

    }
}
