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
            TxtSearch = new TextBox();
            LblSearch = new Label();
            ButEnd = new WinForm.Components.ButEndControl();
            ButNew = new WinForm.Components.ButNewControl();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPeoples).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewPeoples
            // 
            DataGridViewPeoples.AllowUserToAddRows = false;
            DataGridViewPeoples.AllowUserToDeleteRows = false;
            DataGridViewPeoples.AllowUserToResizeColumns = false;
            DataGridViewPeoples.AllowUserToResizeRows = false;
            DataGridViewPeoples.BackgroundColor = Color.White;
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
            DataGridViewPeoples.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewPeoples.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewPeoples.ShowCellErrors = false;
            DataGridViewPeoples.ShowCellToolTips = false;
            DataGridViewPeoples.ShowEditingIcon = false;
            DataGridViewPeoples.ShowRowErrors = false;
            DataGridViewPeoples.Size = new Size(605, 275);
            DataGridViewPeoples.TabIndex = 2;
            DataGridViewPeoples.CellDoubleClick += DataGridViewPeoples_CellDoubleClick;
            DataGridViewPeoples.KeyDown += DataGridViewPeoples_KeyDown;
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
            // TxtSearch
            // 
            TxtSearch.Location = new Point(9, 26);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(605, 23);
            TxtSearch.TabIndex = 1;
            TxtSearch.KeyUp += TxtSearch_KeyUp;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Location = new Point(9, 8);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(38, 15);
            LblSearch.TabIndex = 0;
            LblSearch.Text = "&Busca";
            // 
            // ButEnd
            // 
            ButEnd.Location = new Point(538, 338);
            ButEnd.Name = "ButEnd";
            ButEnd.Size = new Size(76, 31);
            ButEnd.TabIndex = 5;
            ButEnd.OnPressed += ButEnd_OnPressed;
            // 
            // ButNew
            // 
            ButNew.Location = new Point(9, 338);
            ButNew.Name = "ButNew";
            ButNew.Size = new Size(75, 31);
            ButNew.TabIndex = 6;
            ButNew.OnPressed += ButNew_OnPressed;
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 377);
            Controls.Add(ButNew);
            Controls.Add(ButEnd);
            Controls.Add(LblSearch);
            Controls.Add(TxtSearch);
            Controls.Add(DataGridViewPeoples);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas";
            Load += FrmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewPeoples).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewPeoples;
        private TextBox TxtSearch;
        private Label LblSearch;
        private DataGridViewTextBoxColumn ColumnPeopleId;
        private DataGridViewTextBoxColumn ColumnPeopleName;
        private Components.ButEndControl ButEnd;
        private Components.ButNewControl ButNew;
    }
}
