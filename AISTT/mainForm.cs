
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
using System.Xml.Serialization;
using AISTT;

namespace AISTT
{
    public partial class mainForm : Form
    {
       

        List<Buttonn> Buttonns = new List<Buttonn>();
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        //Изменение размера шрифта
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
        }

        #region vertexes and connections



        //выбор вершин для соединения
        Point[] conntect = new Point[2];
        Color[] colors = new Color[5] {Color.LightGreen, Color.Red , Color.Blue , Color.Black, Color.Yellow };
        //id вершин
        Pair<int, int> idForConnection=new Pair<int, int>(0,0);
        //Построение связзей
        private  void HPButton_Click(object sender, EventArgs e)
        {
            
          
            if (conntect[0].X == 0 && conntect[0].Y == 0 || conntect[1].X == 0 && conntect[1].Y == 0)
                return;
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, 0);
            Graphics gr= pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.LightGreen, 3);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        
        }
        private void IsAButton_Click(object sender, EventArgs e)
        {
           
            if (conntect[0].X == 0 && conntect[0].Y == 0 || conntect[1].X == 0 && conntect[1].Y == 0)
                return;
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, 1);
            Graphics gr = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        }
        private void AKOButton_Click(object sender, EventArgs e)
        {
            
            if (conntect[0].X == 0 && conntect[0].Y == 0 || conntect[1].X == 0 && conntect[1].Y == 0)
                return;
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, 2);
            Graphics gr = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 3);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        }
        private void DescButton_Click(object sender, EventArgs e)
        {
           
            if (conntect[0].X == 0 && conntect[0].Y == 0 || conntect[1].X == 0 && conntect[1].Y == 0)
                return;
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, 3);
            Graphics gr = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        }
        private void Value_Click(object sender, EventArgs e)
        {
           
            if (conntect[0].X == 0 && conntect[0].Y == 0 || conntect[1].X == 0 && conntect[1].Y == 0)
                return;
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, 4);
            Graphics gr = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Yellow, 3);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        }

            




        // Создание связей

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
        int vertex = 0;
        public void FieldClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            
            if (button.BackColor == Color.Red )
            {
                vertex--;
                button.BackColor = Color.LightGray;
                if (conntect[0] == button.Location)
                {
                    conntect[0].X = 0;
                    conntect[0].Y = 0;
                }
                else
                {
                    conntect[1].X = 0;
                    conntect[1].Y = 0;
                }
                   
              
                if (idForConnection.First != 0)
                {

                    idForConnection.First = 0;
                }
                else
                    idForConnection.Second = 0;
            }
            else if(vertex<2)
            {
                vertex++;
                    if (conntect[0].X==0 && conntect[0].Y == 0)
                      conntect[0] = button.Location;
                    else
                        conntect[1] = button.Location;
                    if (idForConnection.First == 0)
                    {

                        idForConnection.First = Convert.ToInt32(button.Name);
                    }
                    else
                        idForConnection.Second = Convert.ToInt32(button.Name);
                    
              
               
               
                button.BackColor = Color.Red;
            }
            else
            {

                MessageBox.Show("Вы можете выбрать только две вершины");

                return;
            }



            }
        //Отрисовка связей после открытия файла
        private void MakeConnectionsAfterOpen()
        {
            Point[] conntect1 = new Point[2];
            for (int i = 0; i < Buttonns.Count; i++)
            {

                makeNewVertex(Buttonns[i].Text, Buttonns[i].position, Buttonns[i].size.First, Buttonns[i].size.Second, false);
            }
            for (int i = 0; i < Buttonns.Count; i++)
            {
                for (int j = 0; j < Buttonns[i].connections.Count; j++)
                {

                    conntect1[0].X = Buttonns[i].position.X;
                    conntect1[0].Y = Buttonns[i].position.Y;
                    conntect1[1].X = Buttonns[Buttonns[i].connections[j].First-1].position.X;
                    conntect1[1].Y = Buttonns[Buttonns[i].connections[j].First-1].position.Y;

                 //   MessageBox.Show(Buttonns.Count.ToString());
                    Graphics gr = pictureBox1.CreateGraphics();
                    Pen p = new Pen(colors[Buttonns[i].connections[j].Second], 3);// цвет линии и ширина
                    gr.DrawLine(p, conntect1[0], conntect1[1]);// рисуем линию
                    gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
                }
            }
        }





        #endregion

        #region vertex creation



        //Создание вершин сети, посредством перетаскивания текста из mainTextBox
        int id =0;
        public void makeNewVertex(string e,Point position, int width,int hight,bool need )
        {

           // Point position = Cursor.Position;
            id++;
            Button temp = new Button();
            temp.Name = id.ToString();
            //int hight = Convert.ToInt32(temp.Font.Size * 1);
            //int weight = Convert.ToInt32(temp.Font.Size * e.Length + temp.Font.Size);
            temp.Text = e;
            // temp.Size = size;
            temp.Height = hight;
            temp.Width = width;
            temp.Location = position; 
            //убрали обводку
            temp.BackColor = Color.LightGray;
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = FlatStyle.Flat;
            //Добавляем элемент на форму
            temp.Click += new EventHandler(FieldClick);
            mapPanel.Controls.Add(temp);
            temp.BringToFront();

            //в список его для дальнейшей сериализации
            if(need)
              Buttonns.Add(new Buttonn( temp.Name, temp.Text, position, id, new List<Pair<int,int>> (), new Pair< int,int>(width,hight) ) );
        }


        #endregion  

        #region DragAndDrop


        //перетаскивание
        private void mapPanel_DragDrop(object sender, DragEventArgs e)
        {
            makeNewVertex(e.Data.GetData(DataFormats.Text).ToString(), new Point (Cursor.Position.X - splitContainer1.Panel1.Width, Cursor.Position.Y - 70), e.Data.GetData(DataFormats.Text).ToString().Length*12,20,true);
        }
        private void mapPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        #endregion

        #region save and open files
        static string filePath { get; set; }

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
            pictureBox1.Dispose();
            Buttonns.Clear();
            mapPanel.Controls.Clear();
            conntect[0].X = 0;
            conntect[0].Y = 0;
            conntect[1].X = 0;
            conntect[1].Y = 0;
            vertex = 0;
            pictureBox1.Dispose();
        }
        //открыть файл
        private void openFileM_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Text = FileManager.GetFile(dlg.SelectedPath, ref Buttonns);
                mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
               
                   
                filePath = dlg.SelectedPath;
               // mapPanel.Controls.Clear();
              
                id = Buttonns.Count;
                vertex = 0;
                conntect[0].X = 0;
                conntect[0].Y = 0;
                conntect[1].X = 0;
                conntect[1].Y = 0;
               // PictureBox pictureBox1 = new PictureBox();
                MakeConnectionsAfterOpen();
            }
        }
        private void ExampleBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\Users\gabis\source\repos\AISTT\AISTT\bin\Debug\exmpl";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Text = FileManager.GetFile(dlg.FileName);
                mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
                id = Buttonns.Count;
                vertex = 0;
                conntect[0].X = 0;
                conntect[0].Y = 0;
                conntect[1].X = 0;
                conntect[1].Y = 0;
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
