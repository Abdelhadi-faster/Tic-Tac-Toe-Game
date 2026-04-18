namespace exercise_picturebox
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(39, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Ivory;
            this.lblTurn.Location = new System.Drawing.Point(41, 207);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(103, 34);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Player  1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(36, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinner.Location = new System.Drawing.Point(36, 291);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(139, 46);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(36, 329);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(108, 41);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(262, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tic-Tac-Toe  Game";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::exercise_picturebox.Properties.Resources.Tic_Tac_Toe;
            this.pictureBox1.Location = new System.Drawing.Point(44, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(518, 58);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(101, 89);
            this.btn3.TabIndex = 9;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(240, 259);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(103, 89);
            this.btn7.TabIndex = 13;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(518, 259);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(101, 89);
            this.btn9.TabIndex = 15;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(381, 255);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(99, 93);
            this.btn8.TabIndex = 14;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(518, 161);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(101, 86);
            this.btn6.TabIndex = 12;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(373, 161);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(107, 82);
            this.btn5.TabIndex = 11;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(240, 161);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 86);
            this.btn4.TabIndex = 10;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(240, 58);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 89);
            this.btn1.TabIndex = 7;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(373, 58);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(107, 89);
            this.btn2.TabIndex = 8;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe  Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

