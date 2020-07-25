using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Form2 Mdichild = new Form2();//首先实例化Form2对象，命名为Mdichild
            Mdichild.MdiParent = this;
            //其次指定即将打开的Form2对象的MdiParent，即Form2对象的MDI父窗口为当前的主MDI窗口
            Mdichild.Show();//显示Form2的MDI父窗口
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
