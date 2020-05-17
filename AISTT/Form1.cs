
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
using AISTT;

namespace AISTT
{
    public partial class mainForm : Form
    {
        static string filePath { get; set; }

        List<Buttonn> Buttonns = new List<Buttonn>();
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        //выбор вершин для соединения
        Point[] conntect = new Point[2];
        int vertexes = -1;
        //id вершин
        Pair<int, int> idForConnection=new Pair<int, int>(0,0);

        //Построение связзей
        private  void HPButton_Click(object sender, EventArgs e)
        {
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, 0);
            if (vertexes != 1)
                return;
           
            Graphics gr= pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        
        }
        public static void MakeConntection(List<Buttonn> Buttons, int idIn, int idOut, int valueOfConnection)
        {
            for (int i = 0; i < Buttons.Count; i++)
            {
                if (Buttons[i].buttonId == idOut)
                    Buttons[i].connections.Add(new Pair<int, int>(idIn, valueOfConnection));
                if (Buttons[i].buttonId == idIn)
                    Buttons[i].connections.Add(new Pair<int, int>(idOut, valueOfConnection));
            }
        }

        //считывание нажатий
        public void FieldClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.LightGray;
                conntect[vertexes].X = 0;
                conntect[vertexes].Y = 0;
                vertexes--;
                if (idForConnection.First != 0)
                {

                    idForConnection.First = 0;
                }
                else
                    idForConnection.Second = 0;
            }
            else
            {
                vertexes++;
                try
                {
                    conntect[vertexes] = button.Location;
                    if (idForConnection.First == 0)
                    {

                        idForConnection.First = Convert.ToInt32(button.Name);
                    }
                    else
                        idForConnection.Second = Convert.ToInt32(button.Name);
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




        #region создание вершин 
        //Создание вершин сети, посредством перетаскивания текста из mainTextBox
        int id =0;
        public void makeNewVertex(string e)
        {

            Point position = Cursor.Position;
            id++;
            Button temp = new Button();
            temp.Name = id.ToString();
            int hight = Convert.ToInt32(temp.Font.Size * 1);
            int weight = Convert.ToInt32(temp.Font.Size * e.Length + temp.Font.Size);
            temp.Text = e;
            temp.Width = 20;
            temp.Size = new System.Drawing.Size(20, 30);
            temp.Location = new Point(position.X, position.Y - 30);
            //убрали обводку
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = FlatStyle.Flat;
            //Добавляем элемент на форму
            temp.Click += new EventHandler(FieldClick);
            this.Controls.Add(temp);
            temp.BringToFront();
            //в список его для дальнейшей сериализации
           Buttonns.Add(new Buttonn( temp.Name, temp.Text, position, id, new List<Pair<int,int>> () ) );
        }
        #endregion 

        #region DragAndDrop
        //перетаскивание
        private void mapPanel_DragDrop(object sender, DragEventArgs e)
        {
            makeNewVertex(e.Data.GetData(DataFormats.Text).ToString());
        }
        private void mapPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        #endregion

        #region сохранение файлов

        //Закрытие приложения
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainTextBox.Text != "")
            {

                if (MessageBox.Show("Вы хотите сохранить изменения?", "AIST", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (filePath == null)
                    {
                        FileManager.SaveFileAs(mainTextBox.Text,Buttonns);
                        

                    }
                    else
                    {
                        FileManager.SaveFile(filePath, mainTextBox.Text, Buttonns);
                       
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
                        FileManager.SaveFileAs(mainTextBox.Text, Buttonns);
                     

                    }
                    else
                    {
                        FileManager.SaveFile(filePath, mainTextBox.Text, Buttonns);
                        
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
                mainTextBox.Text = FileManager.GetFile(dlg.FileName);
                mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);

                filePath = dlg.FileName;
            }
        }
        //сохранение файла
        private void saveFileM_Click(object sender, EventArgs e)
        {
            if(filePath!=null)
            {
                FileManager.SaveFile(filePath,mainTextBox.Text, Buttonns);
               
            }
            else
            {
                FileManager.SaveFileAs(mainTextBox.Text, Buttonns);
             
            }
        }
        private void saveAsFilem_Click(object sender, EventArgs e)
        {
            FileManager.SaveFileAs(mainTextBox.Text, Buttonns);
           
        }
        #endregion

        //Изменение размера шрифта
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
        }

        #region доп функции,которых пока нет
        //отменить последнее действие
        private void BackButton_Click(object sender, EventArgs e)
       {

       }

       //Удаление вершин 
       private void ClearButton_Click(object sender, EventArgs e)
       {

       }
        #endregion




    }
}
