namespace Count_Words_in_a_Text_File__Part_1__Open_File_Dialog_Box20201030
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_createWordList = new System.Windows.Forms.Button();
            this.btn_sortWords = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_countWords = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_download = new System.Windows.Forms.Button();
            this.buttonDownloadArray = new System.Windows.Forms.Button();
            this.button1CreateWordListNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Load a Text File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Split the File into Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Count the Frequency of Each Word";
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chooseFile.Location = new System.Drawing.Point(12, 42);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(138, 42);
            this.btn_chooseFile.TabIndex = 3;
            this.btn_chooseFile.Text = "Choose The File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(156, 42);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(138, 42);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 594);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_createWordList
            // 
            this.btn_createWordList.Location = new System.Drawing.Point(312, 32);
            this.btn_createWordList.Name = "btn_createWordList";
            this.btn_createWordList.Size = new System.Drawing.Size(142, 52);
            this.btn_createWordList.TabIndex = 6;
            this.btn_createWordList.Text = "Create Word List";
            this.btn_createWordList.UseVisualStyleBackColor = true;
            this.btn_createWordList.Click += new System.EventHandler(this.btn_createWordList_Click);
            // 
            // btn_sortWords
            // 
            this.btn_sortWords.Location = new System.Drawing.Point(722, 64);
            this.btn_sortWords.Name = "btn_sortWords";
            this.btn_sortWords.Size = new System.Drawing.Size(75, 23);
            this.btn_sortWords.TabIndex = 7;
            this.btn_sortWords.Text = "Sort Words";
            this.btn_sortWords.UseVisualStyleBackColor = true;
            this.btn_sortWords.Click += new System.EventHandler(this.btn_sortWords_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(417, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 589);
            this.listBox1.TabIndex = 8;
            // 
            // btn_countWords
            // 
            this.btn_countWords.Location = new System.Drawing.Point(833, 42);
            this.btn_countWords.Name = "btn_countWords";
            this.btn_countWords.Size = new System.Drawing.Size(75, 23);
            this.btn_countWords.TabIndex = 9;
            this.btn_countWords.Text = "Count";
            this.btn_countWords.UseVisualStyleBackColor = true;
            this.btn_countWords.Click += new System.EventHandler(this.btn_countWords_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(753, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(702, 589);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(1082, 42);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(75, 23);
            this.button_download.TabIndex = 11;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // buttonDownloadArray
            // 
            this.buttonDownloadArray.Location = new System.Drawing.Point(460, 32);
            this.buttonDownloadArray.Name = "buttonDownloadArray";
            this.buttonDownloadArray.Size = new System.Drawing.Size(124, 52);
            this.buttonDownloadArray.TabIndex = 12;
            this.buttonDownloadArray.Text = "DownloadArray";
            this.buttonDownloadArray.UseVisualStyleBackColor = true;
            this.buttonDownloadArray.Click += new System.EventHandler(this.buttonDownloadArray_Click);
            // 
            // button1CreateWordListNormal
            // 
            this.button1CreateWordListNormal.Location = new System.Drawing.Point(648, 32);
            this.button1CreateWordListNormal.Name = "button1CreateWordListNormal";
            this.button1CreateWordListNormal.Size = new System.Drawing.Size(137, 23);
            this.button1CreateWordListNormal.TabIndex = 13;
            this.button1CreateWordListNormal.Text = "Create Word List Normal";
            this.button1CreateWordListNormal.UseVisualStyleBackColor = true;
            this.button1CreateWordListNormal.Click += new System.EventHandler(this.button1CreateWordListNormal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 696);
            this.Controls.Add(this.button1CreateWordListNormal);
            this.Controls.Add(this.buttonDownloadArray);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_countWords);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_sortWords);
            this.Controls.Add(this.btn_createWordList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Word Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_createWordList;
        private System.Windows.Forms.Button btn_sortWords;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_countWords;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button buttonDownloadArray;
        private System.Windows.Forms.Button button1CreateWordListNormal;
    }
}

