
namespace PatientsSort
{
    partial class SearchPatientsForm
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
            this.btnFindByName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindBySurname = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCritical = new System.Windows.Forms.Button();
            this.btnLessThan = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.listBoxByName = new System.Windows.Forms.ListBox();
            this.listBoxBySurname = new System.Windows.Forms.ListBox();
            this.listBoxByCritical = new System.Windows.Forms.ListBox();
            this.listBoxByAge = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(12, 55);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(136, 23);
            this.btnFindByName.TabIndex = 0;
            this.btnFindByName.Text = "Поиск по имени";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя:";
            // 
            // btnFindBySurname
            // 
            this.btnFindBySurname.Location = new System.Drawing.Point(194, 55);
            this.btnFindBySurname.Name = "btnFindBySurname";
            this.btnFindBySurname.Size = new System.Drawing.Size(136, 23);
            this.btnFindBySurname.TabIndex = 0;
            this.btnFindBySurname.Text = "Поиск по фамлии";
            this.btnFindBySurname.UseVisualStyleBackColor = true;
            this.btnFindBySurname.Click += new System.EventHandler(this.btnFindBySurname_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(194, 26);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(136, 23);
            this.textBoxSurname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия:";
            // 
            // btnCritical
            // 
            this.btnCritical.Location = new System.Drawing.Point(374, 40);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(136, 38);
            this.btnCritical.TabIndex = 0;
            this.btnCritical.Text = "Поиск критических пациентов";
            this.btnCritical.UseVisualStyleBackColor = true;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            // 
            // btnLessThan
            // 
            this.btnLessThan.Location = new System.Drawing.Point(549, 55);
            this.btnLessThan.Name = "btnLessThan";
            this.btnLessThan.Size = new System.Drawing.Size(136, 23);
            this.btnLessThan.TabIndex = 0;
            this.btnLessThan.Text = "Поиск по возрасту";
            this.btnLessThan.UseVisualStyleBackColor = true;
            this.btnLessThan.Click += new System.EventHandler(this.btnLessThan_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(549, 26);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(136, 23);
            this.textBoxAge.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возраст менее:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(279, 318);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 24);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Text = "Очистить поля";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // listBoxByName
            // 
            this.listBoxByName.FormattingEnabled = true;
            this.listBoxByName.ItemHeight = 15;
            this.listBoxByName.Location = new System.Drawing.Point(12, 90);
            this.listBoxByName.Name = "listBoxByName";
            this.listBoxByName.Size = new System.Drawing.Size(136, 214);
            this.listBoxByName.TabIndex = 4;
            // 
            // listBoxBySurname
            // 
            this.listBoxBySurname.FormattingEnabled = true;
            this.listBoxBySurname.ItemHeight = 15;
            this.listBoxBySurname.Location = new System.Drawing.Point(194, 90);
            this.listBoxBySurname.Name = "listBoxBySurname";
            this.listBoxBySurname.Size = new System.Drawing.Size(136, 214);
            this.listBoxBySurname.TabIndex = 4;
            // 
            // listBoxByCritical
            // 
            this.listBoxByCritical.FormattingEnabled = true;
            this.listBoxByCritical.ItemHeight = 15;
            this.listBoxByCritical.Location = new System.Drawing.Point(374, 90);
            this.listBoxByCritical.Name = "listBoxByCritical";
            this.listBoxByCritical.Size = new System.Drawing.Size(136, 214);
            this.listBoxByCritical.TabIndex = 4;
            // 
            // listBoxByAge
            // 
            this.listBoxByAge.FormattingEnabled = true;
            this.listBoxByAge.ItemHeight = 15;
            this.listBoxByAge.Location = new System.Drawing.Point(549, 90);
            this.listBoxByAge.Name = "listBoxByAge";
            this.listBoxByAge.Size = new System.Drawing.Size(136, 214);
            this.listBoxByAge.TabIndex = 4;
            // 
            // SearchPatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 354);
            this.Controls.Add(this.listBoxByAge);
            this.Controls.Add(this.listBoxByCritical);
            this.Controls.Add(this.listBoxBySurname);
            this.Controls.Add(this.listBoxByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.btnLessThan);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCritical);
            this.Controls.Add(this.btnFindBySurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnFindByName);
            this.Name = "SearchPatientsForm";
            this.Text = "Поиск пациентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindBySurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCritical;
        private System.Windows.Forms.Button btnLessThan;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ListBox listBoxByName;
        private System.Windows.Forms.ListBox listBoxBySurname;
        private System.Windows.Forms.ListBox listBoxByCritical;
        private System.Windows.Forms.ListBox listBoxByAge;
    }
}

