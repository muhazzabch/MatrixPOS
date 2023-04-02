using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;

namespace MatrixPOS
{
    public partial class Form1 : Form
    {
        //Fields
        private int borderSize = 3;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            OpenChildForm(new Forms.FormDashboard(),null);

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 220;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //Higlight button code ...
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

           // panelDesktopPane.Controls.Clear();
            panelDesktopPane.Controls.Add(childForm);
            //panelDesktopPane.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders(), sender);
        }
     
        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReports(), sender);

        }

        private void panelDesktopPane_Resize(object sender, EventArgs e)
        {
            if(activeForm != null)
            activeForm.Size = panelDesktopPane.Size;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelDesktopPane.Size = this.ClientSize;
        }
    }
}
