using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace CaesarCipherGui
{
    public partial class CaesarCipher : Form
    {
        string textInput = string.Empty;
        char[] cipher = new char[] {' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\n'};
        public int cipherShift = 0;

        public CaesarCipher()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cipherShift = (int)NumericShift.Value;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (EncryptRdo.Checked) Encrypt();
            if (DecryptRdo.Checked) Decrypt();
            TextOutput.Text = textInput;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse text files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextInput.Text = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    textInput = reader.ReadToEnd();
                    TextOutput.Text = textInput;
                }
            }
        }

        private void EncryptRdo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DecryptRdo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt()
        {
            char[] message = textInput.ToLower().ToCharArray();
            char[] newMessage = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                int position = Array.IndexOf(cipher, letter);
                int newPosition = (position + cipherShift) % cipher.Length;

                if (newPosition < 0) newPosition += (newPosition + cipher.Length);

                char newLetter = cipher[newPosition];
                newMessage[i] = newLetter;
            }
            
            textInput = (String.Join("", newMessage));
        }

        private void Decrypt()
        {
            char[] message = textInput.ToLower().ToCharArray();
            char[] newMessage = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                int position = Array.IndexOf(cipher, letter);
                int newPosition = (position - cipherShift) % cipher.Length;

                if (newPosition < 0) newPosition += (newPosition + cipher.Length);

                char newLetter = cipher[newPosition];
                newMessage[i] = newLetter;
            }

            textInput = (String.Join("", newMessage));
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textInput);
            }
        }
    }
}
