
namespace SoftwareDevMethods
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.test1 = new System.Windows.Forms.Button();
            this.Test2 = new System.Windows.Forms.Button();
            this.testBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(139, 51);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(211, 80);
            this.test1.TabIndex = 1;
            this.test1.Text = "Test 1";
            this.test1.UseVisualStyleBackColor = true;
            this.test1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test2
            // 
            this.Test2.Location = new System.Drawing.Point(139, 162);
            this.Test2.Name = "Test2";
            this.Test2.Size = new System.Drawing.Size(211, 80);
            this.Test2.TabIndex = 2;
            this.Test2.Text = "Test2";
            this.Test2.UseVisualStyleBackColor = true;
            this.Test2.Click += new System.EventHandler(this.button2_Click);
            // 
            // testBox1
            // 
            this.testBox1.Location = new System.Drawing.Point(139, 280);
            this.testBox1.Multiline = true;
            this.testBox1.Name = "testBox1";
            this.testBox1.PlaceholderText = "Test1";
            this.testBox1.Size = new System.Drawing.Size(433, 140);
            this.testBox1.TabIndex = 3;
            this.testBox1.Text = "Text 1";
            this.testBox1.Visible = false;
            this.testBox1.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 280);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 140);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Test2";
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.testBox1);
            this.Controls.Add(this.Test2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button test1;
        private System.Windows.Forms.Button Test2;
        private System.Windows.Forms.TextBox testBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

