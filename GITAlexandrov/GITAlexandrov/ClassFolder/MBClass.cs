using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GITAlexandrov.ClassFolder
{
    internal class MBClass
    {
        public static void ErrorMB(string text)
        {
            MessageBox.Show(text, "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }
}
