
namespace ZorkBuilder.WinForms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openFileButton;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.TextBox nameTextBox;
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.worldTab = new System.Windows.Forms.TabPage();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.neighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.southButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsLabel = new System.Windows.Forms.Label();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            nameTextBox = new System.Windows.Forms.TextBox();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.worldTab.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.neighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openFileButton,
            fileSeparatorStripMenuItem,
            saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
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
            // openFileButton
            // 
            openFileButton.Name = "openFileButton";
            openFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openFileButton.Size = new System.Drawing.Size(180, 22);
            openFileButton.Text = "&Open";
            openFileButton.Click += new System.EventHandler(this.openFileButton);
            // 
            // fileSeparatorStripMenuItem
            // 
            fileSeparatorStripMenuItem.Name = "fileSeparatorStripMenuItem";
            fileSeparatorStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            saveAsToolStripMenuItem.Text = "&Save As...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
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
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            runToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(612, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // nameTextBox
            // 
            nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            nameTextBox.Location = new System.Drawing.Point(6, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(340, 20);
            nameTextBox.TabIndex = 9;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameBindingSource;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.AllowNew = true;
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.AllowNew = true;
            this.gameViewModelBindingSource.DataSource = typeof(ZorkBuilder.WinForms.GameViewModel);
            this.gameViewModelBindingSource.CurrentChanged += new System.EventHandler(this.gameViewModelBindingSource_CurrentChanged);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.worldTab);
            this.mainTabControl.Controls.Add(this.gameTab);
            this.mainTabControl.Controls.Add(this.filesTab);
            this.mainTabControl.Location = new System.Drawing.Point(13, 28);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(594, 534);
            this.mainTabControl.TabIndex = 1;
            // 
            // worldTab
            // 
            this.worldTab.AutoScroll = true;
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
            this.worldTab.Size = new System.Drawing.Size(586, 508);
            this.worldTab.TabIndex = 0;
            this.worldTab.Text = "World";
            this.worldTab.UseVisualStyleBackColor = true;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.descriptionTextBox);
            this.mainGroupBox.Controls.Add(nameTextBox);
            this.mainGroupBox.Controls.Add(this.descriptionLabel);
            this.mainGroupBox.Controls.Add(this.nameLabel);
            this.mainGroupBox.Controls.Add(this.neighborsGroupBox);
            this.mainGroupBox.Location = new System.Drawing.Point(189, 33);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(379, 415);
            this.mainGroupBox.TabIndex = 6;
            this.mainGroupBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 71);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(340, 42);
            this.descriptionTextBox.TabIndex = 10;
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
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // neighborsGroupBox
            // 
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
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.roomsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "Name", true));
            this.roomsListBox.DataSource = this.roomsBindingSource1;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(9, 74);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(153, 342);
            this.roomsListBox.TabIndex = 3;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.gameBindingSource;
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
            this.gameTab.Size = new System.Drawing.Size(586, 508);
            this.gameTab.TabIndex = 1;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // filesTab
            // 
            this.filesTab.Location = new System.Drawing.Point(4, 22);
            this.filesTab.Name = "filesTab";
            this.filesTab.Padding = new System.Windows.Forms.Padding(3);
            this.filesTab.Size = new System.Drawing.Size(586, 508);
            this.filesTab.TabIndex = 2;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 568);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.worldTab.ResumeLayout(false);
            this.worldTab.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.neighborsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private System.Windows.Forms.TabPage worldTab;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox neighborsGroupBox;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.Label startingLocationLabel;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
    }
}

