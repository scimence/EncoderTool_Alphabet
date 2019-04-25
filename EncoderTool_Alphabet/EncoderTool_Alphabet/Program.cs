using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EncoderTool_Alphabet
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                string[] files = DragDropTool.GetSubFiles(args);
                foreach (string file in files)
                {
                    EncoderTool_Alphabet.getAlphabetData(file);
                }
            }
        }
    }
}
