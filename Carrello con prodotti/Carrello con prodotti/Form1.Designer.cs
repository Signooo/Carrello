﻿namespace Carrello_con_prodotti
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
            button1 = new Button();
            button2 = new Button();
            Carrello = new ListBox();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(454, 239);
            button1.Name = "button1";
            button1.Size = new Size(103, 59);
            button1.TabIndex = 0;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(634, 239);
            button2.Name = "button2";
            button2.Size = new Size(103, 59);
            button2.TabIndex = 1;
            button2.Text = "RIMUOVI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Carrello
            // 
            Carrello.FormattingEnabled = true;
            Carrello.ItemHeight = 15;
            Carrello.Location = new Point(900, 161);
            Carrello.Name = "Carrello";
            Carrello.Size = new Size(330, 214);
            Carrello.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(621, 123);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(537, 377);
            button3.Name = "button3";
            button3.Size = new Size(122, 65);
            button3.TabIndex = 6;
            button3.Text = "RIMUOVI TUTTO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 601);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(Carrello);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox Carrello;
        private Label label1;
        private Button button3;
    }
}
