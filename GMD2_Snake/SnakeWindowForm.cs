﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMD2_Snake
{
    public partial class SnakeWindowForm : Form
    {
        public SnakeWindowForm()
        {
            InitializeComponent();
        }

        private void SnakeWindow_Load(object sender, EventArgs e)
        {

        }

        public void GameLoop()
        {
            TimeSpan MS_PER_FRAME = TimeSpan.FromMilliseconds(1.0 / 60.0 * 1000.0);
            Stopwatch stopWatch = Stopwatch.StartNew();
            TimeSpan previous = stopWatch.Elapsed;
            TimeSpan lag = new TimeSpan(0);
            while (true)
            {
                TimeSpan current = stopWatch.Elapsed;
                TimeSpan elapsed = current - previous;
                previous = current;
                lag += elapsed;

                //Process input
                while (lag >= MS_PER_FRAME)
                {
                    //Update (Game Logic)
                    lag -= MS_PER_FRAME;
                }
                //render
                test_textBox.Text = "HELLO"+DateTime.Now.ToString();
                Refresh();
            }
        }

        private void test_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
