namespace WinForm
{
    partial class FrmPeople
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewPeoples = new DataGridView();
            ColumnPeopleId = new DataGridViewTextBoxColumn();
            ColumnPeopleName = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            BtuNew = new Button();
            ButEnd = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPeoples).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewPeoples
            // 
            DataGridViewPeoples.AllowUserToAddRows = false;
            DataGridViewPeoples.AllowUserToDeleteRows = false;
            DataGridViewPeoples.BackgroundColor = Color.LightYellow;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewPeoples.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewPeoples.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPeoples.Columns.AddRange(new DataGridViewColumn[] { ColumnPeopleId, ColumnPeopleName });
            DataGridViewPeoples.Location = new Point(9, 55);
            DataGridViewPeoples.Name = "DataGridViewPeoples";
            DataGridViewPeoples.ReadOnly = true;
            DataGridViewPeoples.Size = new Size(607, 289);
            DataGridViewPeoples.TabIndex = 0;
            // 
            // ColumnPeopleId
            // 
            ColumnPeopleId.DataPropertyName = "Id";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "000000";
            dataGridViewCellStyle5.NullValue = null;
            ColumnPeopleId.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnPeopleId.HeaderText = "Id";
            ColumnPeopleId.Name = "ColumnPeopleId";
            ColumnPeopleId.ReadOnly = true;
            ColumnPeopleId.ToolTipText = "Identificação da Pessoa";
            // 
            // ColumnPeopleName
            // 
            ColumnPeopleName.DataPropertyName = "Name";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnPeopleName.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnPeopleName.HeaderText = "Nome";
            ColumnPeopleName.Name = "ColumnPeopleName";
            ColumnPeopleName.ReadOnly = true;
            ColumnPeopleName.ToolTipText = "Nome Completo";
            ColumnPeopleName.Width = 445;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(607, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Busca";
            // 
            // BtuNew
            // 
            BtuNew.Location = new Point(9, 350);
            BtuNew.Name = "BtuNew";
            BtuNew.Size = new Size(75, 31);
            BtuNew.TabIndex = 3;
            BtuNew.Text = "&Novo";
            BtuNew.UseVisualStyleBackColor = true;
            BtuNew.Click += BtuNew_Click;
            // 
            // ButEnd
            // 
            ButEnd.Location = new Point(541, 350);
            ButEnd.Name = "ButEnd";
            ButEnd.Size = new Size(75, 31);
            ButEnd.TabIndex = 4;
            ButEnd.Text = "Sai&r";
            ButEnd.UseVisualStyleBackColor = true;
            ButEnd.Click += ButEnd_Click;
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 389);
            Controls.Add(ButEnd);
            Controls.Add(BtuNew);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(DataGridViewPeoples);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "FrmPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewPeoples).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewPeoples;
        private TextBox textBox1;
        private Label label1;
        private Button BtuNew;
        private Button ButEnd;
        private DataGridViewTextBoxColumn ColumnPeopleId;
        private DataGridViewTextBoxColumn ColumnPeopleName;
    }
}
