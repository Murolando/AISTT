using AIST.BL;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
           
        }


        //Построение связи
        private void HPButton_Click(object sender, EventArgs e)
        {
            if (vertexes != 1)
                return;
           
            Graphics gr= mapPanel.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        
    }


    //Создание вершин сети, посредством перетаскивания текста из mainTextBox
    private void makeNewVertex(string e)
        {
            Point position = Cursor.Position;
         
            Button temp = new Button();
            int hight = Convert.ToInt32(temp.Font.Size * 1);
            int weight = Convert.ToInt32(temp.Font.Size * e.Length + temp.Font.Size);
            temp.Text = e;
            temp.Width = 20;
            temp.Size = new System.Drawing.Size(20,30 );
            temp.Location = new Point(position.X, position.Y - 30);
            //убрали обводку
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = FlatStyle.Flat;
            //Добавляем элемент на форму
            temp.Click += new EventHandler(FieldClick);
            this.Controls.Add(temp);
            temp.BringToFront();
        }

        //выбор вершин
        Point[] conntect = new Point[2];
        int vertexes=-1;
        void FieldClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.LightGray;    
                    conntect[vertexes].X = 0;
                    conntect[vertexes].Y = 0;
                    vertexes--;
            }
            else
            {
                vertexes++;
                try 
                {
                    conntect[vertexes] = button.Location;
                
                }
                catch 
                {
                    MessageBox.Show("Вы можете выбрать только две вершины");
                    vertexes--;
                    return;
                }
                button.BackColor = Color.Red;
            }



        }
        //перетаскивание
        private void mapPanel_DragDrop(object sender, DragEventArgs e)
        {
            makeNewVertex(e.Data.GetData(DataFormats.Text).ToString());
        }
        private void mapPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        #region 

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
        #endregion

        //Изменение размера шрифта
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
        }

       
    }
}
