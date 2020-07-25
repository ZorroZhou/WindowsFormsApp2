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
    public partial class Form3 : Form
    {
        private string _name;
        private string _emailId;
        private string _subject;
        private string _feedBack;
        public Form3(string varName,string varEmail,string varSubject,string varfeedBack)
        {
            InitializeComponent();
            //在private变量中存储值
            this._name = varName;
            this._emailId = varEmail;
            this._subject = varSubject;
            this._feedBack = varfeedBack;
            //在列表框中 放置实例化后传来的参数值
            listBox1.Items.Add("姓名：" + this._name);
            listBox1.Items.Add("邮件地址：" + this._emailId);
            listBox1.Items.Add("信息主题:" + this._subject);
            listBox1.Items.Add("反馈意见:" + this._feedBack);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢您输入的反馈！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Close();
        }
    }
}
