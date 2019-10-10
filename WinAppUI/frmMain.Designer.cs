namespace WinAppUI {
    partial class frmMain {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.lbStaff = new System.Windows.Forms.ListBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.dpHireDate = new System.Windows.Forms.DateTimePicker();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tlDate = new System.Windows.Forms.Label();
            this.tlRate = new System.Windows.Forms.Label();
            this.tlName = new System.Windows.Forms.Label();
            this.tlGroup = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbRelations = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tlCalcPerson = new System.Windows.Forms.Label();
            this.tbSalaryPerson = new System.Windows.Forms.TextBox();
            this.dpCalcDate = new System.Windows.Forms.DateTimePicker();
            this.tlCalcDate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(12, 225);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(225, 25);
            this.btnUpdateList.TabIndex = 0;
            this.btnUpdateList.Text = "Обновить";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.ReloadStaffList);
            // 
            // lbStaff
            // 
            this.lbStaff.FormattingEnabled = true;
            this.lbStaff.Location = new System.Drawing.Point(12, 12);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(225, 212);
            this.lbStaff.TabIndex = 1;
            this.lbStaff.SelectedIndexChanged += new System.EventHandler(this.lbStaff_SelectedIndexChanged);
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(154, 16);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(223, 21);
            this.cbGroup.TabIndex = 2;
            // 
            // dpHireDate
            // 
            this.dpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpHireDate.Location = new System.Drawing.Point(154, 95);
            this.dpHireDate.Name = "dpHireDate";
            this.dpHireDate.Size = new System.Drawing.Size(223, 20);
            this.dpHireDate.TabIndex = 5;
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(154, 69);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(223, 20);
            this.tbRate.TabIndex = 4;
            this.tbRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRate.TextChanged += new System.EventHandler(this.tbRate_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(223, 20);
            this.tbName.TabIndex = 4;
            // 
            // tlDate
            // 
            this.tlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlDate.Location = new System.Drawing.Point(6, 94);
            this.tlDate.Name = "tlDate";
            this.tlDate.Size = new System.Drawing.Size(142, 21);
            this.tlDate.TabIndex = 3;
            this.tlDate.Text = "Дата приёма :";
            this.tlDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlRate
            // 
            this.tlRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlRate.Location = new System.Drawing.Point(6, 68);
            this.tlRate.Name = "tlRate";
            this.tlRate.Size = new System.Drawing.Size(142, 21);
            this.tlRate.TabIndex = 3;
            this.tlRate.Text = "Базовая ставка :";
            this.tlRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlName
            // 
            this.tlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlName.Location = new System.Drawing.Point(6, 42);
            this.tlName.Name = "tlName";
            this.tlName.Size = new System.Drawing.Size(142, 21);
            this.tlName.TabIndex = 3;
            this.tlName.Text = "Имя :";
            this.tlName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlGroup
            // 
            this.tlGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlGroup.Location = new System.Drawing.Point(6, 15);
            this.tlGroup.Name = "tlGroup";
            this.tlGroup.Size = new System.Drawing.Size(142, 21);
            this.tlGroup.TabIndex = 3;
            this.tlGroup.Text = "Группа :";
            this.tlGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(243, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 238);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dpHireDate);
            this.tabPage1.Controls.Add(this.tlName);
            this.tabPage1.Controls.Add(this.tbRate);
            this.tabPage1.Controls.Add(this.cbGroup);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.tlGroup);
            this.tabPage1.Controls.Add(this.tlDate);
            this.tabPage1.Controls.Add(this.tlRate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аттрибуты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbRelations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подчиненные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbRelations
            // 
            this.lbRelations.FormattingEnabled = true;
            this.lbRelations.Location = new System.Drawing.Point(6, 6);
            this.lbRelations.Name = "lbRelations";
            this.lbRelations.Size = new System.Drawing.Size(304, 199);
            this.lbRelations.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalculate);
            this.tabPage3.Controls.Add(this.tlCalcPerson);
            this.tabPage3.Controls.Add(this.tbSalaryPerson);
            this.tabPage3.Controls.Add(this.dpCalcDate);
            this.tabPage3.Controls.Add(this.tlCalcDate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(385, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расчет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(256, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tlCalcPerson
            // 
            this.tlCalcPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlCalcPerson.Location = new System.Drawing.Point(6, 88);
            this.tlCalcPerson.Name = "tlCalcPerson";
            this.tlCalcPerson.Size = new System.Drawing.Size(244, 21);
            this.tlCalcPerson.TabIndex = 8;
            this.tlCalcPerson.Text = "Зарплата сотрудника :";
            this.tlCalcPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSalaryPerson
            // 
            this.tbSalaryPerson.Location = new System.Drawing.Point(256, 89);
            this.tbSalaryPerson.Name = "tbSalaryPerson";
            this.tbSalaryPerson.ReadOnly = true;
            this.tbSalaryPerson.Size = new System.Drawing.Size(124, 20);
            this.tbSalaryPerson.TabIndex = 9;
            this.tbSalaryPerson.Text = "0";
            this.tbSalaryPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dpCalcDate
            // 
            this.dpCalcDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCalcDate.Location = new System.Drawing.Point(189, 16);
            this.dpCalcDate.Name = "dpCalcDate";
            this.dpCalcDate.Size = new System.Drawing.Size(191, 20);
            this.dpCalcDate.TabIndex = 7;
            this.dpCalcDate.ValueChanged += new System.EventHandler(this.dpCalcDate_ValueChanged);
            // 
            // tlCalcDate
            // 
            this.tlCalcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlCalcDate.Location = new System.Drawing.Point(3, 15);
            this.tlCalcDate.Name = "tlCalcDate";
            this.tlCalcDate.Size = new System.Drawing.Size(180, 21);
            this.tlCalcDate.TabIndex = 6;
            this.tlCalcDate.Text = "Расчет на дату :";
            this.tlCalcDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 257);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.btnUpdateList);
            this.Name = "frmMain";
            this.Text = "HR Calculator 4000";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.ListBox lbStaff;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label tlGroup;
        private System.Windows.Forms.Label tlRate;
        private System.Windows.Forms.Label tlName;
        private System.Windows.Forms.Label tlDate;
        private System.Windows.Forms.DateTimePicker dpHireDate;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbRelations;
        private System.Windows.Forms.DateTimePicker dpCalcDate;
        private System.Windows.Forms.Label tlCalcDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label tlCalcPerson;
        private System.Windows.Forms.TextBox tbSalaryPerson;
    }
}

