using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSimulatorApp
{
    public partial class Form1 : Form
    {

        public const int SIZE_BUTTON = 25;

        public const int SIZE_GRID = 20;

        public const int MARGE = 50;

        private TrainSimulatorMgr mgr;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(MARGE + SIZE_GRID * SIZE_BUTTON, 2 * MARGE + SIZE_GRID * SIZE_BUTTON);
            RailButton[,] grid = new RailButton[SIZE_GRID, SIZE_GRID];

            for (int i = 0; i < SIZE_GRID; i++)
            { 
                for (int j = 0; j < SIZE_GRID; j++)
                {
                    RailButton newButton = new RailButton(i, j);
                    newButton.Size = new Size(SIZE_BUTTON, SIZE_BUTTON);
                    newButton.Location = new Point(i * SIZE_BUTTON, MARGE + j * SIZE_BUTTON);
                    newButton.Click += new EventHandler(railButton_Click);
                    grid[i, j] = newButton;
                    this.Controls.Add(newButton);
                }
            }
            mgr = new TrainSimulatorMgr(grid);

            // init railways
            grid[1, 1].Text = "r";
            grid[2, 1].Text = "-";
            grid[3, 1].Text = "-";
            grid[4, 1].Text = "-";
            grid[5, 1].Text = "-";
            grid[6, 1].Text = "-";
            grid[7, 1].Text = "-";
            grid[8, 1].Text = "-";
            grid[9, 1].Text = "¬";
            grid[9, 2].Text = "|";
            grid[9, 3].Text = "|";
            grid[9, 4].Text = "|";
            grid[9, 5].Text = "|";
            grid[9, 6].Text = "|";
            grid[9, 7].Text = "j";
            grid[8, 7].Text = "-";
            grid[7, 7].Text = "-";
            grid[6, 7].Text = "-";
            grid[5, 7].Text = "-";
            grid[4, 7].Text = "-";
            grid[3, 7].Text = "-";
            grid[2, 7].Text = "-";
            grid[1, 7].Text = "˪";
            grid[1, 6].Text = "|";
            grid[1, 5].Text = "|";
            grid[1, 4].Text = "|";
            grid[1, 3].Text = "|";
            grid[1, 2].Text = "|";

            grid[5, 5].Text = "r";
            grid[6, 5].Text = "-";
            grid[7, 5].Text = "-";
            grid[8, 5].Text = "-";
            grid[9, 5].Text = "+";
            grid[10, 5].Text = "-";
            grid[11, 5].Text = "-";
            grid[12, 5].Text = "¬";
            grid[12, 6].Text = "|";
            grid[12, 7].Text = "|";
            grid[12, 8].Text = "|";
            grid[12, 9].Text = "|";
            grid[12, 10].Text = "|";
            grid[12, 11].Text = "|";
            grid[12, 12].Text = "j";
            grid[11, 12].Text = "-";
            grid[10, 12].Text = "-";
            grid[9, 12].Text = "-";
            grid[8, 12].Text = "-";
            grid[7, 12].Text = "-";
            grid[6, 12].Text = "-";
            grid[5, 12].Text = "˪";
            grid[5, 11].Text = "|";
            grid[5, 10].Text = "|";
            grid[5, 9].Text = "|";
            grid[5, 8].Text = "|";
            grid[5, 7].Text = "+";
            grid[5, 6].Text = "|";

        }

        private void railButton_Click(object sender, EventArgs e)
        {
            RailButton btn = (RailButton) sender;
            btn.Text = btn.Text != "" ? "" : railComboBox.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            mgr.addTrain(new Train(new Point(1, 1), "SE", 8, 10, Color.Aqua));
            mgr.addTrain(new Train(new Point(5, 5), "NW", 8, 5, Color.Red));

            mgr.ProcessTasksAsync();
            //timer1.Enabled = true;
            btnPausePlay.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //mgr.addTime(timer1.Interval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = !timer1.Enabled;
        }
    }
}
