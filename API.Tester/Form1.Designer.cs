namespace API.Tester
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
            this.getDocumentBtn = new System.Windows.Forms.Button();
            this.getDocumentsBtn = new System.Windows.Forms.Button();
            this.servideResultRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.documentIdTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateFromDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateToDTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // getDocumentBtn
            // 
            this.getDocumentBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.getDocumentBtn.Location = new System.Drawing.Point(435, 19);
            this.getDocumentBtn.Name = "getDocumentBtn";
            this.getDocumentBtn.Size = new System.Drawing.Size(146, 80);
            this.getDocumentBtn.TabIndex = 0;
            this.getDocumentBtn.Text = "Wyślij zapytanie";
            this.getDocumentBtn.UseVisualStyleBackColor = true;
            this.getDocumentBtn.Click += new System.EventHandler(this.getDocumentBtn_Click);
            // 
            // getDocumentsBtn
            // 
            this.getDocumentsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.getDocumentsBtn.Location = new System.Drawing.Point(435, 19);
            this.getDocumentsBtn.Name = "getDocumentsBtn";
            this.getDocumentsBtn.Size = new System.Drawing.Size(146, 154);
            this.getDocumentsBtn.TabIndex = 1;
            this.getDocumentsBtn.Text = "Wyślij zapytanie";
            this.getDocumentsBtn.UseVisualStyleBackColor = true;
            this.getDocumentsBtn.Click += new System.EventHandler(this.getDocumentsBtn_Click);
            // 
            // servideResultRTB
            // 
            this.servideResultRTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.servideResultRTB.Location = new System.Drawing.Point(0, 278);
            this.servideResultRTB.Name = "servideResultRTB";
            this.servideResultRTB.Size = new System.Drawing.Size(584, 483);
            this.servideResultRTB.TabIndex = 2;
            this.servideResultRTB.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.documentIdTB);
            this.groupBox1.Controls.Add(this.getDocumentBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pobieranie dokumentu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID dokumentu";
            // 
            // documentIdTB
            // 
            this.documentIdTB.Location = new System.Drawing.Point(61, 48);
            this.documentIdTB.Name = "documentIdTB";
            this.documentIdTB.Size = new System.Drawing.Size(280, 23);
            this.documentIdTB.TabIndex = 1;
            this.documentIdTB.Text = "110000031";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateFromDTP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateToDTP);
            this.groupBox2.Controls.Add(this.getDocumentsBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 176);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pobieranie dokumentów";
            // 
            // dateFromDTP
            // 
            this.dateFromDTP.Location = new System.Drawing.Point(61, 49);
            this.dateFromDTP.Name = "dateFromDTP";
            this.dateFromDTP.Size = new System.Drawing.Size(280, 23);
            this.dateFromDTP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data do";
            // 
            // dateToDTP
            // 
            this.dateToDTP.Location = new System.Drawing.Point(61, 112);
            this.dateToDTP.Name = "dateToDTP";
            this.dateToDTP.Size = new System.Drawing.Size(280, 23);
            this.dateToDTP.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.servideResultRTB);
            this.Name = "Form1";
            this.Text = "API TESTER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getDocumentBtn;
        private System.Windows.Forms.Button getDocumentsBtn;
        private System.Windows.Forms.RichTextBox servideResultRTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox documentIdTB;
        private System.Windows.Forms.DateTimePicker dateToDTP;
        private System.Windows.Forms.DateTimePicker dateFromDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

