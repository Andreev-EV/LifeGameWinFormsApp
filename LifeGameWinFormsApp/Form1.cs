using System;

namespace LifeGameWinFormsApp
{
    public partial class Form1 : Form
    {
        private Graphics? gr;
        private bool[,] field;
        private int rows, cols, resolution, curGen;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if(timer.Enabled) 
                return; 
            curGen= 0;
            Text = $"Игра \"Жизнь\" Поколение {curGen}";
            tB_resolution.Enabled = false;
            tbDensity.Enabled = false;
            resolution = tB_resolution.Value;
            rows = pictureBox1.Height/resolution;
            cols = pictureBox1.Width/resolution;
            field = new bool[cols , rows];
            Random random= new ();
            for (int x = 0; x < cols; x++) 
            {
                for(int y = 0; y < rows; y++) 
                    field[x, y] = random.Next(tbDensity.Value) == 0;
            }
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(pictureBox1.Image);
            timer.Start();

        }
        private void StopGame()
        {
            if(!timer.Enabled) return;
            timer.Stop();
            tB_resolution.Enabled = true;
            tbDensity.Enabled = true;
        }
        private void NextGeneration()
        {
            gr.Clear(Color.Black);
            var newField = new bool[cols , rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];
                    if (!hasLife && neighboursCount == 3) 
                        newField[x, y] = true;  
                    else if(hasLife && (neighboursCount < 2|| neighboursCount >3))
                        newField[x, y] = false;
                    else 
                        newField[x, y] = field[x, y];
                    if (hasLife)
                        gr.FillEllipse(Brushes.Green, x * resolution, y* resolution, resolution - 1, resolution -1);
                }
            }
            Text = $"Игра \"Жизнь\" Поколение {++curGen}";

            field = newField;
            pictureBox1.Refresh();
        }
        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    // если это крайняя ячейка смотрим с другой стороны поля
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    // проверяем что текущая ячейка равна меня
                    var isMe = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !isMe)
                        count++;
                }
            }
            return count;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
        private void tB_resolution_ValueChanged(object sender, EventArgs e)
        {
            lblResCur.Text = tB_resolution.Value.ToString();
        }

        private void tbDensity_ValueChanged(object sender, EventArgs e)
        {
            lblDisCur.Text = tbDensity.Value.ToString();
        }
    }
}