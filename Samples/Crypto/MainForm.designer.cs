

#region using statements

#endregion

namespace Crypto
{

    #region class MainForm
    /// <summary>
    /// This is the designer for the MainForm for this application.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel DividerPanel;
        private System.Windows.Forms.Panel RightMarginPanel;
        private System.Windows.Forms.Panel LeftMarginPanel;
        private System.Windows.Forms.Panel TopMarginPanel;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DividerPanel = new System.Windows.Forms.Panel();
            this.RightMarginPanel = new System.Windows.Forms.Panel();
            this.LeftMarginPanel = new System.Windows.Forms.Panel();
            this.TopMarginPanel = new System.Windows.Forms.Panel();
            this.BottomMarginPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PasswordHashWithSaltTextBox = new System.Windows.Forms.TextBox();
            this.PasswordHashPanel = new System.Windows.Forms.Panel();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.GeneratePasswordHashButton = new System.Windows.Forms.Button();
            this.EncryptionPanel = new System.Windows.Forms.Panel();
            this.EncryptionControlPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EncryptClearButton = new System.Windows.Forms.Button();
            this.SeperatorPanel2 = new System.Windows.Forms.Panel();
            this.EncryptCopyButton = new System.Windows.Forms.Button();
            this.SeperatorPanel1 = new System.Windows.Forms.Panel();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptedPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SeperatorPanel3 = new System.Windows.Forms.Panel();
            this.DecryptCopyButton = new System.Windows.Forms.Button();
            this.SeperatorPanel4 = new System.Windows.Forms.Panel();
            this.DecryptClearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DecryptedStringControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.DecryptedPasswordControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StringToDecryptControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.EncryptedStringControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.EncryptionPasswordControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StringToEncryptControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.KeyCodeControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.PasswordControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.TopPanel.SuspendLayout();
            this.PasswordHashPanel.SuspendLayout();
            this.EncryptionPanel.SuspendLayout();
            this.EncryptionControlPanel.SuspendLayout();
            this.DecryptedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DividerPanel
            // 
            this.DividerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DividerPanel.Location = new System.Drawing.Point(16, 831);
            this.DividerPanel.Name = "DividerPanel";
            this.DividerPanel.Size = new System.Drawing.Size(1000, 22);
            this.DividerPanel.TabIndex = 40;
            // 
            // RightMarginPanel
            // 
            this.RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMarginPanel.Location = new System.Drawing.Point(1016, 16);
            this.RightMarginPanel.Name = "RightMarginPanel";
            this.RightMarginPanel.Size = new System.Drawing.Size(16, 837);
            this.RightMarginPanel.TabIndex = 38;
            // 
            // LeftMarginPanel
            // 
            this.LeftMarginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMarginPanel.Location = new System.Drawing.Point(0, 16);
            this.LeftMarginPanel.Name = "LeftMarginPanel";
            this.LeftMarginPanel.Size = new System.Drawing.Size(16, 837);
            this.LeftMarginPanel.TabIndex = 37;
            // 
            // TopMarginPanel
            // 
            this.TopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMarginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMarginPanel.Name = "TopMarginPanel";
            this.TopMarginPanel.Size = new System.Drawing.Size(1032, 16);
            this.TopMarginPanel.TabIndex = 35;
            // 
            // BottomMarginPanel
            // 
            this.BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomMarginPanel.Location = new System.Drawing.Point(16, 16);
            this.BottomMarginPanel.Name = "BottomMarginPanel";
            this.BottomMarginPanel.Size = new System.Drawing.Size(1000, 22);
            this.BottomMarginPanel.TabIndex = 44;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.PasswordHashWithSaltTextBox);
            this.TopPanel.Controls.Add(this.PasswordHashPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(16, 38);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 100);
            this.TopPanel.TabIndex = 54;
            // 
            // PasswordHashWithSaltTextBox
            // 
            this.PasswordHashWithSaltTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordHashWithSaltTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordHashWithSaltTextBox.Location = new System.Drawing.Point(499, 0);
            this.PasswordHashWithSaltTextBox.Multiline = true;
            this.PasswordHashWithSaltTextBox.Name = "PasswordHashWithSaltTextBox";
            this.PasswordHashWithSaltTextBox.Size = new System.Drawing.Size(501, 100);
            this.PasswordHashWithSaltTextBox.TabIndex = 55;
            // 
            // PasswordHashPanel
            // 
            this.PasswordHashPanel.Controls.Add(this.VerifyButton);
            this.PasswordHashPanel.Controls.Add(this.GeneratePasswordHashButton);
            this.PasswordHashPanel.Controls.Add(this.KeyCodeControl);
            this.PasswordHashPanel.Controls.Add(this.PasswordControl);
            this.PasswordHashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PasswordHashPanel.Location = new System.Drawing.Point(0, 0);
            this.PasswordHashPanel.Name = "PasswordHashPanel";
            this.PasswordHashPanel.Size = new System.Drawing.Size(499, 100);
            this.PasswordHashPanel.TabIndex = 53;
            // 
            // VerifyButton
            // 
            this.VerifyButton.Location = new System.Drawing.Point(333, 60);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(147, 31);
            this.VerifyButton.TabIndex = 55;
            this.VerifyButton.TabStop = false;
            this.VerifyButton.Text = "Verify Password";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // GeneratePasswordHashButton
            // 
            this.GeneratePasswordHashButton.Location = new System.Drawing.Point(162, 60);
            this.GeneratePasswordHashButton.Name = "GeneratePasswordHashButton";
            this.GeneratePasswordHashButton.Size = new System.Drawing.Size(147, 31);
            this.GeneratePasswordHashButton.TabIndex = 54;
            this.GeneratePasswordHashButton.TabStop = false;
            this.GeneratePasswordHashButton.Text = "Generate Password Hash";
            this.GeneratePasswordHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordHashButton.Click += new System.EventHandler(this.GeneratePasswordHashButton_Click);
            // 
            // EncryptionPanel
            // 
            this.EncryptionPanel.Controls.Add(this.EncryptedStringControl);
            this.EncryptionPanel.Controls.Add(this.EncryptionPasswordControl);
            this.EncryptionPanel.Controls.Add(this.StringToEncryptControl);
            this.EncryptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncryptionPanel.Location = new System.Drawing.Point(16, 138);
            this.EncryptionPanel.MaximumSize = new System.Drawing.Size(0, 360);
            this.EncryptionPanel.Name = "EncryptionPanel";
            this.EncryptionPanel.Size = new System.Drawing.Size(1000, 360);
            this.EncryptionPanel.TabIndex = 56;
            // 
            // EncryptionControlPanel
            // 
            this.EncryptionControlPanel.Controls.Add(this.panel2);
            this.EncryptionControlPanel.Controls.Add(this.EncryptClearButton);
            this.EncryptionControlPanel.Controls.Add(this.SeperatorPanel2);
            this.EncryptionControlPanel.Controls.Add(this.EncryptCopyButton);
            this.EncryptionControlPanel.Controls.Add(this.SeperatorPanel1);
            this.EncryptionControlPanel.Controls.Add(this.EncryptButton);
            this.EncryptionControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncryptionControlPanel.Location = new System.Drawing.Point(16, 498);
            this.EncryptionControlPanel.Name = "EncryptionControlPanel";
            this.EncryptionControlPanel.Size = new System.Drawing.Size(1000, 31);
            this.EncryptionControlPanel.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(784, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 31);
            this.panel2.TabIndex = 27;
            // 
            // EncryptClearButton
            // 
            this.EncryptClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EncryptClearButton.Location = new System.Drawing.Point(792, 0);
            this.EncryptClearButton.Name = "EncryptClearButton";
            this.EncryptClearButton.Size = new System.Drawing.Size(64, 31);
            this.EncryptClearButton.TabIndex = 26;
            this.EncryptClearButton.TabStop = false;
            this.EncryptClearButton.Text = "Clear";
            this.EncryptClearButton.UseVisualStyleBackColor = true;
            this.EncryptClearButton.Click += new System.EventHandler(this.EncryptClearButton_Click);
            // 
            // SeperatorPanel2
            // 
            this.SeperatorPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeperatorPanel2.Location = new System.Drawing.Point(856, 0);
            this.SeperatorPanel2.Name = "SeperatorPanel2";
            this.SeperatorPanel2.Size = new System.Drawing.Size(8, 31);
            this.SeperatorPanel2.TabIndex = 25;
            // 
            // EncryptCopyButton
            // 
            this.EncryptCopyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EncryptCopyButton.Location = new System.Drawing.Point(864, 0);
            this.EncryptCopyButton.Name = "EncryptCopyButton";
            this.EncryptCopyButton.Size = new System.Drawing.Size(64, 31);
            this.EncryptCopyButton.TabIndex = 24;
            this.EncryptCopyButton.TabStop = false;
            this.EncryptCopyButton.Text = "Copy";
            this.EncryptCopyButton.UseVisualStyleBackColor = true;
            this.EncryptCopyButton.Click += new System.EventHandler(this.EncryptCopyButton_Click);
            // 
            // SeperatorPanel1
            // 
            this.SeperatorPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeperatorPanel1.Location = new System.Drawing.Point(928, 0);
            this.SeperatorPanel1.Name = "SeperatorPanel1";
            this.SeperatorPanel1.Size = new System.Drawing.Size(8, 31);
            this.SeperatorPanel1.TabIndex = 23;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EncryptButton.Location = new System.Drawing.Point(936, 0);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(64, 31);
            this.EncryptButton.TabIndex = 22;
            this.EncryptButton.TabStop = false;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptedPanel
            // 
            this.DecryptedPanel.Controls.Add(this.DecryptedStringControl);
            this.DecryptedPanel.Controls.Add(this.DecryptedPasswordControl);
            this.DecryptedPanel.Controls.Add(this.StringToDecryptControl);
            this.DecryptedPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DecryptedPanel.Location = new System.Drawing.Point(16, 529);
            this.DecryptedPanel.MaximumSize = new System.Drawing.Size(0, 360);
            this.DecryptedPanel.Name = "DecryptedPanel";
            this.DecryptedPanel.Size = new System.Drawing.Size(1000, 360);
            this.DecryptedPanel.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(16, 787);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 22);
            this.panel3.TabIndex = 48;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DecryptButton.Location = new System.Drawing.Point(936, 0);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(64, 22);
            this.DecryptButton.TabIndex = 27;
            this.DecryptButton.TabStop = false;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // SeperatorPanel3
            // 
            this.SeperatorPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeperatorPanel3.Location = new System.Drawing.Point(928, 0);
            this.SeperatorPanel3.Name = "SeperatorPanel3";
            this.SeperatorPanel3.Size = new System.Drawing.Size(8, 22);
            this.SeperatorPanel3.TabIndex = 28;
            // 
            // DecryptCopyButton
            // 
            this.DecryptCopyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DecryptCopyButton.Location = new System.Drawing.Point(864, 0);
            this.DecryptCopyButton.Name = "DecryptCopyButton";
            this.DecryptCopyButton.Size = new System.Drawing.Size(64, 22);
            this.DecryptCopyButton.TabIndex = 29;
            this.DecryptCopyButton.TabStop = false;
            this.DecryptCopyButton.Text = "Copy";
            this.DecryptCopyButton.UseVisualStyleBackColor = true;
            this.DecryptCopyButton.Click += new System.EventHandler(this.DecryptCopyButton_Click);
            // 
            // SeperatorPanel4
            // 
            this.SeperatorPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeperatorPanel4.Location = new System.Drawing.Point(856, 0);
            this.SeperatorPanel4.Name = "SeperatorPanel4";
            this.SeperatorPanel4.Size = new System.Drawing.Size(8, 22);
            this.SeperatorPanel4.TabIndex = 30;
            // 
            // DecryptClearButton
            // 
            this.DecryptClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DecryptClearButton.Location = new System.Drawing.Point(792, 0);
            this.DecryptClearButton.Name = "DecryptClearButton";
            this.DecryptClearButton.Size = new System.Drawing.Size(64, 22);
            this.DecryptClearButton.TabIndex = 31;
            this.DecryptClearButton.TabStop = false;
            this.DecryptClearButton.Text = "Clear";
            this.DecryptClearButton.UseVisualStyleBackColor = true;
            this.DecryptClearButton.Click += new System.EventHandler(this.DecryptClearButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DecryptClearButton);
            this.panel1.Controls.Add(this.SeperatorPanel4);
            this.panel1.Controls.Add(this.DecryptCopyButton);
            this.panel1.Controls.Add(this.SeperatorPanel3);
            this.panel1.Controls.Add(this.DecryptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(16, 809);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 22);
            this.panel1.TabIndex = 42;
            // 
            // DecryptedStringControl
            // 
            this.DecryptedStringControl.BackColor = System.Drawing.Color.Transparent;
            this.DecryptedStringControl.BottomMargin = 12;
            this.DecryptedStringControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptedStringControl.Editable = true;
            this.DecryptedStringControl.Encrypted = false;
            this.DecryptedStringControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedStringControl.LabelBottomMargin = 0;
            this.DecryptedStringControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.DecryptedStringControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DecryptedStringControl.LabelText = "Decrypted String:";
            this.DecryptedStringControl.LabelTopMargin = 2;
            this.DecryptedStringControl.LabelWidth = 160;
            this.DecryptedStringControl.Location = new System.Drawing.Point(0, 134);
            this.DecryptedStringControl.MultiLine = true;
            this.DecryptedStringControl.Name = "DecryptedStringControl";
            this.DecryptedStringControl.OnTextChangedListener = null;
            this.DecryptedStringControl.PasswordMode = false;
            this.DecryptedStringControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DecryptedStringControl.Size = new System.Drawing.Size(1000, 226);
            this.DecryptedStringControl.TabIndex = 35;
            this.DecryptedStringControl.TextBoxBottomMargin = 0;
            this.DecryptedStringControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.DecryptedStringControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.DecryptedStringControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedStringControl.TextBoxTopMargin = 0;
            // 
            // DecryptedPasswordControl
            // 
            this.DecryptedPasswordControl.BackColor = System.Drawing.Color.Transparent;
            this.DecryptedPasswordControl.BottomMargin = 12;
            this.DecryptedPasswordControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DecryptedPasswordControl.Editable = true;
            this.DecryptedPasswordControl.Encrypted = false;
            this.DecryptedPasswordControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedPasswordControl.LabelBottomMargin = 0;
            this.DecryptedPasswordControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.DecryptedPasswordControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DecryptedPasswordControl.LabelText = "Password:";
            this.DecryptedPasswordControl.LabelTopMargin = 4;
            this.DecryptedPasswordControl.LabelWidth = 160;
            this.DecryptedPasswordControl.Location = new System.Drawing.Point(0, 100);
            this.DecryptedPasswordControl.MultiLine = false;
            this.DecryptedPasswordControl.Name = "DecryptedPasswordControl";
            this.DecryptedPasswordControl.OnTextChangedListener = null;
            this.DecryptedPasswordControl.PasswordMode = false;
            this.DecryptedPasswordControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DecryptedPasswordControl.Size = new System.Drawing.Size(1000, 34);
            this.DecryptedPasswordControl.TabIndex = 34;
            this.DecryptedPasswordControl.TextBoxBottomMargin = 0;
            this.DecryptedPasswordControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.DecryptedPasswordControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.DecryptedPasswordControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedPasswordControl.TextBoxTopMargin = 0;
            // 
            // StringToDecryptControl
            // 
            this.StringToDecryptControl.BackColor = System.Drawing.Color.Transparent;
            this.StringToDecryptControl.BottomMargin = 12;
            this.StringToDecryptControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.StringToDecryptControl.Editable = true;
            this.StringToDecryptControl.Encrypted = false;
            this.StringToDecryptControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringToDecryptControl.LabelBottomMargin = 0;
            this.StringToDecryptControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.StringToDecryptControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.StringToDecryptControl.LabelText = "String To Decrypt:";
            this.StringToDecryptControl.LabelTopMargin = 2;
            this.StringToDecryptControl.LabelWidth = 160;
            this.StringToDecryptControl.Location = new System.Drawing.Point(0, 0);
            this.StringToDecryptControl.MultiLine = true;
            this.StringToDecryptControl.Name = "StringToDecryptControl";
            this.StringToDecryptControl.OnTextChangedListener = null;
            this.StringToDecryptControl.PasswordMode = false;
            this.StringToDecryptControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StringToDecryptControl.Size = new System.Drawing.Size(1000, 100);
            this.StringToDecryptControl.TabIndex = 33;
            this.StringToDecryptControl.TextBoxBottomMargin = 0;
            this.StringToDecryptControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.StringToDecryptControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.StringToDecryptControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringToDecryptControl.TextBoxTopMargin = 0;
            // 
            // EncryptedStringControl
            // 
            this.EncryptedStringControl.BackColor = System.Drawing.Color.Transparent;
            this.EncryptedStringControl.BottomMargin = 12;
            this.EncryptedStringControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptedStringControl.Editable = true;
            this.EncryptedStringControl.Encrypted = false;
            this.EncryptedStringControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedStringControl.LabelBottomMargin = 0;
            this.EncryptedStringControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.EncryptedStringControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.EncryptedStringControl.LabelText = "Encrypted String:";
            this.EncryptedStringControl.LabelTopMargin = 2;
            this.EncryptedStringControl.LabelWidth = 160;
            this.EncryptedStringControl.Location = new System.Drawing.Point(0, 114);
            this.EncryptedStringControl.MultiLine = true;
            this.EncryptedStringControl.Name = "EncryptedStringControl";
            this.EncryptedStringControl.OnTextChangedListener = null;
            this.EncryptedStringControl.PasswordMode = false;
            this.EncryptedStringControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EncryptedStringControl.Size = new System.Drawing.Size(1000, 246);
            this.EncryptedStringControl.TabIndex = 25;
            this.EncryptedStringControl.TextBoxBottomMargin = 0;
            this.EncryptedStringControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.EncryptedStringControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.EncryptedStringControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedStringControl.TextBoxTopMargin = 0;
            // 
            // EncryptionPasswordControl
            // 
            this.EncryptionPasswordControl.BackColor = System.Drawing.Color.Transparent;
            this.EncryptionPasswordControl.BottomMargin = 12;
            this.EncryptionPasswordControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncryptionPasswordControl.Editable = true;
            this.EncryptionPasswordControl.Encrypted = false;
            this.EncryptionPasswordControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionPasswordControl.LabelBottomMargin = 0;
            this.EncryptionPasswordControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.EncryptionPasswordControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.EncryptionPasswordControl.LabelText = "Password:";
            this.EncryptionPasswordControl.LabelTopMargin = 4;
            this.EncryptionPasswordControl.LabelWidth = 160;
            this.EncryptionPasswordControl.Location = new System.Drawing.Point(0, 80);
            this.EncryptionPasswordControl.MultiLine = false;
            this.EncryptionPasswordControl.Name = "EncryptionPasswordControl";
            this.EncryptionPasswordControl.OnTextChangedListener = null;
            this.EncryptionPasswordControl.PasswordMode = false;
            this.EncryptionPasswordControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EncryptionPasswordControl.Size = new System.Drawing.Size(1000, 34);
            this.EncryptionPasswordControl.TabIndex = 24;
            this.EncryptionPasswordControl.TextBoxBottomMargin = 0;
            this.EncryptionPasswordControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.EncryptionPasswordControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.EncryptionPasswordControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionPasswordControl.TextBoxTopMargin = 0;
            // 
            // StringToEncryptControl
            // 
            this.StringToEncryptControl.BackColor = System.Drawing.Color.Transparent;
            this.StringToEncryptControl.BottomMargin = 12;
            this.StringToEncryptControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.StringToEncryptControl.Editable = true;
            this.StringToEncryptControl.Encrypted = false;
            this.StringToEncryptControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringToEncryptControl.LabelBottomMargin = 0;
            this.StringToEncryptControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.StringToEncryptControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.StringToEncryptControl.LabelText = "String To Encrypt:";
            this.StringToEncryptControl.LabelTopMargin = 2;
            this.StringToEncryptControl.LabelWidth = 160;
            this.StringToEncryptControl.Location = new System.Drawing.Point(0, 0);
            this.StringToEncryptControl.MultiLine = true;
            this.StringToEncryptControl.Name = "StringToEncryptControl";
            this.StringToEncryptControl.OnTextChangedListener = null;
            this.StringToEncryptControl.PasswordMode = false;
            this.StringToEncryptControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StringToEncryptControl.Size = new System.Drawing.Size(1000, 80);
            this.StringToEncryptControl.TabIndex = 23;
            this.StringToEncryptControl.TextBoxBottomMargin = 0;
            this.StringToEncryptControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.StringToEncryptControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.StringToEncryptControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringToEncryptControl.TextBoxTopMargin = 0;
            // 
            // KeyCodeControl
            // 
            this.KeyCodeControl.BackColor = System.Drawing.Color.Transparent;
            this.KeyCodeControl.BottomMargin = 8;
            this.KeyCodeControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeyCodeControl.Editable = true;
            this.KeyCodeControl.Encrypted = false;
            this.KeyCodeControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyCodeControl.LabelBottomMargin = 0;
            this.KeyCodeControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.KeyCodeControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.KeyCodeControl.LabelText = "Key Code:";
            this.KeyCodeControl.LabelTopMargin = 2;
            this.KeyCodeControl.LabelWidth = 160;
            this.KeyCodeControl.Location = new System.Drawing.Point(0, 32);
            this.KeyCodeControl.MaximumSize = new System.Drawing.Size(480, 32);
            this.KeyCodeControl.MultiLine = true;
            this.KeyCodeControl.Name = "KeyCodeControl";
            this.KeyCodeControl.OnTextChangedListener = null;
            this.KeyCodeControl.PasswordMode = false;
            this.KeyCodeControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KeyCodeControl.Size = new System.Drawing.Size(480, 32);
            this.KeyCodeControl.TabIndex = 53;
            this.KeyCodeControl.TextBoxBottomMargin = 0;
            this.KeyCodeControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.KeyCodeControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.KeyCodeControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyCodeControl.TextBoxTopMargin = 0;
            // 
            // PasswordControl
            // 
            this.PasswordControl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordControl.BottomMargin = 8;
            this.PasswordControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordControl.Editable = true;
            this.PasswordControl.Encrypted = false;
            this.PasswordControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordControl.LabelBottomMargin = 0;
            this.PasswordControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.PasswordControl.LabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordControl.LabelText = "Password:";
            this.PasswordControl.LabelTopMargin = 2;
            this.PasswordControl.LabelWidth = 160;
            this.PasswordControl.Location = new System.Drawing.Point(0, 0);
            this.PasswordControl.MaximumSize = new System.Drawing.Size(480, 32);
            this.PasswordControl.MultiLine = true;
            this.PasswordControl.Name = "PasswordControl";
            this.PasswordControl.OnTextChangedListener = null;
            this.PasswordControl.PasswordMode = false;
            this.PasswordControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordControl.Size = new System.Drawing.Size(480, 32);
            this.PasswordControl.TabIndex = 52;
            this.PasswordControl.TextBoxBottomMargin = 0;
            this.PasswordControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.PasswordControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.PasswordControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordControl.TextBoxTopMargin = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 853);
            this.Controls.Add(this.DecryptedPanel);
            this.Controls.Add(this.EncryptionControlPanel);
            this.Controls.Add(this.EncryptionPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BottomMarginPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DividerPanel);
            this.Controls.Add(this.RightMarginPanel);
            this.Controls.Add(this.LeftMarginPanel);
            this.Controls.Add(this.TopMarginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.PasswordHashPanel.ResumeLayout(false);
            this.EncryptionPanel.ResumeLayout(false);
            this.EncryptionControlPanel.ResumeLayout(false);
            this.DecryptedPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }
        #endregion

        #endregion
        private System.Windows.Forms.Panel BottomMarginPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox PasswordHashWithSaltTextBox;
        private System.Windows.Forms.Panel PasswordHashPanel;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Button GeneratePasswordHashButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl KeyCodeControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl PasswordControl;
        private System.Windows.Forms.Panel EncryptionPanel;
        private DataJuggler.Win.Controls.LabelTextBoxControl EncryptedStringControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl EncryptionPasswordControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl StringToEncryptControl;
        private System.Windows.Forms.Panel EncryptionControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EncryptClearButton;
        private System.Windows.Forms.Panel SeperatorPanel2;
        private System.Windows.Forms.Button EncryptCopyButton;
        private System.Windows.Forms.Panel SeperatorPanel1;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Panel DecryptedPanel;
        private DataJuggler.Win.Controls.LabelTextBoxControl DecryptedStringControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl DecryptedPasswordControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl StringToDecryptControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Panel SeperatorPanel3;
        private System.Windows.Forms.Button DecryptCopyButton;
        private System.Windows.Forms.Panel SeperatorPanel4;
        private System.Windows.Forms.Button DecryptClearButton;
        private System.Windows.Forms.Panel panel1;
    }
    #endregion

}
