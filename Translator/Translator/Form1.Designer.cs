using System.Windows.Forms;
using System.Drawing;


namespace Translator
{
    partial class Form1
    {

        private System.Windows.Forms.Label label1;
        private Button btn_right;
        private Button btn_wrong;
        private Button btn_refresh;
        private Label lbl_left;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new Label();
            this.btn_right = new Button();
            this.btn_wrong = new Button();
            this.btn_refresh = new Button();
            this.lbl_left = new Label();
            this.SuspendLayout();
            this.label1.Font = new Font("宋体", 48f, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.label1.Location = new Point(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(600, 200);
            this.label1.TabIndex = 0;
            this.label1.Text = "START";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.btn_right.Font = new Font("宋体", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)134);
            this.btn_right.ForeColor = Color.Lime;
            this.btn_right.Location = new Point(172, 294);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new Size(80, 30);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = "√";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            this.btn_wrong.Font = new Font("宋体", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)134);
            this.btn_wrong.ForeColor = Color.Red;
            this.btn_wrong.Location = new Point(737, 294);
            this.btn_wrong.Name = "btn_wrong";
            this.btn_wrong.Size = new Size(80, 30);
            this.btn_wrong.TabIndex = 2;
            this.btn_wrong.Text = "×";
            this.btn_wrong.UseVisualStyleBackColor = true;
            this.btn_wrong.Click += new System.EventHandler(this.btn_wrong_Click);
            this.btn_refresh.Font = new System.Drawing.Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.btn_refresh.ForeColor = SystemColors.ActiveCaptionText;
            this.btn_refresh.Location = new Point(892, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new Size(80, 30);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Restart";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            this.lbl_left.AutoSize = true;
            this.lbl_left.Font = new System.Drawing.Font("宋体", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)134);
            this.lbl_left.ForeColor = Color.Red;
            this.lbl_left.Location = new Point(2, 12);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new Size(0, 21);
            this.lbl_left.TabIndex = 4;
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add((Control)this.lbl_left);
            this.Controls.Add((Control)this.btn_refresh);
            this.Controls.Add((Control)this.btn_wrong);
            this.Controls.Add((Control)this.btn_right);
            this.Controls.Add((Control)this.label1);
            this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.Name = nameof(Form1);
            this.Text = "背单词";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    }
}

