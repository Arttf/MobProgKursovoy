using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсовойМобПрог
{
    sealed class ReadWriteFile
    {
        private static ReadWriteFile _instance = null;
        public static ReadWriteFile getInstance()
        {
            //lock (this)
            //{

            if (_instance == null)
                _instance = new ReadWriteFile();
            return _instance;
            //}
        }
        private void Dialog(string text) {
            MessageBox.Show(
           text,
           "Сообщение",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }
        public void Write(string text, string path)//@"Date\Doc.txt"
        { 
            // создаем каталог для файла

            //DirectoryInfo dirInfo = new DirectoryInfo(path);
            //if (!dirInfo.Exists)
            //{
            //    dirInfo.Create();
            //}
          

            // запись в файл
            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Dialog("Сохранено");               
            }
        }
        public string Read(string path)//@"Date\Sportsman.txt"
        {            
            // чтение из файла
            using (FileStream fstream = File.OpenRead($"{path}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                return textFromFile;
            }
            
        }
    }
}
