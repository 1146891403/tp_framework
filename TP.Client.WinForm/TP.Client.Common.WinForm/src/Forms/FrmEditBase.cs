using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout.Utils;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Infrastructure.Common.Dependency;
using TP.Infrastructure.Common.Extensions;
using TP.Infrastructure.Common.Helper;
using TP.Infrastructure.Common.Model;

namespace TP.Client.WinForm.Common.Forms
{
    public partial class FrmEditBase : XtraForm
    {
        private readonly EditModelBase bindingModel;

        private bool dirty = false;
        private bool canDelete = false;
        private bool canPrint = false;

        private string defaultFormText = string.Empty;

        public FrmEditBase()
        {
            InitializeComponent();
        }

        public FrmEditBase(EditModelBase model) : this()
        {
            btnSave.Click += new EventHandler(BtnSave_Click);
            btnSaveAndNew.Click += new EventHandler(BtnSaveAndNew_Click);
            btnDelete.Click += new EventHandler(BtnDelete_Click);
            btnPrint.Click += new EventHandler(BtnPrint_Click);

            this.bindingModel = model;

            InitializeButton();
        }
        
        public virtual string FormText => $"{(bindingModel == null || bindingModel.Id <= 0 ? "新建" : "編輯")} {defaultFormText}";

        public DXValidationProvider ValidationProvider { get { return dxValidationProvider; } }

        public virtual bool Dirty
        {
            get { return dirty; }
            set
            {
                if (dirty != value)
                {
                    dirty = value;
                    UpdateFormText();
                }
            }
        }

        public virtual bool CanDelete
        {
            get { return canDelete; }
            set
            {
                if(canDelete != value)
                    canDelete = value;

                lciBtnDelete.Visibility = value ? LayoutVisibility.Always : LayoutVisibility.Never;
            }
        }

        public virtual bool CanPrint
        {
            get { return canPrint; }
            set
            {
                if(canPrint != value)
                    canPrint = value;

                lciBtnPrint.Visibility = value ? LayoutVisibility.Always : LayoutVisibility.Never;
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.defaultFormText = this.Text;
            this.Text = this.FormText;
            
            InitializeValidation();
            await InitializeEditorsAsync();
            InitializeData();
            InitializeControlEvent();
        }

        protected virtual void InitializeButton()
        {
            this.CanDelete = false;
            this.CanPrint = false;
        }

        private void AddControlEvent(Control control)
        {
            if (control is BaseEdit edit)
            {
                edit.EditValueChanged += new EventHandler(Edit_EditValueChanged);
            }

            if (control is GridControl grid)
            {
            }
        }

        protected override async void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (Dirty)
            {
                DialogResult result = XtraMessageBox.Show(this, "是否保存本次修改？", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (result == DialogResult.Yes)
                    await SaveAsync();
            }
            Cursor.Current = Cursors.Default;
        }

        protected virtual void InitializeControlEvent()
        {
            foreach (Control control in lcMain.Controls)
            {
                AddControlEvent(control);
            }
        }

        private void Edit_EditValueChanged(object sender, EventArgs e) { Dirty = true; }

        private async void BtnSave_Click(object sender, EventArgs e) { await SaveAsync(); }

        private void BtnSaveAndNew_Click(object sender, EventArgs e) { }

        private void BtnDelete_Click(object sender, EventArgs e) { }

        private void BtnPrint_Click(object sender, EventArgs e) { }

        protected virtual void UpdateFormText()
        {
            this.Text = $"{FormText}{(Dirty ? "*" : string.Empty)}";
        }

        public async Task<bool> SaveAsync()
        {
            BeforeFormClose();
            if (ValidateData())
            {
                await SaveDataAsync();

                Dirty = false;
                this.DialogResult = DialogResult.OK;
                return true;
            }
            return false;
        }

        protected virtual void InitializeValidation() { }

        protected virtual void InitializeData() { }

        protected virtual async Task InitializeEditorsAsync() { await Task.FromResult(0); }

        protected virtual async Task SaveDataAsync() { await Task.FromResult(0); }

        protected virtual async Task DeleteDataAsync() { await Task.FromResult(0); }

        protected virtual void BeforeFormClose() { }

        protected virtual bool ValidateData() { return ValidationProvider.Validate(); }

        protected virtual TModel GetEditModel<TModel>() where TModel : EditModelBase, new()
        {
            return bindingModel.As<TModel>() ?? CreateNewModel<TModel>();
        }

        protected virtual TModel CreateNewModel<TModel>() where TModel : EditModelBase, new()
        {
            return new TModel();
        }
        
        protected virtual string GetSerializeObject(EditModelBase model)
        {
            return JsonHelper.SerializeObject(model);
        }
        
        /// <summary>
        /// default method, action = add
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        protected virtual async Task PostAsync(string controller, string content)
        {
            await ServiceLocator.Resolve<IDataService>().PostAsync(controller, content);
        }

        /// <summary>
        /// add data method
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        protected virtual async Task PostAsync(string controller, string action, string content)
        {
            await ServiceLocator.Resolve<IDataService>().PostAsync(controller, action, content);
        }

        /// <summary>
        /// default method, action = update
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        protected virtual async Task PutAsync(string controller, string content)
        {
            await ServiceLocator.Resolve<IDataService>().PutAsync(controller, content);
        }

        /// <summary>
        /// update data method
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        protected virtual async Task PutAsync(string controller, string action, string content)
        {
            await ServiceLocator.Resolve<IDataService>().PutAsync(controller, action, content);
        }
    }
}