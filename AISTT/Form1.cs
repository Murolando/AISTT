using AIST.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISTT
{
    public partial class mainForm : Form
    {
        static string filePath { get; set; }
        public mainForm()
        {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            //mainTextBox.AllowDrop = true;
        }


        //tests
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }















        //Закрытие приложения
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainTextBox.Text != "")
            {

                if (MessageBox.Show("Вы хотите сохранить изменения?", "AIST", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (filePath == null)
                    {
                        FileManager.SaveTextAs(mainTextBox.Text);

                    }
                    else
                    {
                        FileManager.SaveText(filePath, mainTextBox.Text);
                    }
                }
            }
        }
        //создать новый файл
        private void newFileM_Click(object sender, EventArgs e)
        {
            if(mainTextBox.Text!="")
            {

               if( MessageBox.Show("Вы хотите сохранить изменения?", "AIST", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if (filePath == null)
                    {
                        FileManager.SaveTextAs(mainTextBox.Text);

                    }
                    else
                    {
                        FileManager.SaveText(filePath, mainTextBox.Text);
                    }
                }
            }
            filePath = null;
            mainTextBox.Clear();
        }
        //открыть файл
        private void openFileM_Click(object sender, EventArgs e)
        {
          
           OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Text = FileManager.GetText(dlg.FileName);
                mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);

                filePath = dlg.FileName;
            }
        }
        //сохранение файла
        private void saveFileM_Click(object sender, EventArgs e)
        {
            if(filePath!=null)
            {
                FileManager.SaveText(filePath,mainTextBox.Text);
            }
            else
            {
                FileManager.SaveTextAs(mainTextBox.Text);
            }
        }
        private void saveAsFilem_Click(object sender, EventArgs e)
        {
            FileManager.SaveTextAs(mainTextBox.Text);
        }
        //Изменение размера шрифта
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
        }

        
    }
}
