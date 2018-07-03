using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man
{
    public partial class Form1 : Form
    {
        Data data = new Data();
        Dictionary<Player, int> top = Data.Load_Data();
        Random r = new Random();
        Random r2 = new Random();
        Player player = new Player();

        int score = 0;

        int direction;
        bool up;
        bool down;
        bool left;
        bool right;

        int speed = 0;
        int red_speed = 0;
        int pink_speed = 0;

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            TopScores.Visible = false;
            starting_panel.Visible = true;
            starting_panel.Location = new Point(0, 0);
            cherry.Location = new Point(r.Next(300), r2.Next(500));
            esa_wea.Location = new Point(r.Next(300), r2.Next(500));
            pink_ghost.Location = new Point(r.Next(300), r2.Next(500));
            red_ghost.Location = new Point(r.Next(300), r2.Next(500));
        }

        bool IntersectsFruit()
        {
            if (pacman.Bounds.IntersectsWith(cherry.Bounds))
            {
                score += 10;
                cherry.Location = new Point(r.Next(300), r2.Next(500));
                return true;
            }
            else if (pacman.Bounds.IntersectsWith(esa_wea.Bounds))
            {
                score += 15;
                esa_wea.Location = new Point(r.Next(300), r2.Next(500));
                return true;
            }
            return false;
        }
        bool IntersectsGhost()
        {
            if (pacman.Bounds.IntersectsWith(red_ghost.Bounds) || pacman.Bounds.IntersectsWith(pink_ghost.Bounds))
            {
                if (top.Keys.Contains(player))
                {
                    timer1.Stop();
                    top.Remove(player);
                    player.score = score;
                    top.Add(player, score);
                    Data.Save_Data(top);
                    Game_Over.Visible = true;
                    restart.Visible = true;
                    MessageBox.Show("Obtained Score: " + score , "Game Over");
                    return true;
                }
                else
                {
                    timer1.Stop();
                    player.score = score;
                    top.Add(player, score);
                    Data.Save_Data(top);
                    Game_Over.Visible = true;
                    restart.Visible = true;
                    MessageBox.Show("Obtained Score: " + score, "Game Over");
                    return true;
                }
            }
            return false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            string player1 = name_textbox.Text;
            player = new Player(player1, 0, data.scores.Keys.Count());
            label_name.Text = player1 + " Score: ";
            label_name.Location = new Point(786, 12);
            starting_panel.Visible = false;
            speed += 8;
            pacman.Left += speed;
            pink_speed += 8;
            red_speed += 8;
            
        }

        private void key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                pacman.Image = Properties.Resources.pacman_right;
                direction = 1;

            }
            else if (e.KeyCode == Keys.Left)
            {
                left = true;
                pacman.Image = Properties.Resources.pacman_left;
                direction = 3;

            }
            else if (e.KeyCode == Keys.Down)
            {
                down = true;
                pacman.Image = Properties.Resources.pacman_down;
                direction = 2;

            }
            else if (e.KeyCode == Keys.Up)
            {
                up = true;
                pacman.Image = Properties.Resources.pacman_up;
                direction = 4;
            }
        }

        private void key_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IntersectsFruit())
            {
                label_name.Text = player.name + " Score: " + score;

            }
            else if (IntersectsGhost())
            {
                timer1.Stop();
            }
            label_name.Text = player.name + " Score: " + score;
            counter++;
            red_ghost.Top += red_speed;
            pink_ghost.Left -= pink_speed;
            bool intersect = pacman.Bounds.IntersectsWith(pictureBox1.Bounds)|| pacman.Bounds.IntersectsWith(pictureBox2.Bounds) || pacman.Bounds.IntersectsWith(pictureBox3.Bounds) || pacman.Bounds.IntersectsWith(pictureBox4.Bounds);

            //movimientos de fantasmas y posiciones de las frutas
            if (counter%100 == 0)
            {
                cherry.Location = new Point(r.Next(500), r2.Next(500));
                esa_wea.Location = new Point(r.Next(500), r2.Next(500));
            }
            else if(counter%10 == 0 && r2.Next(20) < 10)
            {
                red_ghost.Left += red_speed;
                pink_ghost.Top -= pink_speed;
            }
            else if (counter % 10 == 0 && r2.Next(20) > 10)
            {
                red_ghost.Left -= red_speed;
                pink_ghost.Top += pink_speed;
            }


            //movimientos del pacman
            if (up)
            {
                pacman.Top -= speed;
            }
            else if (down)
            {
                pacman.Top += speed;
            }
            else if (left)
            {
                pacman.Left -= speed;
            }
            else if (right)
            {
                pacman.Left += speed;
            }


            if (red_ghost.Bounds.IntersectsWith(pictureBox1.Bounds) 
                || red_ghost.Bounds.IntersectsWith(pictureBox2.Bounds) 
                || red_ghost.Bounds.IntersectsWith(pictureBox3.Bounds) 
                || red_ghost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                red_speed = -red_speed;
            }
            else if (pink_ghost.Bounds.IntersectsWith(pictureBox1.Bounds)
                || pink_ghost.Bounds.IntersectsWith(pictureBox2.Bounds) 
                || pink_ghost.Bounds.IntersectsWith(pictureBox3.Bounds) 
                || pink_ghost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pink_speed = -pink_speed;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopScores.Visible = true;
            Dictionary<Player, int> algo = Data.Load_Data();
            int i = 0;
            foreach (Player item in algo.Keys)
            {
                label_scores.Text += item.Info();
                label_scores.Text += Environment.NewLine;
                if (i==10)
                {
                    break;
                }
                i++;

            }
            
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
