namespace _2048WinFormsApp
{
    partial class MainForm
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
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            перезапуститьИгруToolStripMenuItem = new ToolStripMenuItem();
            статистикаИгрыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            bestScoreLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 4);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(166, 33);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(59, 25);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(320, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, перезапуститьИгруToolStripMenuItem, статистикаИгрыToolStripMenuItem, выходToolStripMenuItem });
            менюToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(77, 29);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(256, 30);
            toolStripMenuItem1.Text = "Правила игры";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // перезапуститьИгруToolStripMenuItem
            // 
            перезапуститьИгруToolStripMenuItem.Name = "перезапуститьИгруToolStripMenuItem";
            перезапуститьИгруToolStripMenuItem.Size = new Size(256, 30);
            перезапуститьИгруToolStripMenuItem.Text = "Перезапустить игру";
            перезапуститьИгруToolStripMenuItem.Click += перезапуститьИгруToolStripMenuItem_Click;
            // 
            // статистикаИгрыToolStripMenuItem
            // 
            статистикаИгрыToolStripMenuItem.Name = "статистикаИгрыToolStripMenuItem";
            статистикаИгрыToolStripMenuItem.Size = new Size(256, 30);
            статистикаИгрыToolStripMenuItem.Text = "Статистика игры";
            статистикаИгрыToolStripMenuItem.Click += статистикаИгрыToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(256, 30);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(232, 5);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 3;
            label2.Text = "Рекорд:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreLabel.Location = new Point(232, 35);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(59, 25);
            bestScoreLabel.TabIndex = 4;
            bestScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(320, 399);
            Controls.Add(bestScoreLabel);
            Controls.Add(label2);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "2048";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem перезапуститьИгруToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem статистикаИгрыToolStripMenuItem;
        private Label label2;
        private Label bestScoreLabel;
    }
}