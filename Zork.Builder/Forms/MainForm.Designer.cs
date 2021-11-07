
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
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.TextBox nameTextBox;
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.worldTab = new System.Windows.Forms.TabPage();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.neighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.neighborControl4 = new Zork.Builder.CustomControls.NeighborControl();
            this.neighborControl3 = new Zork.Builder.CustomControls.NeighborControl();
            this.neighborControl2 = new Zork.Builder.CustomControls.NeighborControl();
            this.neighborControl1 = new Zork.Builder.CustomControls.NeighborControl();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            nameTextBox = new System.Windows.Forms.TextBox();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
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
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fileSeparatorStripMenuItem
            // 
            fileSeparatorStripMenuItem.Name = "fileSeparatorStripMenuItem";
            fileSeparatorStripMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveAsToolStripMenuItem.Text = "&Save As...";
            saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
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
            mainMenuStrip.Size = new System.Drawing.Size(615, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // nameTextBox
            // 
            nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            nameTextBox.Location = new System.Drawing.Point(6, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(340, 20);
            nameTextBox.TabIndex = 9;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.AllowNew = true;
            this.gameViewModelBindingSource.DataSource = typeof(ZorkBuilder.WinForms.GameViewModel);
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
            this.mainGroupBox.Location = new System.Drawing.Point(171, 57);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(371, 391);
            this.mainGroupBox.TabIndex = 6;
            this.mainGroupBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.neighborsGroupBox.Controls.Add(this.neighborControl4);
            this.neighborsGroupBox.Controls.Add(this.neighborControl3);
            this.neighborsGroupBox.Controls.Add(this.neighborControl2);
            this.neighborsGroupBox.Controls.Add(this.neighborControl1);
            this.neighborsGroupBox.Location = new System.Drawing.Point(9, 119);
            this.neighborsGroupBox.Name = "neighborsGroupBox";
            this.neighborsGroupBox.Size = new System.Drawing.Size(337, 260);
            this.neighborsGroupBox.TabIndex = 7;
            this.neighborsGroupBox.TabStop = false;
            this.neighborsGroupBox.Text = "Neighbors";
            // 
            // neighborControl4
            // 
            this.neighborControl4.Location = new System.Drawing.Point(103, 186);
            this.neighborControl4.Name = "neighborControl4";
            this.neighborControl4.NeighborDirection = Zork.Common.NeighborDirections.South;
            this.neighborControl4.Size = new System.Drawing.Size(128, 54);
            this.neighborControl4.TabIndex = 3;
            // 
            // neighborControl3
            // 
            this.neighborControl3.Location = new System.Drawing.Point(6, 102);
            this.neighborControl3.Name = "neighborControl3";
            this.neighborControl3.NeighborDirection = Zork.Common.NeighborDirections.West;
            this.neighborControl3.Size = new System.Drawing.Size(128, 54);
            this.neighborControl3.TabIndex = 2;
            // 
            // neighborControl2
            // 
            this.neighborControl2.Location = new System.Drawing.Point(203, 102);
            this.neighborControl2.Name = "neighborControl2";
            this.neighborControl2.NeighborDirection = Zork.Common.NeighborDirections.East;
            this.neighborControl2.Size = new System.Drawing.Size(128, 54);
            this.neighborControl2.TabIndex = 1;
            // 
            // neighborControl1
            // 
            this.neighborControl1.Location = new System.Drawing.Point(103, 19);
            this.neighborControl1.Name = "neighborControl1";
            this.neighborControl1.NeighborDirection = Zork.Common.NeighborDirections.North;
            this.neighborControl1.Size = new System.Drawing.Size(128, 54);
            this.neighborControl1.TabIndex = 0;
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
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(9, 74);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(153, 342);
            this.roomsListBox.TabIndex = 3;
            this.roomsListBox.ValueMember = "Name";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
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
            this.dropDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dropDown.DataSource = this.gameViewModelBindingSource;
            this.dropDown.DisplayMember = "StartingLocation";
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
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World files (*.json)|*.json";
            this.saveFileDialog.Title = "Save world as";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 569);
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
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.worldTab.ResumeLayout(false);
            this.worldTab.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.neighborsGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox neighborsGroupBox;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Zork.Builder.CustomControls.NeighborControl neighborControl4;
        private Zork.Builder.CustomControls.NeighborControl neighborControl3;
        private Zork.Builder.CustomControls.NeighborControl neighborControl2;
        private Zork.Builder.CustomControls.NeighborControl neighborControl1;
    }
}

