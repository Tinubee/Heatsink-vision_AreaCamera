using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimLib;

namespace HEATSINK_VISION
{
    public partial class formMain : Form
    {
        Log log = new Log();
        private Global Glob;
        public formMain()
        {
            InitializeComponent();
            Glob = Global.getInstance; //전역변수 사용
        }
    }
}
