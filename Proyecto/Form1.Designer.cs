namespace Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.piso_01 = new System.Windows.Forms.TabPage();
            this.piso_2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.piso_01.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.piso_01);
            this.tabControl1.Controls.Add(this.piso_2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // piso_01
            // 
            this.piso_01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piso_01.BackgroundImage")));
            this.piso_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.piso_01.Controls.Add(this.button1);
            this.piso_01.Location = new System.Drawing.Point(4, 22);
            this.piso_01.Name = "piso_01";
            this.piso_01.Padding = new System.Windows.Forms.Padding(3);
            this.piso_01.Size = new System.Drawing.Size(609, 611);
            this.piso_01.TabIndex = 0;
            this.piso_01.Text = "Primer Piso";
            this.piso_01.UseVisualStyleBackColor = true;
            // 
            // piso_2
            // 
            this.piso_2.Location = new System.Drawing.Point(4, 22);
            this.piso_2.Name = "piso_2";
            this.piso_2.Padding = new System.Windows.Forms.Padding(3);
            this.piso_2.Size = new System.Drawing.Size(815, 471);
            this.piso_2.TabIndex = 1;
            this.piso_2.Text = "Segundo Piso";
            this.piso_2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 89);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.piso_01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage piso_01;
        private System.Windows.Forms.TabPage piso_2;
        private System.Windows.Forms.Button button1;
    }
}

