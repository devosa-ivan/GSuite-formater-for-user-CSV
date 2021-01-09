using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//2020.07.04., 05.
namespace GSuite_formater_for_user_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_betolt_CSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
                }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
        }

        private void button_feldolgoz_Click(object sender, EventArgs e)
        {
            foreach(string s in richTextBox1.Lines)
            {
                richTextBox2.AppendText(Environment.NewLine +  RemoveDiacritics(s) + "@bonifert.sulinet.hu,IdeiglenesJelszo,,/,,Active,Never logged in,,,,,,,,,,,,,,,,False, False,,,,0.0GB,0.0GB,Unlimited,False,");
            }
            
        }

        //ékezetek eltávolítása a nevekből
        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void button_save_new_CSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox2.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
