
namespace Zork.Builder
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
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.worldTab = new System.Windows.Forms.TabPage();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.neighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.southButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            mainMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.worldTab.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.neighborsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            fileSeparatorStripMenuItem,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fileSeparatorStripMenuItem
            // 
            fileSeparatorStripMenuItem.Name = "fileSeparatorStripMenuItem";
            fileSeparatorStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += new System.EventHandler(this.runButtonClick);
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            runToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(565, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "mainMenuStrip";
            mainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.worldTab);
            this.mainTabControl.Controls.Add(this.gameTab);
            this.mainTabControl.Controls.Add(this.filesTab);
            this.mainTabControl.Location = new System.Drawing.Point(13, 28);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(546, 486);
            this.mainTabControl.TabIndex = 1;
            // 
            // worldTab
            // 
            this.worldTab.Controls.Add(this.mainGroupBox);
            this.worldTab.Controls.Add(this.deleteButton);
            this.worldTab.Controls.Add(this.addButton);
            this.worldTab.Controls.Add(this.roomsListBox);
            this.worldTab.Controls.Add(this.roomsLabel);
            this.worldTab.Controls.Add(this.dropDown);
            this.worldTab.Controls.Add(this.startingLocationLabel);
            this.worldTab.Location = new System.Drawing.Point(4, 22);
            this.worldTab.Name = "worldTab";
            this.worldTab.Padding = new System.Windows.Forms.Padding(3);
            this.worldTab.Size = new System.Drawing.Size(538, 460);
            this.worldTab.TabIndex = 0;
            this.worldTab.Text = "World";
            this.worldTab.UseVisualStyleBackColor = true;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.descriptionTextBox);
            this.mainGroupBox.Controls.Add(this.nameTextBox);
            this.mainGroupBox.Controls.Add(this.descriptionLabel);
            this.mainGroupBox.Controls.Add(this.nameLabel);
            this.mainGroupBox.Controls.Add(this.neighborsGroupBox);
            this.mainGroupBox.Location = new System.Drawing.Point(171, 57);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(361, 391);
            this.mainGroupBox.TabIndex = 6;
            this.mainGroupBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 71);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(340, 42);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(340, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // neighborsGroupBox
            // 
            this.neighborsGroupBox.Controls.Add(this.label5);
            this.neighborsGroupBox.Controls.Add(this.label4);
            this.neighborsGroupBox.Controls.Add(this.label3);
            this.neighborsGroupBox.Controls.Add(this.label1);
            this.neighborsGroupBox.Controls.Add(this.southButton);
            this.neighborsGroupBox.Controls.Add(this.westButton);
            this.neighborsGroupBox.Controls.Add(this.eastButton);
            this.neighborsGroupBox.Controls.Add(this.northButton);
            this.neighborsGroupBox.Location = new System.Drawing.Point(9, 119);
            this.neighborsGroupBox.Name = "neighborsGroupBox";
            this.neighborsGroupBox.Size = new System.Drawing.Size(337, 260);
            this.neighborsGroupBox.TabIndex = 7;
            this.neighborsGroupBox.TabStop = false;
            this.neighborsGroupBox.Text = "Neighbors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(129, 177);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 61);
            this.southButton.TabIndex = 3;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            // 
            // westButton
            // 
            this.westButton.Location = new System.Drawing.Point(20, 100);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(75, 61);
            this.westButton.TabIndex = 2;
            this.westButton.Text = "West";
            this.westButton.UseVisualStyleBackColor = true;
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(240, 100);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(75, 61);
            this.eastButton.TabIndex = 1;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = true;
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(129, 35);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 61);
            this.northButton.TabIndex = 0;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(90, 425);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 425);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(9, 74);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(153, 342);
            this.roomsListBox.TabIndex = 3;
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Location = new System.Drawing.Point(7, 57);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(43, 13);
            this.roomsLabel.TabIndex = 2;
            this.roomsLabel.Text = "Rooms:";
            // 
            // dropDown
            // 
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Location = new System.Drawing.Point(9, 33);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(153, 21);
            this.dropDown.TabIndex = 1;
            // 
            // startingLocationLabel
            // 
            this.startingLocationLabel.AutoSize = true;
            this.startingLocationLabel.Location = new System.Drawing.Point(6, 15);
            this.startingLocationLabel.Name = "startingLocationLabel";
            this.startingLocationLabel.Size = new System.Drawing.Size(90, 13);
            this.startingLocationLabel.TabIndex = 0;
            this.startingLocationLabel.Text = "Starting Location:";
            // 
            // gameTab
            // 
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(538, 460);
            this.gameTab.TabIndex = 1;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // filesTab
            // 
            this.filesTab.Location = new System.Drawing.Point(4, 22);
            this.filesTab.Name = "filesTab";
            this.filesTab.Padding = new System.Windows.Forms.Padding(3);
            this.filesTab.Size = new System.Drawing.Size(538, 460);
            this.filesTab.TabIndex = 2;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogue);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 527);
            this.ControlBox = false;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.worldTab.ResumeLayout(false);
            this.worldTab.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.neighborsGroupBox.ResumeLayout(false);
            this.neighborsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage worldTab;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.Label startingLocationLabel;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox neighborsGroupBox;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

