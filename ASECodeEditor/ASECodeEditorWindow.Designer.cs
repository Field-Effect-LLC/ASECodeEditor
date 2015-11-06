using System;
using System.Runtime.InteropServices;
namespace ASECodeEditor
{
    partial class ASECodeEditorWindow
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
            if (disposing)
            {
                if (this.db != null)
                    db.Dispose();

                if (this.Recordset != null)
                    this.Recordset.Close();

                if (this._EditorWindow != null)
                    this._EditorWindow.Dispose();

                if (components != null)
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KeyValue = new System.Windows.Forms.Label();
            this.PrevRecord = new System.Windows.Forms.Button();
            this.CurrRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LangField = new System.Windows.Forms.TextBox();
            this.TableKey = new System.Windows.Forms.TextBox();
            this.FieldName = new System.Windows.Forms.TextBox();
            this.SaveRecord = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.TableName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Field Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Table Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key:";
            // 
            // KeyValue
            // 
            this.KeyValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyValue.Location = new System.Drawing.Point(78, 200);
            this.KeyValue.Name = "KeyValue";
            this.KeyValue.Size = new System.Drawing.Size(133, 23);
            this.KeyValue.TabIndex = 9;
            this.KeyValue.Text = "<Key Value Here>";
            // 
            // PrevRecord
            // 
            this.PrevRecord.Location = new System.Drawing.Point(25, 227);
            this.PrevRecord.Name = "PrevRecord";
            this.PrevRecord.Size = new System.Drawing.Size(22, 23);
            this.PrevRecord.TabIndex = 6;
            this.PrevRecord.Text = "<";
            this.PrevRecord.UseVisualStyleBackColor = true;
            this.PrevRecord.Click += new System.EventHandler(this.PrevRecord_Click);
            // 
            // CurrRecord
            // 
            this.CurrRecord.Location = new System.Drawing.Point(189, 227);
            this.CurrRecord.Name = "CurrRecord";
            this.CurrRecord.Size = new System.Drawing.Size(22, 23);
            this.CurrRecord.TabIndex = 7;
            this.CurrRecord.Text = ">";
            this.CurrRecord.UseVisualStyleBackColor = true;
            this.CurrRecord.Click += new System.EventHandler(this.CurrRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Language:";
            // 
            // Language
            // 
            this.Language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Language.Location = new System.Drawing.Point(82, 157);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(130, 20);
            this.Language.TabIndex = 5;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(81, 129);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(57, 22);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lang Field:";
            // 
            // LangField
            // 
            this.LangField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LangField.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASECodeEditor.Properties.Settings.Default, "LanguageField", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LangField.Location = new System.Drawing.Point(84, 98);
            this.LangField.Name = "LangField";
            this.LangField.Size = new System.Drawing.Size(130, 20);
            this.LangField.TabIndex = 3;
            this.LangField.Text = global::ASECodeEditor.Properties.Settings.Default.LanguageField;
            // 
            // TableKey
            // 
            this.TableKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASECodeEditor.Properties.Settings.Default, "LastTableKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TableKey.Location = new System.Drawing.Point(84, 46);
            this.TableKey.Name = "TableKey";
            this.TableKey.Size = new System.Drawing.Size(130, 20);
            this.TableKey.TabIndex = 1;
            this.TableKey.Text = global::ASECodeEditor.Properties.Settings.Default.LastTableKey;
            // 
            // FieldName
            // 
            this.FieldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASECodeEditor.Properties.Settings.Default, "LastTableField", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FieldName.Location = new System.Drawing.Point(84, 72);
            this.FieldName.Name = "FieldName";
            this.FieldName.Size = new System.Drawing.Size(130, 20);
            this.FieldName.TabIndex = 2;
            this.FieldName.Text = global::ASECodeEditor.Properties.Settings.Default.LastTableField;
            // 
            // SaveRecord
            // 
            this.SaveRecord.Location = new System.Drawing.Point(71, 228);
            this.SaveRecord.Name = "SaveRecord";
            this.SaveRecord.Size = new System.Drawing.Size(88, 22);
            this.SaveRecord.TabIndex = 17;
            this.SaveRecord.Text = "Save Code";
            this.SaveRecord.UseVisualStyleBackColor = true;
            this.SaveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.Location = new System.Drawing.Point(71, 256);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(88, 22);
            this.NewRecord.TabIndex = 18;
            this.NewRecord.Text = "New Record";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // TableName
            // 
            this.TableName.FormattingEnabled = true;
            this.TableName.Location = new System.Drawing.Point(84, 17);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(130, 21);
            this.TableName.TabIndex = 19;
            // 
            // ASECodeEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 283);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.NewRecord);
            this.Controls.Add(this.SaveRecord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LangField);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.CurrRecord);
            this.Controls.Add(this.PrevRecord);
            this.Controls.Add(this.KeyValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FieldName);
            this.Controls.Add(this.label1);
            this.HideOnClose = true;
            this.Name = "ASECodeEditorWindow";
            this.Text = "ASECodeEditorWindow";
            this.Shown += new System.EventHandler(this.ASECodeEditorWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FieldName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TableKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KeyValue;
        private System.Windows.Forms.Button PrevRecord;
        private System.Windows.Forms.Button CurrRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Language;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LangField;
        private System.Windows.Forms.Button SaveRecord;
        private System.Windows.Forms.Button NewRecord;
        private System.Windows.Forms.ComboBox TableName;
    }
}