using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Rapid_Obfuscator
{
    internal class Obfuscate
    {
        public const string tempPath = "temp.ro";

        public void ReplaceVariable() //функция замены названия переменных
        {
            string[] allLines = File.ReadAllLines(tempPath); //Считываем исходный файл построчно

            Random rand = new Random();
            foreach (string line in allLines)
            {
                if (line.Contains("string")) // || line.Contains("int") || line.Contains("float") || line.Contains("double") || line.Contains("bool") //проверяем, содержатся ли объявления переменных
                {
                    string[] fileLine = line.Split(' '); //Разбиваем строчку на слова
                    for (int i = 0; i < fileLine.Length; i++) //перебор слов
                    {
                        if (fileLine[i] == "string") // || fileLine[i] == "int" || fileLine[i] == "float" || fileLine[i] == "double" || fileLine[i] == "bool" //если нашли нужное слово
                        {
                            string varName;
                            varName = fileLine[i + 1];
                            if (varName[varName.Length - 1] == '=')
                            {
                                varName = varName.Substring(0, varName.Length - 1);
                            }

                            string varNameRep = "";
                            char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //словарь для генерации названия переменной
                            for (int k = 0; k < 10; k++)
                            {
                                varNameRep += letters[rand.Next(0, 52)];
                            }
                            string fileData = File.ReadAllText(tempPath, Encoding.Default); //считываем файл
                            fileData = fileData.Replace(varName, varNameRep); //заменяем названия переменных
                            File.WriteAllText(tempPath, fileData, Encoding.Default); //записываем в файл
                            SaveFile(tempPath); //сохраняем временный файл
                        }
                    }
                }
            }
        }

        public void DeleteComment(StringBuilder content, string start, string end) //функция удаления комментарием
        {
            string contentStr;
            int startIndex = 0;
            int endIndex = 0;

            //длина концовки;
            //если мы ищем однострочный комментарий значит длина концовки равна нулю
            int endLength = (end == Environment.NewLine) ? 0 : end.Length;

            while (true)
            {
                contentStr = content.ToString();
                startIndex = contentStr.IndexOf(start);
                endIndex = (startIndex != -1) ? contentStr.IndexOf(end, startIndex) : -1;

                if (startIndex != -1 && endIndex != -1)
                {
                    content.Remove(startIndex, endIndex + endLength - startIndex);
                }
                //если нашелся только начальный индекс и мы удаляем однострочный комментарий
                //значит после комментария идет конец файла, в таком случае удаляем все
                //начиная со startIndex
                else if (startIndex != -1 && end == Environment.NewLine)
                {
                    content.Remove(startIndex, content.Length - startIndex);
                }
                //если не найден ни один индекс завершаем поиск
                else
                {
                    break;
                }

                File.WriteAllText(tempPath, content.ToString(), Encoding.Default); //записываем результат в файл
                SaveFile(tempPath); //сохраняем временный файл
            }
        }

        public void MakeOneSting() //функция преобразования кода в одну строку
        {
            string allLines = File.ReadAllText(tempPath); //считываем построчно файл
            for(int i = 0; i < allLines.Length; i++)
            {
                allLines = Regex.Replace(allLines, @"\s", "", RegexOptions.None); //заменяем найденные отступы и пробелы
            }

            File.WriteAllText(tempPath, allLines, Encoding.Default); //записываем результат в файл
        }

        public void SaveFile(string path) //функция сохранения файл
        {
            string data = File.ReadAllText(tempPath, Encoding.Default); //считываем временный файл
            File.WriteAllText(path, data, Encoding.Default); //сохраняем файл по указанному пути
        }

    }
}
