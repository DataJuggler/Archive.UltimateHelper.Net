

#region using statements

using System;
using System.Windows.Forms;
using DataJuggler.Core.UltimateHelper;

#endregion


namespace Crypto
{

    #region class MainForm : Form
    /// <summary>
    /// This is the main form for this application.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Constructor
        /// <summary>
        /// Creates a new MainForm instance.
        /// </summary>
        public MainForm()
        {
            // Create Components
            InitializeComponent();
            
            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region EncryptClearButton_Click(object sender, EventArgs e)
            /// <summary>
            /// Clears The Encryption Panel Controls.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void EncryptClearButton_Click(object sender, EventArgs e)
            {
                // Clear Encryption Controls
                ClearStringEncryptionControls();
            }
            #endregion

            #region EncryptCopyButton_Click(object sender, EventArgs e)
            /// <summary>
            /// Copies the text of the encryption result to the clipboard.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void EncryptCopyButton_Click(object sender, EventArgs e)
            {
                // Copy encryption result to clipboard.
                EncryptionCopy();
            }
            #endregion

            #region EncryptButton_Click(object sender, EventArgs e)
            /// <summary>
            /// Performs the encryption of the entered text.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void EncryptButton_Click(object sender, EventArgs e)
            {
               // Perform Encryption
               EncryptString();
            }
            #endregion

            #region DecryptClearButton_Click(object sender, EventArgs e)
            /// <summary>
            /// Clears the decryption panel controls.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DecryptClearButton_Click(object sender, EventArgs e)
            {
                // Clear controls in the decryption panel.
                ClearStringDecryptionControls();
            }
            #endregion

            #region DecryptCopyButton_Click(object sender, EventArgs e)
            /// <summary>
            /// Copies the text of the descryption result to the clipboard.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DecryptCopyButton_Click(object sender, EventArgs e)
            {
                // Copy the result of decryption to the clipboard.
                DecryptionCopy();
            }
            #endregion

            #region DecryptButton_Click(object sender, EventArgs e)
            /// <summary>
            /// Performs the decryption of the entered text.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DecryptButton_Click(object sender, EventArgs e)
            {
                // Decrypt String
                DecryptString();
            } 
            #endregion

            #region MainForm_Activated(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Main Form _ Activated
            /// </summary>
            private void MainForm_Activated(object sender, EventArgs e)
            {
                // call the size changed method so it called
                MainForm_SizeChanged(this, e);
            }
            #endregion
            
            #region MainForm_SizeChanged(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Main Form _ Size Changed
            /// </summary>
            private void MainForm_SizeChanged(object sender, EventArgs e)
            {
                // get the height of this form
                int height = this.Height;

                // get the titleBar height
                int TitlebarHeight = this.Height - this.ClientSize.Height - 2;

                // get the height of each content area
                int contentAreaHeight = (this.Height - TitlebarHeight - this.TopMarginPanel.Height - this.BottomMarginPanel.Height - this.DividerPanel.Height) / 2;

                // setting this height resizes the form
                this.EncryptionPanel.Height = contentAreaHeight;

                // set the height of the StringToDecryptControl (the EncryptedStringControl is Dock.Fill)
                this.StringToEncryptControl.Height = (this.EncryptionPanel.Height - this.EncryptionControlPanel.Height - this.EncryptionPasswordControl.Height) / 2;

                // now set the height of the StringTo
                this.StringToDecryptControl.Height = StringToEncryptControl.Height;
            }
            #endregion
            
            #region StringDecryptionPasswordTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// Calls UIEnable to enable controls on this form when this text changes.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StringDecryptionPasswordTextBox_TextChanged(object sender, EventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            } 
            #endregion

            #region StringDecryptionResultTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// Calls UIEnable to enable controls on this form when this text changes.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StringDecryptionResultTextBox_TextChanged(object sender, EventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            } 
            #endregion

            #region StringEncryptionPasswordTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// Calls UIEnable to enable controls on this form when this text changes.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StringEncryptionPasswordTextBox_TextChanged(object sender, EventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            } 
            #endregion

            #region StringEncryptionResultTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// Calls UIEnable to enable controls on this form when this text changes.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StringEncryptionResultTextBox_TextChanged(object sender, EventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            }
            #endregion

            #region StringToDecryptTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// Calls UIEnable to enable controls on this form when this text changes.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StringToDecryptTextBox_TextChanged(object sender, EventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            } 
            #endregion

            #region StringToEncryptTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// Calls UIEnable to enable controls on this form when this text changes.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StringToEncryptTextBox_TextChanged(object sender, EventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            } 
            #endregion
            
        #endregion
        
        #region Methods

            #region ClearStringDecryptionControls()
            /// <summary>
            /// Clears the controls in the decryption panel.
            /// </summary>
            private void ClearStringDecryptionControls()
            {
                // clear each control.
                this.StringToDecryptControl.Text = "";
                this.DecryptedPasswordControl.Text = "";
                this.DecryptedStringControl.Text = "";
            }  
            #endregion

            #region ClearStringEncryptionControls()
            /// <summary>
            /// Clears the text box controls in the encryption panel.
            /// </summary>
            private void ClearStringEncryptionControls()
            {
                // Clear each text box
                this.StringToEncryptControl.Text = "";
                this.EncryptionPasswordControl.Text = "";
                this.EncryptedStringControl.Text = "";
            }  
            #endregion

            #region DecryptionCopy()
            /// <summary>
            /// Copies the text of the decryption result to the clipboard.
            /// </summary>
            private void DecryptionCopy()
            {
                // Get decryption result from text box
                string decryptionResult = this.DecryptedStringControl.Text;

                // Copy decryption result to the clipboard.
                Clipboard.SetText(decryptionResult);
            }  
            #endregion

            #region DecryptString()
            /// <summary>
            /// Performs the string decryption.
            /// </summary>
            private void DecryptString()
            {
                // get string to decrypt
                string stringToDecrypt = this.StringToDecryptControl.Text.ToString();

                // get password
                string password = this.DecryptedPasswordControl.Text.ToString();

                // decrypt string
                string decryptedString = CryptographyHelper.DecryptString(stringToDecrypt, password);

                // Display Decrypted Result Text
                this.DecryptedStringControl.Text = decryptedString;
            }
            #endregion

            #region EncryptionCopy()
            /// <summary>
            /// Copies the text of the encryption result to the clipboard.
            /// </summary>
            private void EncryptionCopy()
            {
                // Get encryption result from text box
                string encryptionResult = this.EncryptedStringControl.Text.ToString();
                
                // Copy encryption result to the clipboard.
                Clipboard.SetText(encryptionResult);
            }  
            #endregion

            #region EncryptString()
            /// <summary>
            /// Performs the string encryption.
            /// </summary>
            private void EncryptString()
            {
                // get string to encrypt
                string stringToEncrypt = this.StringToEncryptControl.Text.ToString();

                // get password
                string password = this.EncryptionPasswordControl.Text.ToString();

                // encrypt string
                string encryptedString = CryptographyHelper.EncryptString(stringToEncrypt, password);

                // Display Encrypted Result Text
                this.EncryptedStringControl.Text = encryptedString;
            }  
            #endregion

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            private void Init()
            {
                // Set the passwords
                this.EncryptionPasswordControl.Text = "pokerpro";
                this.DecryptedPasswordControl.Text = "pokerpro";
            } 
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// Enables the controls based upon the state of the form.
            /// </summary>
            private void UIEnable()
            {
                // locals
                
                // encryption 
                string encryptionString;
                string encryptionPassword;
                string encryptionResult;
                bool encryptionClear;
                bool encryptionCopy;
                bool encryptionEncrypt;
                
                // decryption
                string decryptionString;
                string decryptionPassword;
                string decryptionResult;
                bool decryptionClear;
                bool decryptionCopy;
                bool decryptionDecrypt;
                
                // Get String Values From Form
                encryptionString = this.StringToEncryptControl.Text.ToString();
                encryptionPassword = this.EncryptionPasswordControl.Text.ToString();
                encryptionResult = this.EncryptedStringControl.Text.ToString();
                decryptionString = this.StringToDecryptControl.Text.ToString();
                decryptionPassword = this.DecryptedPasswordControl.Text.ToString();
                decryptionResult = this.DecryptedStringControl.Text;
                
                // Set values for enabled or disable for each control
                
                // if any of the encryption controls have a value in it, encryption clear will be enabled.
                encryptionClear = ((!String.IsNullOrEmpty(encryptionString)) || (!String.IsNullOrEmpty(encryptionString)) || (!String.IsNullOrEmpty(encryptionResult)));
                
                // if the encryption result is present, encryptionCopy will be enabled.
                encryptionCopy = (!String.IsNullOrEmpty(encryptionResult));
                
                // if string to encrypt and encryption password have a value, the encrypt button will be enabled.
                encryptionEncrypt = ((!String.IsNullOrEmpty(encryptionString)) && (!String.IsNullOrEmpty(encryptionPassword)));

                // if any of the decryption controls have a value in it, decryption clear will be deabled.
                decryptionClear = ((!String.IsNullOrEmpty(decryptionString)) || (!String.IsNullOrEmpty(decryptionPassword)) || (!String.IsNullOrEmpty(decryptionResult)));

                // if the decryption result is presdet, decryptionCopy will be deabled.
                decryptionCopy = (!String.IsNullOrEmpty(decryptionResult));

                // if string to decrypt and decryption password have a value, the decrypt button will be deabled.
                decryptionDecrypt = ((!String.IsNullOrEmpty(decryptionString)) && (!String.IsNullOrEmpty(decryptionPassword)));
                
                // Now set enabled property on each control encryption
                this.EncryptClearButton.Enabled = encryptionClear;
                this.EncryptCopyButton.Enabled = encryptionCopy;
                this.EncryptButton.Enabled = encryptionEncrypt;
                
                // Now set enabled property on each control for decryption
                this.DecryptClearButton.Enabled = decryptionClear;
                this.DecryptCopyButton.Enabled = decryptionCopy;
                this.DecryptButton.Enabled = decryptionDecrypt;
            }
            #endregion

        #endregion
               
    }
    #endregion
    
}