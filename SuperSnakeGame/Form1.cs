using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrickBreaker.Screens;
using System.Media;
//Carter Bott

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        // add a global value here
        // add a new comment

        //test comment

        //sound library
        public static SoundPlayer appearPlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.Alert_Appear);
        public static SoundPlayer disappearPlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.Alert_Dissappear);
        public static SoundPlayer errorPlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.Alert_Error);
        public static SoundPlayer back_A_Player = new SoundPlayer(SuperSnakeGame.Properties.Resources.Back_A);
        public static SoundPlayer select_A_Player = new SoundPlayer(SuperSnakeGame.Properties.Resources.Select_A);
        public static SoundPlayer back_B_Player = new SoundPlayer(SuperSnakeGame.Properties.Resources.Back_B);
        public static SoundPlayer select_B_Player = new SoundPlayer(SuperSnakeGame.Properties.Resources.Select_B);
        public static SoundPlayer brickPlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.brickBounce);
        public static SoundPlayer paddlePlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.paddleBounce);
        public static SoundPlayer wallPlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.wallBounce);
        public static SoundPlayer pickPlayer = new SoundPlayer(SuperSnakeGame.Properties.Resources.Pick);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ps = new MenuScreen();
            this.Controls.Add(ps);

            ps.Location = new Point((this.Width - ps.Width) / 2, (this.Height - ps.Height) /2);
        }
    }
}
