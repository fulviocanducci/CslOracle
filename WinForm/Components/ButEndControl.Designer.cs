namespace WinForm.Components
{
    partial class ButEndControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButEnd = new Button();
            SuspendLayout();
            // 
            // ButEnd
            // 
            ButEnd.Image = Properties.Resource.Icons_Close;
            ButEnd.Location = new Point(0, 0);
            ButEnd.Name = "ButEnd";
            ButEnd.Size = new Size(76, 31);
            ButEnd.TabIndex = 9;
            ButEnd.Text = "Fecha&r";
            ButEnd.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButEnd.UseVisualStyleBackColor = true;
            ButEnd.Click += ButEnd_Click;
            // 
            // ButEndControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButEnd);
            Name = "ButEndControl";
            Size = new Size(76, 31);
            ResumeLayout(false);
        }

        #endregion

        private Button ButEnd;
    }
}
