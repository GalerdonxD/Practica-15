﻿namespace Practica_15
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            sueldo = new TextBox();
            Nsueldo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(294, 156);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo\r\nde un trabajador, el programa\r\naplica un aumento del 15% si\r\nel sueldo es inferior a 400,000\r\ny si es mayor se le aplicara un\r\naumento del 8%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 226);
            label2.Name = "label2";
            label2.Size = new Size(157, 26);
            label2.TabIndex = 1;
            label2.Text = "Ingresar sueldo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 347);
            label3.Name = "label3";
            label3.Size = new Size(140, 26);
            label3.TabIndex = 2;
            label3.Text = "Nuevo sueldo";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(51, 280);
            button1.Name = "button1";
            button1.Size = new Size(119, 39);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(212, 280);
            button2.Name = "button2";
            button2.Size = new Size(119, 39);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // sueldo
            // 
            sueldo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sueldo.Location = new Point(219, 223);
            sueldo.Name = "sueldo";
            sueldo.Size = new Size(114, 33);
            sueldo.TabIndex = 5;
            // 
            // Nsueldo
            // 
            Nsueldo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nsueldo.Location = new Point(219, 344);
            Nsueldo.Name = "Nsueldo";
            Nsueldo.Size = new Size(114, 33);
            Nsueldo.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 410);
            Controls.Add(Nsueldo);
            Controls.Add(sueldo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Practica 15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox sueldo;
        private TextBox Nsueldo;
    }
}