namespace _2048WinFormsApp
{
    partial class StartSettingsForm
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
            components = new System.ComponentModel.Container();
            userNameTextBox = new TextBox();
            label1 = new Label();
            userNameButton = new Button();
            mapSizeComboBox = new ComboBox();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(21, 52);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(237, 23);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.Validating += userNameTextBox_Validating;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 1;
            label1.Text = "Введите ваше имя";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userNameButton
            // 
            userNameButton.Location = new Point(21, 213);
            userNameButton.Name = "userNameButton";
            userNameButton.Size = new Size(235, 36);
            userNameButton.TabIndex = 2;
            userNameButton.Text = "Начать игру!";
            userNameButton.UseVisualStyleBackColor = true;
            userNameButton.Click += userNameButton_Click;
            // 
            // mapSizeComboBox
            // 
            mapSizeComboBox.FormattingEnabled = true;
            mapSizeComboBox.Items.AddRange(new object[] { "4x4", "5x5", "6x6" });
            mapSizeComboBox.Location = new Point(24, 157);
            mapSizeComboBox.Name = "mapSizeComboBox";
            mapSizeComboBox.Size = new Size(232, 23);
            mapSizeComboBox.TabIndex = 3;
            mapSizeComboBox.Text = "4x4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 118);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 4;
            label2.Text = "Выберите размер поля";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // StartSettingsForm
            // 
            AcceptButton = userNameButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 271);
            Controls.Add(label2);
            Controls.Add(mapSizeComboBox);
            Controls.Add(userNameButton);
            Controls.Add(label1);
            Controls.Add(userNameTextBox);
            Name = "StartSettingsForm";
            Text = "2048";
            Load += UserNameForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private Label label1;
        private Button userNameButton;
        private ComboBox mapSizeComboBox;
        private Label label2;
        private ErrorProvider errorProvider;
    }
}