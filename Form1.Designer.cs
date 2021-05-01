
namespace Less07
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lableCounts = new System.Windows.Forms.Label();
            this.ClickSteps = new System.Windows.Forms.Label();
            this.ButPlay = new System.Windows.Forms.Button();
            this.ButExit = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LableComand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LableNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butMenu = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(18, 189);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(99, 189);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "х2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(218, 189);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumber.Location = new System.Drawing.Point(32, 140);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 15);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // lableCounts
            // 
            this.lableCounts.AutoSize = true;
            this.lableCounts.Location = new System.Drawing.Point(18, 244);
            this.lableCounts.Name = "lableCounts";
            this.lableCounts.Size = new System.Drawing.Size(67, 15);
            this.lableCounts.TabIndex = 4;
            this.lableCounts.Text = "Кол. Ходов";
            // 
            // ClickSteps
            // 
            this.ClickSteps.AutoSize = true;
            this.ClickSteps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClickSteps.Location = new System.Drawing.Point(99, 244);
            this.ClickSteps.Name = "ClickSteps";
            this.ClickSteps.Size = new System.Drawing.Size(13, 15);
            this.ClickSteps.TabIndex = 5;
            this.ClickSteps.Text = "0";
            // 
            // ButPlay
            // 
            this.ButPlay.Location = new System.Drawing.Point(79, 33);
            this.ButPlay.Name = "ButPlay";
            this.ButPlay.Size = new System.Drawing.Size(147, 109);
            this.ButPlay.TabIndex = 0;
            this.ButPlay.Text = "Играть";
            this.ButPlay.UseVisualStyleBackColor = true;
            this.ButPlay.Click += new System.EventHandler(this.ButPlay_Click);
            // 
            // ButExit
            // 
            this.ButExit.Location = new System.Drawing.Point(79, 180);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(147, 96);
            this.ButExit.TabIndex = 1;
            this.ButExit.Text = "Выход";
            this.ButExit.UseVisualStyleBackColor = true;
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.ButPlay);
            this.panelMenu.Controls.Add(this.ButExit);
            this.panelMenu.Location = new System.Drawing.Point(1, 9);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 300);
            this.panelMenu.TabIndex = 6;
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.butBack);
            this.panelGame.Controls.Add(this.lblNumber);
            this.panelGame.Controls.Add(this.groupBox1);
            this.panelGame.Controls.Add(this.butMenu);
            this.panelGame.Controls.Add(this.lableCounts);
            this.panelGame.Controls.Add(this.btnCommand1);
            this.panelGame.Controls.Add(this.btnCommand2);
            this.panelGame.Controls.Add(this.btnReset);
            this.panelGame.Controls.Add(this.ClickSteps);
            this.panelGame.Location = new System.Drawing.Point(307, 9);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(300, 300);
            this.panelGame.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LableComand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LableNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задача";
            // 
            // LableComand
            // 
            this.LableComand.AutoSize = true;
            this.LableComand.Location = new System.Drawing.Point(130, 84);
            this.LableComand.Name = "LableComand";
            this.LableComand.Size = new System.Drawing.Size(13, 15);
            this.LableComand.TabIndex = 3;
            this.LableComand.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество ходов";
            // 
            // LableNum
            // 
            this.LableNum.AutoSize = true;
            this.LableNum.Location = new System.Drawing.Point(187, 29);
            this.LableNum.Name = "LableNum";
            this.LableNum.Size = new System.Drawing.Size(13, 15);
            this.LableNum.TabIndex = 1;
            this.LableNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы должны получить число";
            // 
            // butMenu
            // 
            this.butMenu.Location = new System.Drawing.Point(218, 235);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(75, 23);
            this.butMenu.TabIndex = 6;
            this.butMenu.Text = "В меню";
            this.butMenu.UseVisualStyleBackColor = true;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(137, 235);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 8;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(612, 297);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.panelMenu.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lableCounts;
        private System.Windows.Forms.Label ClickSteps;
        private System.Windows.Forms.Button ButPlay;
        private System.Windows.Forms.Button ButExit;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LableNum;
        private System.Windows.Forms.Label LableComand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butBack;
    }
}

