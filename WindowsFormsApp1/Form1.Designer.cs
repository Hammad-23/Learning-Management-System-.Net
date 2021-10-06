
namespace WindowsFormsApp1
{
    partial class Form1
    {
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
            this.labelstdName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelstdId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelstdLogin = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelstdName
            // 
            this.labelstdName.AutoSize = true;
            this.labelstdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstdName.Location = new System.Drawing.Point(423, 199);
            this.labelstdName.Name = "labelstdName";
            this.labelstdName.Size = new System.Drawing.Size(143, 25);
            this.labelstdName.TabIndex = 0;
            this.labelstdName.Text = "Student Name:";
            this.labelstdName.Click += new System.EventHandler(this.labelstdName_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 26);
            this.textBox1.TabIndex = 1;
            // 
            // labelstdId
            // 
            this.labelstdId.AutoSize = true;
            this.labelstdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstdId.Location = new System.Drawing.Point(459, 278);
            this.labelstdId.Name = "labelstdId";
            this.labelstdId.Size = new System.Drawing.Size(107, 25);
            this.labelstdId.TabIndex = 2;
            this.labelstdId.Text = "Student Id:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(585, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 26);
            this.textBox2.TabIndex = 3;
            // 
            // labelstdLogin
            // 
            this.labelstdLogin.AutoSize = true;
            this.labelstdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstdLogin.Location = new System.Drawing.Point(578, 48);
            this.labelstdLogin.Name = "labelstdLogin";
            this.labelstdLogin.Size = new System.Drawing.Size(216, 37);
            this.labelstdLogin.TabIndex = 4;
            this.labelstdLogin.Text = "Student LogIn";
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(634, 411);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(160, 43);
            this.buttonlogin.TabIndex = 5;
            this.buttonlogin.Text = "Log In";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 612);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.labelstdLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelstdId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelstdName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstdName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelstdId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelstdLogin;
        private System.Windows.Forms.Button buttonlogin;
    }
}

