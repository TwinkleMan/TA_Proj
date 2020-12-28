namespace TA_Proj
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
            this.player1label = new System.Windows.Forms.Label();
            this.player2label = new System.Windows.Forms.Label();
            this.player1throw = new System.Windows.Forms.Button();
            this.player2throw = new System.Windows.Forms.Button();
            this.Flushbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.score_text = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.res1_text = new System.Windows.Forms.Label();
            this.player1res_lbl = new System.Windows.Forms.Label();
            this.player2res_lbl = new System.Windows.Forms.Label();
            this.res2_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1label
            // 
            this.player1label.Location = new System.Drawing.Point(77, 175);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(59, 28);
            this.player1label.TabIndex = 0;
            this.player1label.Text = "Игрок 1";
            // 
            // player2label
            // 
            this.player2label.Location = new System.Drawing.Point(672, 175);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(59, 28);
            this.player2label.TabIndex = 1;
            this.player2label.Text = "Игрок 2";
            // 
            // player1throw
            // 
            this.player1throw.Location = new System.Drawing.Point(57, 206);
            this.player1throw.Name = "player1throw";
            this.player1throw.Size = new System.Drawing.Size(100, 42);
            this.player1throw.TabIndex = 2;
            this.player1throw.Text = "Бросок";
            this.player1throw.UseVisualStyleBackColor = true;
            this.player1throw.Click += new System.EventHandler(this.player1throw_Click);
            // 
            // player2throw
            // 
            this.player2throw.Location = new System.Drawing.Point(651, 206);
            this.player2throw.Name = "player2throw";
            this.player2throw.Size = new System.Drawing.Size(100, 42);
            this.player2throw.TabIndex = 3;
            this.player2throw.Text = "Бросок";
            this.player2throw.UseVisualStyleBackColor = true;
            this.player2throw.Click += new System.EventHandler(this.player2throw_Click_1);
            // 
            // Flushbtn
            // 
            this.Flushbtn.Location = new System.Drawing.Point(232, 356);
            this.Flushbtn.Name = "Flushbtn";
            this.Flushbtn.Size = new System.Drawing.Size(128, 69);
            this.Flushbtn.TabIndex = 4;
            this.Flushbtn.Text = "Сброс";
            this.Flushbtn.UseVisualStyleBackColor = true;
            this.Flushbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Flushbtn_MouseClick);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(429, 356);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(128, 69);
            this.nextbtn.TabIndex = 5;
            this.nextbtn.Text = "Следующий раунд";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // score_text
            // 
            this.score_text.Location = new System.Drawing.Point(356, 34);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(49, 29);
            this.score_text.TabIndex = 6;
            this.score_text.Text = "Счет:";
            // 
            // scorelbl
            // 
            this.scorelbl.Location = new System.Drawing.Point(399, 34);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(46, 29);
            this.scorelbl.TabIndex = 7;
            this.scorelbl.Text = "0 / 0";
            // 
            // res1_text
            // 
            this.res1_text.Location = new System.Drawing.Point(74, 267);
            this.res1_text.Name = "res1_text";
            this.res1_text.Size = new System.Drawing.Size(100, 24);
            this.res1_text.TabIndex = 8;
            this.res1_text.Text = "Выпало:";
            // 
            // player1res_lbl
            // 
            this.player1res_lbl.Location = new System.Drawing.Point(74, 291);
            this.player1res_lbl.Name = "player1res_lbl";
            this.player1res_lbl.Size = new System.Drawing.Size(61, 22);
            this.player1res_lbl.TabIndex = 9;
            // 
            // player2res_lbl
            // 
            this.player2res_lbl.Location = new System.Drawing.Point(670, 291);
            this.player2res_lbl.Name = "player2res_lbl";
            this.player2res_lbl.Size = new System.Drawing.Size(61, 22);
            this.player2res_lbl.TabIndex = 11;
            // 
            // res2_text
            // 
            this.res2_text.Location = new System.Drawing.Point(670, 267);
            this.res2_text.Name = "res2_text";
            this.res2_text.Size = new System.Drawing.Size(100, 24);
            this.res2_text.TabIndex = 10;
            this.res2_text.Text = "Выпало:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2res_lbl);
            this.Controls.Add(this.res2_text);
            this.Controls.Add(this.player1res_lbl);
            this.Controls.Add(this.res1_text);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.Flushbtn);
            this.Controls.Add(this.player2throw);
            this.Controls.Add(this.player1throw);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.player1label);
            this.Name = "Form1";
            this.Text = "Игра с двумя монетами";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label player2res_lbl;
        private System.Windows.Forms.Label res2_text;

        private System.Windows.Forms.Label player1res_lbl;

        private System.Windows.Forms.Label res1_text;

        private System.Windows.Forms.Label scorelbl;

        private System.Windows.Forms.Label score_text;

        private System.Windows.Forms.Button Flushbtn;
        private System.Windows.Forms.Button nextbtn;

        private System.Windows.Forms.Button player1throw;
        private System.Windows.Forms.Button player2throw;

        private System.Windows.Forms.Label player2label;

        private System.Windows.Forms.Label player1label;

        #endregion
    }
}