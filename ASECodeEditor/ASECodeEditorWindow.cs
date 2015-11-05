using MsaSQLEditor.DockWindows;
using MsaSQLEditor.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using dao = NetOffice.DAOApi;

namespace ASECodeEditor
{
    public partial class ASECodeEditorWindow : ToolWindow
    {
        public IPluginContext2 PluginContext { get; set; }
        private Editor _EditorWindow;

        dao.Recordset Recordset;
        dao.Database db;

        private IStatusView _StatusView;

        public ASECodeEditorWindow()
        {
            InitializeComponent();
            this._EditorWindow = new Editor();
            this._EditorWindow.HideOnClose = true;
        }

        private IStatusView StatusView
        {
            get
            {
                if (this._StatusView == null)
                {
                    this._StatusView = 
                        this.PluginContext
                            .SystemWindows
                            .Where<ISystemWindow>(i => i.Text == "Status")
                            .Select<ISystemWindow,IStatusView>(i => (IStatusView)i)
                            .First<IStatusView>();

                }
                return this._StatusView;
            }
        }


        private void ASECodeEditorWindow_Shown(object sender, EventArgs e)
        {


        }

        private void Connect_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            db = (dao.Database)
                    NetOffice.Factory.CreateKnownObjectFromComProxy(
                        null,
                        this.PluginContext.Database.CurrentDb(),
                        typeof(dao.Database));

            try
            { 
                this.Recordset = db.OpenRecordset("SELECT * FROM [" + this.TableName.Text + "];", 
                    dao.Enums.RecordsetTypeEnum.dbOpenDynaset);

                this.DisplayCurrentRecord();
            }
            catch(COMException ex)
            {
                this.StatusView.ShowStatusMessage
                    (StatusMessageType.Error, "Error: {0}", ex.GetBaseException().Message);
            }
        }

        private void DisplayCurrentRecord()
        {
            try
            { 
                if (!this.Recordset.EOF)
                {
                    this.Language.Text = this.Recordset.Fields[this.LangField.Text].Value.ToString();
                    this.KeyValue.Text = this.Recordset.Fields[this.TableKey.Text].Value.ToString();
                
                    if (!this._EditorWindow.Visible)
                    {
                        this._EditorWindow.Show(this.PluginContext.DockPanel,
                            WeifenLuo.WinFormsUI.Docking.DockState.Document);
                    }

                    this._EditorWindow.Text = "ASE Code Editor";

                    this._EditorWindow.TextEditor.Text =
                        this.Recordset.Fields[this.FieldName.Text].Value.ToString();

                    this._EditorWindow.TextEditor.NativeInterface.SetSavePoint();

                    this._EditorWindow.TextEditor
                        .ConfigurationManager.Language = this.Language.Text;
                }
            }
            catch(Exception ex)
            {
                this.StatusView.ShowStatusMessage
                    (StatusMessageType.Error, "Error: {0}", ex.GetBaseException().Message);
            }
        }

        private void CurrRecord_Click(object sender, EventArgs e)
        {
            if (!this.Recordset.EOF)
            {
                this.Recordset.MoveNext();
                this.DisplayCurrentRecord();
            }
            else
                this.Recordset.MovePrevious();
        }

        private void PrevRecord_Click(object sender, EventArgs e)
        {
            if (!this.Recordset.BOF)
            {
                this.Recordset.MovePrevious();
                this.DisplayCurrentRecord();
            }
            else
                this.Recordset.MovePrevious();
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.KeyValue.Text == "*")
                    this.Recordset.AddNew();
                else
                    this.Recordset.Edit();
                
                this.Recordset.Fields[this.FieldName.Text].Value =
                    this._EditorWindow.TextEditor.Text;

                this.Recordset.Fields[this.LangField.Text].Value =
                    this.Language.Text;

                this.Recordset.Update();

                this.Recordset.Requery();
                this.DisplayCurrentRecord();
            }
            catch (Exception ex)
            {
                this.StatusView.ShowStatusMessage
                    (StatusMessageType.Error, "Error: {0}", ex.GetBaseException().Message);
            }
        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                this.Language.Text = String.Empty;
                this.KeyValue.Text = "*";
                this._EditorWindow.TextEditor.Text = String.Empty;
            }
            catch (Exception ex)
            {
                this.StatusView.ShowStatusMessage
                    (StatusMessageType.Error, "Error: {0}", ex.GetBaseException().Message);
            }
        }
    }
}
