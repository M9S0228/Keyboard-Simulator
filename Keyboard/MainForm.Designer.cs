namespace Keyboard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вІдкритиРезультатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кінецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(31, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 1;
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.LevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Items.AddRange(new object[] {
            "Легка",
            "Середня",
            "Висока"});
            this.LevelComboBox.Location = new System.Drawing.Point(131, 49);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(114, 21);
            this.LevelComboBox.TabIndex = 2;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(59, 52);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(66, 13);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "Складність:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(75, 90);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 38);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Почати";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.кінецьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вІдкритиРезультатиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вІдкритиРезультатиToolStripMenuItem
            // 
            this.вІдкритиРезультатиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вІдкритиРезультатиToolStripMenuItem.Image")));
            this.вІдкритиРезультатиToolStripMenuItem.Name = "вІдкритиРезультатиToolStripMenuItem";
            this.вІдкритиРезультатиToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.вІдкритиРезультатиToolStripMenuItem.Text = "Відкрити результати";
            this.вІдкритиРезультатиToolStripMenuItem.Click += new System.EventHandler(this.вІдкритиРезультатиToolStripMenuItem_Click);
            // 
            // кінецьToolStripMenuItem
            // 
            this.кінецьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.кінецьToolStripMenuItem.Name = "кінецьToolStripMenuItem";
            this.кінецьToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.кінецьToolStripMenuItem.Text = "Кінець";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вихідToolStripMenuItem.Image")));
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Текстовые документы (.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 140);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клавіатурний тренажер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вІдкритиРезультатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кінецьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}