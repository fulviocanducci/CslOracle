namespace WinForm
{
    partial class FrmPeopleUpdate
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
            groupBox1 = new GroupBox();
            ChkActive = new CheckBox();
            TxtCreatedAt = new MaskedTextBox();
            label3 = new Label();
            TxtPrice = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TxtName = new TextBox();
            ButEnd = new Button();
            ButSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChkActive);
            groupBox1.Controls.Add(TxtCreatedAt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ChkActive
            // 
            ChkActive.AutoSize = true;
            ChkActive.Location = new Point(6, 167);
            ChkActive.Name = "ChkActive";
            ChkActive.Size = new Size(54, 19);
            ChkActive.TabIndex = 7;
            ChkActive.Text = "Ativo";
            ChkActive.UseVisualStyleBackColor = true;
            // 
            // TxtCreatedAt
            // 
            TxtCreatedAt.Location = new Point(6, 135);
            TxtCreatedAt.Mask = "00/00/0000 90:00";
            TxtCreatedAt.Name = "TxtCreatedAt";
            TxtCreatedAt.Size = new Size(135, 23);
            TxtCreatedAt.TabIndex = 6;
            TxtCreatedAt.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Preço";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(6, 86);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(141, 23);
            TxtPrice.TabIndex = 4;
            TxtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 117);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Criado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome Completo";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(6, 37);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(251, 23);
            TxtName.TabIndex = 2;
            // 
            // ButEnd
            // 
            ButEnd.Location = new Point(201, 206);
            ButEnd.Name = "ButEnd";
            ButEnd.Size = new Size(75, 31);
            ButEnd.TabIndex = 9;
            ButEnd.Text = "Fecha&r";
            ButEnd.UseVisualStyleBackColor = true;
            ButEnd.Click += ButEnd_Click;
            // 
            // ButSave
            // 
            ButSave.Location = new Point(12, 206);
            ButSave.Name = "ButSave";
            ButSave.Size = new Size(75, 31);
            ButSave.TabIndex = 8;
            ButSave.Text = "&Salvar";
            ButSave.UseVisualStyleBackColor = true;
            ButSave.Click += ButSave_Click;
            // 
            // FrmPeopleUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButEnd;
            ClientSize = new Size(287, 248);
            Controls.Add(ButEnd);
            Controls.Add(ButSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeopleUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas: Modificações";
            Load += FrmPeopleUpdate_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox ChkActive;
        private MaskedTextBox TxtCreatedAt;
        private Label label3;
        private TextBox TxtPrice;
        private Label label2;
        private Label label1;
        private TextBox TxtName;
        private Button ButEnd;
        private Button ButSave;
    }
}