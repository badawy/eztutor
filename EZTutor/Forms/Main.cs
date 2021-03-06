using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EZTutor.Arguments;
using EZTutor.Controls.Admin;
using EZTutor.Controls.Browsers;
using EZTutor.Controls.Menus;
using EZTutor.Enums;

namespace EZTutor.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(SecurityArgs args) : this()
        {
            UserType = args.UserType;
            UserName = args.UserName;
        }

        public string UserName { get; set; }

        public UserType UserType { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UserType == UserType.Student)
            {
                studentMenu1.Expand(263);
                studentMenu1.UserName = UserName;
                studentMenu1.MenuItemClicked = new StudentMenu.MenuItemClickedHandler(MenuClickedHandler);
                instructorMenu1.Collapse();
            }
            else
            {
                instructorMenu1.Expand(263);
                instructorMenu1.UserName = UserName;
                studentMenu1.MenuItemClicked = new StudentMenu.MenuItemClickedHandler(MenuClickedHandler);
                studentMenu1.Collapse();
            }
        }

        private void MenuClickedHandler(object sender, MenuArgs args)
        {
            switch (args.FormType)
            {
                case FormType.Home:
                    MainBrowser browser = new MainBrowser();
                    contentPanel.Controls.Add(browser);
                    break;
                case FormType.Profile:
                    Profile profile = new Profile();
                    contentPanel.Controls.Add(profile);
                    break;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show(this);
        }
    }
}