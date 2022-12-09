using System;

namespace Ision
{
    static class Login
    {
        public static string path = "LogData.gh"; // Название файла, в котором будут хранится пароли

        public static void FileCreate(string? login, string? password) // Создание файла с переменными
        {
            bool file_exist = false; // Переменная, проверяющая существование файла

            if (File.Exists(path)) // Если файл существует, то присваиваем значение True и ничего не делаем
            {
                file_exist = true;
            }
            if (file_exist == false) // Если файл с данными не существует, то создаём его
            {
                using StreamWriter writer = new(path, false); // Запись файла по пути path. False - перезапись файла, true - дописать в файл
                File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden);
                int hash_log_toWrite = string.GetHashCode(login); // Записываем логин в виде хэша
                int hash_pas_toWrite = string.GetHashCode(password); // Записываем пароль в виде хэша
                writer.WriteLine(hash_log_toWrite); // Пишет в первую строку файла логин
                writer.WriteLine(hash_pas_toWrite); // Пишет во вторую строку файла пароль
                writer.Close(); // Прекращаем взаимодействие с файлом EnterData
                MessageBox.Show("Логин и пароль созданы, используйте их для дальнейшего входа"); // Показывает сообщение пользователю
            }
        }

        public static bool Enter(string? login, string? password) // Проверка логина и пароля и возврат значения result
        {
            bool result = false; // Объявляем переменную

            int log; // Переменная логина, считываемая из файла EnterData
            int pas; // Переменная пароля, считываемая из файла EnterData

            int hash_entered_login = 0; // Переменная для хэша логина из поля textBox_login
            int hash_entered_password = 0; // Переменная для хэша пароля из поля textBox_password

            using (StreamReader reader = new(path)) // Считываем строки из EnterData и получаем их хэш
            {
                log = Convert.ToInt32(reader.ReadLine()); 
                pas = Convert.ToInt32(reader.ReadLine());
                reader.Close(); // Прекращаем взаимодействие с файлом EnterData
            }

            hash_entered_login = string.GetHashCode(login); // Получаем хэш для введёного логина
            hash_entered_password = string.GetHashCode(password); // Получаем хэш для введёного пароля

            if (log == hash_entered_login & pas == hash_entered_password) // Сравниваем хэши, если совпадают то =>
            {
                result = true; 
                return result;
            }
            else // Если не совпадают =>
            {
                MessageBox.Show("Пароли не совпадают");
                result = false;
                return result;
            }
        }
    }
}
