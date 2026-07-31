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
            label1 = new Label();
            TxtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtPrice = new TextBox();
            TxtCreatedAt = new MaskedTextBox();
            ChkActive = new CheckBox();
            ButEnd = new Button();
            ButSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome Completo";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(6, 26);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(251, 23);
            TxtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Criado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Preço";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(6, 75);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(141, 23);
            TxtPrice.TabIndex = 7;
            // 
            // TxtCreatedAt
            // 
            TxtCreatedAt.Location = new Point(6, 124);
            TxtCreatedAt.Mask = "00/00/0000 90:00";
            TxtCreatedAt.Name = "TxtCreatedAt";
            TxtCreatedAt.Size = new Size(135, 23);
            TxtCreatedAt.TabIndex = 9;
            TxtCreatedAt.ValidatingType = typeof(DateTime);
            // 
            // ChkActive
            // 
            ChkActive.AutoSize = true;
            ChkActive.Location = new Point(6, 156);
            ChkActive.Name = "ChkActive";
            ChkActive.Size = new Size(54, 19);
            ChkActive.TabIndex = 10;
            ChkActive.Text = "Ativo";
            ChkActive.UseVisualStyleBackColor = true;
            // 
            // ButEnd
            // 
            ButEnd.Location = new Point(182, 191);
            ButEnd.Name = "ButEnd";
            ButEnd.Size = new Size(75, 31);
            ButEnd.TabIndex = 12;
            ButEnd.Text = "Fecha&r";
            ButEnd.UseVisualStyleBackColor = true;
            ButEnd.Click += ButEnd_Click;
            // 
            // ButSave
            // 
            ButSave.Location = new Point(6, 191);
            ButSave.Name = "ButSave";
            ButSave.Size = new Size(75, 31);
            ButSave.TabIndex = 11;
            ButSave.Text = "&Salvar";
            ButSave.UseVisualStyleBackColor = true;
            ButSave.Click += ButSave_Click;
            // 
            // FrmPeopleUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 227);
            Controls.Add(ButEnd);
            Controls.Add(ButSave);
            Controls.Add(ChkActive);
            Controls.Add(TxtCreatedAt);
            Controls.Add(label3);
            Controls.Add(TxtPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeopleUpdate";
            Text = "Pessoas: Modificações";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private Label label2;
        private Label label3;
        private TextBox TxtPrice;
        private MaskedTextBox TxtCreatedAt;
        private CheckBox ChkActive;
        private Button ButEnd;
        private Button ButSave;
    }
}