﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEATSINK_VISION
{
    public partial class formToolSetting : Form
    {
        private Global Glob;
        public formToolSetting()
        {
            InitializeComponent();
            Glob = Global.getInstance; //전역변수 사용
        }
    }
}
