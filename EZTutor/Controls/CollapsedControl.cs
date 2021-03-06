﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZTutor.Controls
{
    public partial class CollapsedControl : UserControl
    {
        public CollapsedControl()
        {
            InitializeComponent();
        }

        public void Collapse()
        {
            while (Height > 0)
            {
                Height -= 3;
            }
        }

        public void Expand(int height)
        {
            while (Height < height)
            {
                Height += 3;
            }
        }
    }
}
