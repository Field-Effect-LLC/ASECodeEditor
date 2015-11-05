using MsaSQLEditor.DerivedControls;
using MsaSQLEditor.DockWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASECodeEditor
{
    public partial class Editor : ToolWindow
    {
        public Editor()
        {
            InitializeComponent();
            this.editorControl1.ApplyDefaultStyle();
        }

        public EditorControl TextEditor
        {
            get
            {
                return this.editorControl1;
            }
        }
    }
}
