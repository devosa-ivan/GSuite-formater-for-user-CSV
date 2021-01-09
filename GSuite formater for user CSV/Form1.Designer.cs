namespace GSuite_formater_for_user_CSV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_betolt_CSV = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_feldolgoz = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_save_new_CSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1242, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.WordWrap = false;
            // 
            // button_betolt_CSV
            // 
            this.button_betolt_CSV.Location = new System.Drawing.Point(12, 115);
            this.button_betolt_CSV.Name = "button_betolt_CSV";
            this.button_betolt_CSV.Size = new System.Drawing.Size(120, 33);
            this.button_betolt_CSV.TabIndex = 1;
            this.button_betolt_CSV.Text = "1. CSV betöltés";
            this.button_betolt_CSV.UseVisualStyleBackColor = true;
            this.button_betolt_CSV.Click += new System.EventHandler(this.button_betolt_CSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV|*.csv|Mind|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 154);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1242, 277);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.WordWrap = false;
            // 
            // button_feldolgoz
            // 
            this.button_feldolgoz.Location = new System.Drawing.Point(160, 115);
            this.button_feldolgoz.Name = "button_feldolgoz";
            this.button_feldolgoz.Size = new System.Drawing.Size(120, 33);
            this.button_feldolgoz.TabIndex = 3;
            this.button_feldolgoz.Text = "2. Feldolgozás";
            this.button_feldolgoz.UseVisualStyleBackColor = true;
            this.button_feldolgoz.Click += new System.EventHandler(this.button_feldolgoz_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "gsuite-user-list-to-upload";
            this.saveFileDialog1.Filter = "CSV|*.csv|Mind|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button_save_new_CSV
            // 
            this.button_save_new_CSV.Location = new System.Drawing.Point(309, 114);
            this.button_save_new_CSV.Name = "button_save_new_CSV";
            this.button_save_new_CSV.Size = new System.Drawing.Size(120, 33);
            this.button_save_new_CSV.TabIndex = 4;
            this.button_save_new_CSV.Text = "3. új CSV mentése";
            this.button_save_new_CSV.UseVisualStyleBackColor = true;
            this.button_save_new_CSV.Click += new System.EventHandler(this.button_save_new_CSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.button_save_new_CSV);
            this.Controls.Add(this.button_feldolgoz);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button_betolt_CSV);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GSuite formater for user CSV,  ©2020, Dr. Devosa Iván";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_betolt_CSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_feldolgoz;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_save_new_CSV;
    }
}

