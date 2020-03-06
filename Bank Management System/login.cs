using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;
using MetroFramework.Native;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Bank_Management_System
{
    public partial class login : Form
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


        public login()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            
        }



        private void BtnLogin_Click(object sender, EventArgs e)
        {


            //Instance of Connect Class
            Connect startConnection = new Connect();
            startConnection.con.ConnectionString = startConnection.locate;

            //Starts connection
            startConnection.con.Open();

            //Stores credentials into variable query
            string query = "select * from LoginTbl where Username = '" + TxtUsername.Text + "' and Password = '" + TxtPassword.Text + "'";


            SqlCommand cmd = new SqlCommand(query, startConnection.con);
            DataTable dtbl = new DataTable();

            //Declare dr as an instance of the SqlDataReader
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows == true)
            {
                MessageBox.Show("Login successful...");
                this.Hide();
                Main ss = new Main();
                ss.Show();
                startConnection.con.Close();
            }
            else
            {
                MessageBox.Show("Login Failed, Invalid Credentials...");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }


        int mov;
        int movX;
        int movY;

        private void login_Load(object sender, EventArgs e)
        {
            TxtUsername.Focus();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_mouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Panel3_mouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel3_mouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }
    }
}
