using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ision
{
    internal class IdGen
    {
        public static string path = "id"; // Название файла, который хранит в себе id

        public static void Create()
        {
            bool file_exist = false; // Переменная, проверяющая существование файла

            if (File.Exists(path)) //Если файл существует, то присваиваем значение True и ничего не делаем
            {
                file_exist = true;
            }
            if (file_exist == false) //Если файл с данными не существует, то создаём его
            {
                using StreamWriter writer = new(path, false); //Запись файла по пути path. False - перезапись файла, true - дописать в файл
                File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden);
                Random id = new();
                writer.Write(id.Next());
                writer.Close(); // Прекращаем взаимодействие с файлом EnterData
            }
        }

        public static string? Get()
        {
            using StreamReader reader = new(path); //Считываем строки из EnterData и получаем их хэш
            string? indent = Convert.ToString(reader.ReadLine());
            reader.Close(); // Прекращаем взаимодействие с файлом EnterData

            return indent;
        }
    }
}
