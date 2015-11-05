namespace ASECodeEditor
{
    partial class Editor
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
            this.editorControl1 = new MsaSQLEditor.DerivedControls.EditorControl();
            ((System.ComponentModel.ISupportInitialize)(this.editorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // editorControl1
            // 
            this.editorControl1.AllowDrop = true;
            this.editorControl1.AllStylesFont = new System.Drawing.Font("Courier New", 9.75F);
            this.editorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorControl1.IsBraceMatching = true;
            this.editorControl1.Location = new System.Drawing.Point(0, 0);
            this.editorControl1.Margins.Margin0.Width = 19;
            this.editorControl1.Name = "editorControl1";
            this.editorControl1.Size = new System.Drawing.Size(284, 261);
            this.editorControl1.Styles.BraceBad.FontName = "";
            this.editorControl1.Styles.BraceLight.FontName = "";
            this.editorControl1.Styles.ControlChar.FontName = "";
            this.editorControl1.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.editorControl1.Styles.IndentGuide.FontName = "";
            this.editorControl1.Styles.LastPredefined.FontName = "";
            this.editorControl1.Styles.LineNumber.FontName = "";
            this.editorControl1.TabIndex = 0;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.editorControl1);
            this.Name = "Editor";
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.editorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MsaSQLEditor.DerivedControls.EditorControl editorControl1;
    }
}