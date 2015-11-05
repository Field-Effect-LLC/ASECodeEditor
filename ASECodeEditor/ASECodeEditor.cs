using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MsaSQLEditor;
using MsaSQLEditor.DerivedControls;
using MsaSQLEditor.Interfaces;
using System.Windows.Forms;

namespace ASECodeEditor
{
    public class ASECodeEditor : IPlugin2
    {
        private IPluginContext2 _Context;
        private ASECodeEditorWindow _CodeWindow;

        public ASECodeEditor()
        { }

        public void Initialize(IPluginContext2 context)
        {
            //Save the plugin context so we can access ASE objects later
            this._Context = context;

            ToolStripButton btn = new ToolStripButton("Open ASE Editor");
            this._Context.MainMenu.Items.Add(btn);
            btn.Click += btn_Click;

            this._CodeWindow = new ASECodeEditorWindow();

            this._CodeWindow.PluginContext = context;

            this._CodeWindow.Show(this._Context.DockPanel,
                WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (!this._CodeWindow.Visible)
            {
                this._CodeWindow.Show(this._Context.DockPanel,
                    WeifenLuo.WinFormsUI.Docking.DockState.DockRight);
            }
        }

        public void Unload()
        {
            this._CodeWindow.Close();
        }
    }
}
