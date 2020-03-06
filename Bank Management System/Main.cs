using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Bank_Management_System
{
    public partial class Main : Form
    {

        //  for round-corner form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int WidthEllipse,
                int nHeightEllipse
            );


        int mov;
        int movX;
        int movY;

        public Main()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login back = new login();
            back.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sidebar.Visible)
            {
                sidebar.Hide();
            }
            else
            {
                sidebar.Show();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void dashBoard11_Load(object sender, EventArgs e)
        {
           
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashBoard11.Visible)
            {
                 dashBoard11.Hide();
            }
            else
            {
                dashBoard11.Show();
            }
        }

        public void dashBoard12_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sidebar.Visible)
            {
                sidebar.Hide();
            }
            else
            {
                sidebar.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculator instant = new calculator();
            if (instant.Visible)
            {
                instant.Hide();
            }
            else
            {
                instant.Show();
            }
            
        }

      
    }
    }
