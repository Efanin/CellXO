﻿namespace WinFormsApp5
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            labelWin = new Label();
            labelStep = new Label();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(31, 68);
            button1.Name = "button1";
            button1.Size = new Size(90, 82);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22F);
            button2.Location = new Point(127, 68);
            button2.Name = "button2";
            button2.Size = new Size(90, 82);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 22F);
            button3.Location = new Point(223, 68);
            button3.Name = "button3";
            button3.Size = new Size(90, 82);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 22F);
            button4.Location = new Point(31, 156);
            button4.Name = "button4";
            button4.Size = new Size(90, 82);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 22F);
            button5.Location = new Point(127, 156);
            button5.Name = "button5";
            button5.Size = new Size(90, 82);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 22F);
            button6.Location = new Point(223, 156);
            button6.Name = "button6";
            button6.Size = new Size(90, 82);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 22F);
            button7.Location = new Point(31, 244);
            button7.Name = "button7";
            button7.Size = new Size(90, 82);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 22F);
            button8.Location = new Point(127, 244);
            button8.Name = "button8";
            button8.Size = new Size(90, 82);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 22F);
            button9.Location = new Point(223, 244);
            button9.Name = "button9";
            button9.Size = new Size(90, 82);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // labelWin
            // 
            labelWin.AutoSize = true;
            labelWin.Font = new Font("Segoe UI", 22F);
            labelWin.Location = new Point(223, 24);
            labelWin.Name = "labelWin";
            labelWin.Size = new Size(85, 41);
            labelWin.TabIndex = 1;
            labelWin.Text = "Win: ";
            // 
            // labelStep
            // 
            labelStep.AutoSize = true;
            labelStep.Font = new Font("Segoe UI", 22F);
            labelStep.Location = new Point(31, 24);
            labelStep.Name = "labelStep";
            labelStep.Size = new Size(92, 41);
            labelStep.TabIndex = 1;
            labelStep.Text = "Step: ";
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 22F);
            button10.Location = new Point(31, 408);
            button10.Name = "button10";
            button10.Size = new Size(282, 54);
            button10.TabIndex = 2;
            button10.Text = "RESTART";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 485);
            Controls.Add(button10);
            Controls.Add(labelStep);
            Controls.Add(labelWin);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label labelWin;
        private Label labelStep;
        private Button button10;
    }
}
