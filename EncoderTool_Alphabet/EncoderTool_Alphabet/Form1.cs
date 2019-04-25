using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncoderTool_Alphabet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            DragDropTool.Form_DragEnter(sender, e);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //DragDropTool.Form_DragDrop(sender, e);

            string filesStr = DragDropTool.dragDrop(e);                 // 获取拖入的文件
            string[] files = filesStr.Split(';');
            // 其他处理逻辑

            foreach (string file in files)
            {
                EncoderTool_Alphabet.getAlphabetData(file);
            }

            MessageBox.Show("已生成转码txt！");
        }
    }
}
