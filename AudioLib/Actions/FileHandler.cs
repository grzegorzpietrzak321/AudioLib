using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AudioLib.Actions
{
    class FileHandler
    {
        //TODO dodać checkBox: bool Czy Chcesz Skopiować Pliki Do Biblioteki Czy Przenieść 
        //TODO czy chcesz zmienić nazwy plików na własne: wylistować pliki, ostrzeżenie, że mogą zawierać tytuły rozdziałów i nie zawsze warto



        public static List<string> Folders;
        /*
                public static string Path = String.Empty;
        */

        public static string ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            while (string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                System.Windows.MessageBox.Show("Błąd wybierania folderu", "Message");
            }

            return fbd.SelectedPath;
        }

        public static List<string> ScanFolders(string path)
        {
            //path = "F:/Audiobooks/";
            try
            {
                Folders = Directory.GetDirectories(path).ToList(); //listowanie plików w tempie

                for (int i = 0; i < Folders[i].Length; i++)
                {
                    string tmp = Folders[i];
                    Folders[i] = tmp;
                }
            }
            catch (Exception)
            {
                //System.Windows.MessageBox.Show(ex.ToString());
            }

            return Folders;
        }
    }
}