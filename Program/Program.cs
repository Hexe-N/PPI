/**
*@файл.программа
*@автор Близниченко
*@ссылка 
*@copiright Авторское право
*@лицензия
*/

using System;
using System.Windows.Forms;
using VectorEditor.Model;
using VectorEditor.View;

namespace VectorEditor
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            var figureModel = new FigureModel();

            var presenter = new Presenter.Presenter(mainForm, figureModel);

            Application.Run(mainForm);
        }
    }
}
/**
*@пакет 
*@начиная с 0.1
*@todo планируется добавить инструменты
*@версия Версия 1.1
*/

