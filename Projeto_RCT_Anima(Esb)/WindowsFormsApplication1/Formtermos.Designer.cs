﻿namespace WindowsFormsApplication1
{
    partial class Formtermos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtermos));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btfechar
            // 
            this.btfechar.Location = new System.Drawing.Point(236, 313);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(75, 23);
            this.btfechar.TabIndex = 1;
            this.btfechar.Text = "Fechar";
            this.btfechar.UseVisualStyleBackColor = true;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // Formtermos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 348);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Formtermos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formtermos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formtermos_FormClosed);
            this.Load += new System.EventHandler(this.Formtermos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btfechar;
    }
}