
namespace Zork.Builder.CustomControls
{
    partial class NeighborControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(3, 3);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(121, 20);
            this.directionTextBox.TabIndex = 0;
            this.directionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.Location = new System.Drawing.Point(3, 29);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectionComboBox.TabIndex = 1;
            // 
            // NeighborControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectionComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Name = "NeighborControl";
            this.Size = new System.Drawing.Size(128, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.ComboBox selectionComboBox;
    }
}
