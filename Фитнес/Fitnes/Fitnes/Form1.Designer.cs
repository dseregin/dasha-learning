namespace Fitnes
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
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonAddDay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayLabelValue = new System.Windows.Forms.Label();
            this.DayDataGridView = new System.Windows.Forms.DataGridView();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.caloriesLabelValue = new System.Windows.Forms.Label();
            this.ExName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capasity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(12, 12);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 0;
            // 
            // buttonAddDay
            // 
            this.buttonAddDay.Location = new System.Drawing.Point(118, 12);
            this.buttonAddDay.Name = "buttonAddDay";
            this.buttonAddDay.Size = new System.Drawing.Size(121, 23);
            this.buttonAddDay.TabIndex = 1;
            this.buttonAddDay.Text = "Добавать день";
            this.buttonAddDay.UseVisualStyleBackColor = true;
            this.buttonAddDay.Click += new System.EventHandler(this.buttonAddDay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Дай день";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(13, 129);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(37, 13);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "День:";
            this.dayLabel.Visible = false;
            // 
            // dayLabelValue
            // 
            this.dayLabelValue.AutoSize = true;
            this.dayLabelValue.Location = new System.Drawing.Point(75, 129);
            this.dayLabelValue.Name = "dayLabelValue";
            this.dayLabelValue.Size = new System.Drawing.Size(34, 13);
            this.dayLabelValue.TabIndex = 4;
            this.dayLabelValue.Text = "День";
            this.dayLabelValue.Visible = false;
            // 
            // DayDataGridView
            // 
            this.DayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExName,
            this.SetCount,
            this.repitCount,
            this.Capasity});
            this.DayDataGridView.Location = new System.Drawing.Point(12, 154);
            this.DayDataGridView.Name = "DayDataGridView";
            this.DayDataGridView.Size = new System.Drawing.Size(444, 203);
            this.DayDataGridView.TabIndex = 8;
            this.DayDataGridView.Visible = false;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(179, 129);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(53, 13);
            this.caloriesLabel.TabIndex = 5;
            this.caloriesLabel.Text = "Калории:";
            this.caloriesLabel.Visible = false;
            // 
            // caloriesLabelValue
            // 
            this.caloriesLabelValue.AutoSize = true;
            this.caloriesLabelValue.Location = new System.Drawing.Point(241, 129);
            this.caloriesLabelValue.Name = "caloriesLabelValue";
            this.caloriesLabelValue.Size = new System.Drawing.Size(50, 13);
            this.caloriesLabelValue.TabIndex = 6;
            this.caloriesLabelValue.Text = "Калории";
            this.caloriesLabelValue.Visible = false;
            // 
            // ExName
            // 
            this.ExName.HeaderText = "Упражнение";
            this.ExName.Name = "ExName";
            // 
            // SetCount
            // 
            this.SetCount.HeaderText = "Подходы";
            this.SetCount.Name = "SetCount";
            // 
            // repitCount
            // 
            this.repitCount.HeaderText = "Количество повторений";
            this.repitCount.Name = "repitCount";
            // 
            // Capasity
            // 
            this.Capasity.HeaderText = "capasity";
            this.Capasity.Name = "Capasity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DayDataGridView);
            this.Controls.Add(this.caloriesLabelValue);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.dayLabelValue);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddDay);
            this.Controls.Add(this.textBoxDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonAddDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label dayLabelValue;
        private System.Windows.Forms.DataGridView DayDataGridView;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label caloriesLabelValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn repitCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capasity;
    }
}

