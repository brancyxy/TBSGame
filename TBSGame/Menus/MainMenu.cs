﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame.Menus
{
    public partial class MainMenu : Form
    {
        public MainMenu(SizeF scale, bool useFullScreen)
        {
            InitializeComponent();
            if (useFullScreen) WindowState = FormWindowState.Maximized;
            Scale(scale);
        }

        //make the top area move the window if in window mode
        private bool mouseDown;
        private Point lastLocation;
        private void TopField_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void TopField_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && this.WindowState != FormWindowState.Maximized)
            {
                this.Location = new Point(
                                (this.Location.X - lastLocation.X) + e.X, 
                                (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void TopField_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}