using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        private string path = System.IO.Directory.GetCurrentDirectory() + "\\res\\";
        private System.Data.DataTable dt = new System.Data.DataTable();
        private System.Data.DataTable dtno = new System.Data.DataTable();
        private string forgetFile = "";

        public Form1()
        {
            this.InitializeComponent();
            this.dt.Columns.Add("name");
            this.dtno.Columns.Add("name");

            forgetFile = Path.Combine(path, "forget.txt");


            this.init_Data();


            if (this.dt.Rows.Count == 0)
            {
                int num = (int)MessageBox.Show("没数据！");
                Environment.Exit(1);
            }
            else
            {
                this.showWord();
            }
        }

        private void init_Data()
        {
            StreamReader streamReader = new StreamReader(this.path + "name.txt");
            string str;
            while ((str = streamReader.ReadLine()) != null)
            {
                DataRow row = this.dt.NewRow();
                row["name"] = (object)str;
                this.dt.Rows.Add(row);
            }
            this.lbl_left.Text = "还剩下" + this.dt.Rows.Count.ToString() + "个单词";
            OutputForgetFileSplitter();
        }

        private void showWord()
        {
            if (this.dt.Rows.Count == 0)
            {
                this.label1.Text = "END";
                this.lbl_left.Text = "还剩下0个单词";
            }
            else
            {
                this.label1.Text = this.dt.Rows[new Random().Next(this.dt.Rows.Count - 1)]["name"].ToString().Trim();
                this.lbl_left.Text = "还剩下" + this.dt.Rows.Count.ToString() + "个单词";
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "END")
                return;
            DataRow row = this.dtno.NewRow();
            row["name"] = (object)this.label1.Text;
            this.dtno.Rows.Add(row);
            for (int index = 0; index < this.dt.Rows.Count; ++index)
            {
                if (this.dt.Rows[index]["name"].ToString().Trim() == this.label1.Text)
                    this.dt.Rows.RemoveAt(index);
            }
            this.showWord();
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            OutputForgetFile(this.label1.Text);
            this.showWord();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.dt.Rows.Clear();
            this.init_Data();
            this.dtno.Rows.Clear();
            this.label1.Text = "START";
        }

        private void OutputForgetFileSplitter()
        {
            string dateTime = string.Format("====== {0} ======", DateTimeOffset.Now.ToString());
            OutputForgetFile(dateTime);
        }

        private void OutputForgetFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(forgetFile, true, Encoding.UTF8))
            {
                sw.WriteLine(message);
            }
        }
    }
}
