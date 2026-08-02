namespace WinForm.Components
{
    partial class ButNewControl
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
            ButNew = new Button();
            SuspendLayout();
            // 
            // ButNew
            // 
            ButNew.Image = Properties.Resource.Icons_New;
            ButNew.Location = new Point(0, 0);
            ButNew.Name = "ButNew";
            ButNew.Size = new Size(75, 31);
            ButNew.TabIndex = 4;
            ButNew.Text = "&Novo";
            ButNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButNew.UseVisualStyleBackColor = true;
            ButNew.Click += ButNew_Click;
            // 
            // ButNewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButNew);
            Name = "ButNewControl";
            Size = new Size(75, 31);
            ResumeLayout(false);
        }

        #endregion

        private Button ButNew;
    }
}
