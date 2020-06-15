
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






        /// <summary>
        /// Рисует связь
        /// </summary>
        /// <param name="colorId">содержит цвет выбранной связи</param>
        /// <param name="colors">Хранит весь список цветов возможных связей </param>
        /// <param name="idForConnection">id связываемых вершин</param> 
        /// <param name="conntect">выбор вершин для соединения</param>
        
        Point[] conntect = new Point[2];
        Pair<int, int> idForConnection = new Pair<int, int>(0, 0);
        Color[] colors = new Color[5] { Color.LightGreen, Color.Red, Color.Blue, Color.Black, Color.Yellow };
        private void drawer(int colorId)
        {
            if (conntect[0].X == 0 && conntect[0].Y == 0 || conntect[1].X == 0 && conntect[1].Y == 0)
                return;
            MakeConntection(Buttonns, idForConnection.First, idForConnection.Second, colorId);
            Graphics gr = pictureBox1.CreateGraphics();
            Pen p = new Pen(colors[colorId], 3);// цвет линии и ширина
            gr.DrawLine(p, conntect[0], conntect[1]);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        }


        /// <summary>
        /// Отвечает за тип связи между выбранными вершинам
        /// </summary>
        /// <param name="sender">Выбранная кнопка связи</param>
        /// <param name="e">Нажатие </param>
        private void Connect_Click(object sender, EventArgs e)
        {
            Button bossYaUstal = sender as Button;
            string[] buttonsNames = new string[5] { "HPButton" , "IsAButton", "AKOButton", "DescButton", "Value" };
            for (int i = 0; i < 5; i++)
            {
                if(bossYaUstal.Name == buttonsNames[i])
                {
                    drawer(i);
                }
            }
        }
        /// <summary>
        /// Создание связей
        /// </summary>
        /// <param name="Buttons"> список вершины </param>
        /// <param name="idIn"> айди первой вершины соединения</param>
        /// <param name="idOut">айди второй </param>
        /// <param name="valueOfConnection">типо соединения</param>
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



        /// <summary>
        /// считывание нажатий на кнопки
        /// </summary>
        /// <param name="vertex">отвечает за счетчик вершин(чтобы не было ошибки)</param>
        int vertex = 0;
        public void FieldClick(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button.BackColor == Color.Red)
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
            else if (vertex < 2)
            {
                vertex++;
                if (conntect[0].X == 0 && conntect[0].Y == 0)
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
                makeNewVertex(Buttonns[i].Text, Buttonns[i].position,  false);
            }
            for (int i = 0; i < Buttonns.Count; i++)
            {
                for (int j = 0; j < Buttonns[i].connections.Count; j++)
                {
                    conntect1[0].X = Buttonns[i].position.X; 
                    conntect1[0].Y = Buttonns[i].position.Y;
                    conntect1[1].X = Buttonns[Buttonns[i].connections[j].First - 1].position.X;
                    conntect1[1].Y = Buttonns[Buttonns[i].connections[j].First - 1].position.Y;
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
        int id = 0;
        List<Button> vertexes = new List<Button>();
        /// <summary>
        /// Создание вершин сети, после перетаскивания текста из mainTextBox в редактор карт
        /// </summary>
        /// <param name="id">Отвечает за id вершины</param>
        /// <param name="vertexes">хранит в себе все вершины</param>
        /// <param name="e">Хранит в себе текст который должен содержаться в вершине</param>
        /// <param name="position">Храните координаты кнопки</param>
        /// <param name="width">Ширина кнопки</param>
        /// <param name="hight">Высота кнопки</param>
        /// <param name="need">Проверка нужно ли сериализировать данную вершину</param>
        public void makeNewVertex(string e, Point position, bool need)
        {

            // Point position = Cursor.Position;
            id++;
            Button temp = new Button();
            temp.Name = id.ToString();
            //int hight = Convert.ToInt32(temp.Font.Size * 1);
            //int weight = Convert.ToInt32(temp.Font.Size * e.Length + temp.Font.Size);
            temp.Text = e;
            // temp.Size = size;
            temp.AutoSize = true;
            temp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            temp.Location = position;
            //убрали обводку
            temp.BackColor = Color.LightGray;
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = FlatStyle.Flat;
            //Добавляем элемент на форму
            temp.Click += new EventHandler(FieldClick);
            mapPanel.Controls.Add(temp);    
            temp.BringToFront();
            vertexes.Add(temp);
            //в список его для дальнейшей сериализации
            if (need)
                Buttonns.Add(new Buttonn(temp.Name, temp.Text, position, id, new List<Pair<int, int>>(), new Pair<int, int>(temp.Width, temp.Height)));
        }


        #endregion  

        #region DragAndDrop
        /// <summary>
        /// Оба эти методы отвечают за перетаскивание текста из области текстового редкатора в область редактора карт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapPanel_DragDrop(object sender, DragEventArgs e)
        {
            makeNewVertex(e.Data.GetData(DataFormats.Text).ToString(), new Point(Cursor.Position.X - splitContainer1.Panel1.Width, Cursor.Position.Y - 70), true);
        }
        private void mapPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        #endregion

        #region save and open files
        static string filePath { get; set; }

        /// <summary>
        /// При закрытие предлагает пользователю сохранить проект
        /// </summary>
        /// <param name="sender">выбранный пункт подменю</param>
        /// <param name="e">нажатие</param>
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainTextBox.Text != "")
            {
                if (MessageBox.Show("Вы хотите сохранить изменения?", "AIST", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        }
        /// <summary>
        /// Создает новый файл 
        /// </summary>
        /// <param name="sender">выбранный пункт подменю</param>
        /// <param name="e">нажатие</param>
        private void newFileM_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "")
            {

                if (MessageBox.Show("Вы хотите сохранить изменения?", "AIST", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            Buttonns.Clear();
            Clearer();
        }


        /// <summary>
        /// Отвечает за открытие файла
        /// </summary>
        /// <param name="sender">выбранный пункт подменю</param>
        /// <param name="e">нажатие</param>
        private void openFileM_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                Clearer();
                mainTextBox.Text = FileManager.GetFile(dlg.SelectedPath, ref Buttonns);
                mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);   
                filePath = dlg.SelectedPath;
                MakeConnectionsAfterOpen();
            }
        }
        /// <summary>
        /// Открывает диалоговое окно с готовыми примерами текстов
        /// </summary>
        /// <param name="sender">выбранный пункт подменю</param>
        /// <param name="e">нажатие</param>
        private void ExampleBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory =  Directory.GetCurrentDirectory()+ @"\exmpl";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Clearer();
                mainTextBox.Text = FileManager.GetFile(dlg.FileName);
                mainTextBox.Font = new Font(mainTextBox.Font.ToString(), (float)fontNum.Value, FontStyle.Regular);
                
            }
        }
        /// <summary>
        /// Отвечает за сохранение в относительную папку(если конечно она есть)
        /// </summary>
        /// <param name="sender">выбранный пункт подменю</param>
        /// <param name="e">нажатие</param>
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
        /// <summary>
        /// Отвечает за сохрания типа как 
        /// </summary>
        /// <param name="sender">выбранный пункт подменю</param>
        /// <param name="e">нажатие</param>
        private void saveAsFilem_Click(object sender, EventArgs e)
        {
            FileManager.SaveFileAs(mainTextBox.Text, Buttonns);
        }
       

        /// <summary>
        /// Очищает все рабочее пространство от созданных элементов
        /// </summary>
        void Clearer()
        {

            filePath = null;
            mainTextBox.Clear();
            conntect[0].X = 0;
            conntect[0].Y = 0;
            conntect[1].X = 0;
            conntect[1].Y = 0;
            vertex = 0;
            pictureBox1.Image = null;
            for (int i = 0; i < vertexes.Count; i++)
            {
                mapPanel.Controls.Remove(vertexes[i]);
            }
            vertexes.Clear();
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
