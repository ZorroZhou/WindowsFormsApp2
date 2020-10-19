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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""||textBox2.Text=="")
            {
                MessageBox.Show("姓名或者邮件信息禁止为空！", "信息提示");
            }
            else
            {
                this.Hide();
                Form3 chidForm3 = new Form3(this.textBox1.Text, this.textBox2.Text, this.comboBox1.SelectedItem.ToString(), textBox3.Text);
                //实例化Form3窗体，利用 窗体参数 传输数据
                chidForm3.MdiParent = this.MdiParent;
                //使打开的窗体和当前的窗体指向同一个父窗体
                chidForm3.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("颜色反馈");
            this.comboBox1.Items.Add("操作反馈");
            this.comboBox1.Items.Add("体验反馈");
            this.comboBox1.SelectedIndex = 0;
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
