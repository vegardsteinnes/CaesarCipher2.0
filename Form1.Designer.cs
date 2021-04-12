
namespace CaesarCipherGui
{
    partial class CaesarCipher
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
            this.EncryptRdo = new System.Windows.Forms.RadioButton();
            this.DecryptRdo = new System.Windows.Forms.RadioButton();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.NumericShift = new System.Windows.Forms.NumericUpDown();
            this.ShiftLbl = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericShift)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptRdo
            // 
            this.EncryptRdo.AutoSize = true;
            this.EncryptRdo.Location = new System.Drawing.Point(12, 42);
            this.EncryptRdo.Name = "EncryptRdo";
            this.EncryptRdo.Size = new System.Drawing.Size(65, 19);
            this.EncryptRdo.TabIndex = 0;
            this.EncryptRdo.TabStop = true;
            this.EncryptRdo.Text = "Encrypt";
            this.EncryptRdo.UseVisualStyleBackColor = true;
            this.EncryptRdo.CheckedChanged += new System.EventHandler(this.EncryptRdo_CheckedChanged);
            // 
            // DecryptRdo
            // 
            this.DecryptRdo.AutoSize = true;
            this.DecryptRdo.Location = new System.Drawing.Point(83, 42);
            this.DecryptRdo.Name = "DecryptRdo";
            this.DecryptRdo.Size = new System.Drawing.Size(66, 19);
            this.DecryptRdo.TabIndex = 1;
            this.DecryptRdo.TabStop = true;
            this.DecryptRdo.Text = "Decrypt";
            this.DecryptRdo.UseVisualStyleBackColor = true;
            this.DecryptRdo.CheckedChanged += new System.EventHandler(this.DecryptRdo_CheckedChanged);
            // 
            // TextOutput
            // 
            this.TextOutput.AcceptsReturn = true;
            this.TextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.TextOutput.Location = new System.Drawing.Point(12, 99);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextOutput.Size = new System.Drawing.Size(360, 200);
            this.TextOutput.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Browse text files.";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(297, 13);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 24);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 13);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(279, 23);
            this.TextInput.TabIndex = 4;
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(12, 67);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(75, 23);
            this.RunBtn.TabIndex = 5;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // NumericShift
            // 
            this.NumericShift.Location = new System.Drawing.Point(259, 42);
            this.NumericShift.Name = "NumericShift";
            this.NumericShift.Size = new System.Drawing.Size(32, 23);
            this.NumericShift.TabIndex = 6;
            this.NumericShift.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ShiftLbl
            // 
            this.ShiftLbl.AutoSize = true;
            this.ShiftLbl.Location = new System.Drawing.Point(222, 44);
            this.ShiftLbl.Name = "ShiftLbl";
            this.ShiftLbl.Size = new System.Drawing.Size(31, 15);
            this.ShiftLbl.TabIndex = 7;
            this.ShiftLbl.Text = "Shift";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(297, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ShiftLbl);
            this.Controls.Add(this.NumericShift);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.DecryptRdo);
            this.Controls.Add(this.EncryptRdo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "CaesarCipher";
            this.Text = "Vegards Caesar Ciphererer";
            ((System.ComponentModel.ISupportInitialize)(this.NumericShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EncryptRdo;
        private System.Windows.Forms.RadioButton DecryptRdo;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.NumericUpDown NumericShift;
        private System.Windows.Forms.Label ShiftLbl;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

