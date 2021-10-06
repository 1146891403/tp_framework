using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Menus;
using TP.Infrastructure.Common.Dependency;
using TP.Infrastructure.Common.Extensions;
using TP.Infrastructure.Common.Helper;
using TP.Infrastructure.Common.Model;

namespace TP.Client.WinForm.Common.Controls
{
    public partial class ControlBase : XtraUserControl
    {
        private readonly object syncObject = new object();
        private EditModelBase currentGridEditModel;

        public ControlBase()
        {
            InitializeComponent();
        }
        
        protected int TotalRecords { get; set; }

        protected bool IsNew { get; set; } = false;

        private bool _isRefreshGrid = false;
        protected bool IsRefreshGrid
        {
            get { return _isRefreshGrid; }
            set
            {
                _isRefreshGrid = value;

                if (value)
                    RefreshDataOfWait(async () => { await RefreshGridDataAsync(); });
            }
        }

        protected virtual GridControl Grid { get { return null; } }

        protected virtual GridView MainView { get { return null; } }

        protected virtual ColumnView CurrentView { get { return MainView; } }

        protected DialogResult ReturnResult { get; set; } = DialogResult.Cancel;

        private IEnumerable<ListModelBase> _bindingGridModels;
        protected virtual IEnumerable<ListModelBase> BindingGridModels
        {
            get { return _bindingGridModels; }
            set
            {
                if(_bindingGridModels != value)
                {
                    _bindingGridModels = value;

                    Grid.DataSource = value;
                }
            }
        }

        protected virtual EditModelBase CurrentGridEditModel
        {
            get
            {
                if (CurrentGridListModel == null || IsNew) return new EditModelBase();

                return currentGridEditModel;
            }
        }

        protected virtual object CurrentGridListModel
        {
            get
            {
                if (CurrentView == null || CurrentView.FocusedRowHandle < 0) return null;

                return CurrentView.GetRow(CurrentView.FocusedRowHandle);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeControl();

            RefreshDataOfWait(async () => { await InitializeDataAsync(); });
        }

        protected virtual void InitializeControl()
        {
            InitializeSearchData();
            InitializeGridControl();
        }

        protected virtual async Task InitializeDataAsync()
        {
            await InitializeEditorsAsync();
            await RefreshGridDataAsync();
        }
        
        protected virtual void InitializeSearchData() { }

        protected virtual async Task InitializeEditorsAsync() { await Task.FromResult(0); }

        protected virtual void InitializeGridControl()
        {
            if (MainView != null)
            {
                MainView.OptionsBehavior.Editable = false;
                MainView.GridControl.MouseDoubleClick += new MouseEventHandler(GridControl_MouseDoubleClick);
                MainView.DataSourceChanged += new EventHandler(MainView_DataSourceChanged);
                MainView.PopupMenuShowing += new PopupMenuShowingEventHandler(MainView_PopupMenuShowing);
            }
        }
        
        protected virtual async Task RefreshGridDataAsync() { await Task.FromResult(0); }
        
        protected void BtnSearch_Click(object sender, EventArgs e) => IsRefreshGrid = true;

        protected void BtnNew_Click(object sender, EventArgs e) => Add();

        private void GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridView gv = ((GridControl)sender).MainView as GridView;
            if (gv != null)
            {
                GridHitInfo info = gv.CalcHitInfo(new Point(e.X, e.Y));
                if (!info.InRow) return;

                DoEdit();
            }
            else
            {
                ColumnView cv = ((GridControl)sender).MainView as ColumnView;
                if (cv != null)
                {
                    DoEdit();
                }
            }
        }

        protected virtual void MainView_DataSourceChanged(object sender, EventArgs e) { }

        private void MainView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if(e.Menu != null && e.MenuType == GridMenuType.Row)
            {
                var menu = new GridViewPopupMenu(e.Menu.View)
                {
                    CanEdit = true,
                    CanDelete = true,
                    CanApprove = true,
                };

                menu.ItemNew_Click += new EventHandler(GridViewMenu_ItemNew_Click);
                menu.ItemEdit_Click += new EventHandler(GridViewMenu_ItemEdit_Click);
                menu.ItemRefresh_Click += new EventHandler(GridViewMenu_ItemRefresh_Click);

                menu.Initialize();

                e.Menu = menu;
            }
        }

        private void GridViewMenu_ItemNew_Click(object sender, EventArgs e) => Add();

        private void GridViewMenu_ItemEdit_Click(object sender, EventArgs e) => DoEdit();

        private void GridViewMenu_ItemRefresh_Click(object sender, EventArgs e) => IsRefreshGrid = true;

        protected virtual void Pagination_PageChanged(object sender, EventArgs e) { }

        protected virtual void ShowFormDialog(FrmEditBase form)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (form)
            {
                ReturnResult = form.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
            AddDataToGrid();
        }

        private void DoEdit()
        {
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
        }

        protected virtual void AddDataToGrid()
        {
            if (ReturnResult == DialogResult.OK)
            {
                MainView.BeginDataUpdate();
                try
                {
                    AddModelToList();
                }
                finally
                {
                    MainView.EndDataUpdate();
                }
            }
        }

        protected virtual void Add() { IsNew = true; }

        protected virtual void AddModelToList() { }

        protected virtual void Edit() { IsNew = false; }

        protected virtual async Task SetBindingGridModelsAsync<TListModel>(string controller) where TListModel : ListModelBase
        {
            BindingGridModels = await GetDeserializeObjectAsync<TListModel>(controller);
        }

        protected virtual async Task SetBindingGridModelsAsync<TListModel>(string controller, string action) where TListModel : ListModelBase
        {
            BindingGridModels = await GetDeserializeObjectAsync<TListModel>(controller, action);
        }

        protected virtual async Task SetBindingGridModelsAsync<TListModel>(string controller, string action, string parameters) where TListModel : ListModelBase
        {
            BindingGridModels = await GetDeserializeObjectAsync<TListModel>(controller, action, parameters);
        }

        /// <summary>
        /// set grid control current edit model;
        /// orgin from model
        /// </summary>
        /// <typeparam name="TEditModel"></typeparam>
        /// <param name="model"></param>
        protected virtual void SetCurrentGridEditModel<TEditModel>(TEditModel model) where TEditModel : EditModelBase
        {
            currentGridEditModel = model;
        }

        /// <summary>
        /// set grid control current edit model;
        /// orgin from query database
        /// </summary>
        /// <typeparam name="TEditModel"></typeparam>
        /// <param name="controller">controller name</param>
        /// <param name="action">action name</param>
        /// <param name="parameters">query parameters</param>
        /// <returns></returns>
        protected virtual async Task SetCurrentGridEditModel<TEditModel>(string controller, string action, string parameters) where TEditModel : EditModelBase, new()
        {
            currentGridEditModel = (await GetDeserializeObjectAsync<TEditModel>(controller, action, parameters)).FirstOrDefault();
        }

        /// <summary>
        /// get grid control current edit model
        /// </summary>
        /// <typeparam name="TEditModel"></typeparam>
        /// <returns></returns>
        protected virtual TEditModel GetCurrentGridEditModel<TEditModel>() where TEditModel : EditModelBase, new()
        {
            if (CurrentGridListModel == null || IsNew) return new TEditModel();

            return currentGridEditModel.As<TEditModel>();
        }

        /// <summary>
        /// get all data, 
        /// action default name: get_all
        /// </summary>
        /// <typeparam name="TModel">model</typeparam>
        /// <param name="controller">controller name</param>
        /// <returns>return IEnumerable<T> </returns>
        protected virtual async Task<IEnumerable<TModel>> GetDeserializeObjectAsync<TModel>(string controller) where TModel : class
        {
            return await ServiceLocator.Resolve<IDataService>().GetListAsync<TModel>(controller);
        }

        protected virtual async Task<IEnumerable<TModel>> GetDeserializeObjectAsync<TModel>(string controller, string action) where TModel : class
        {
            return await ServiceLocator.Resolve<IDataService>().GetListAsync<TModel>(controller, action);
        }

        protected virtual async Task<IEnumerable<TModel>> GetDeserializeObjectAsync<TModel>(string controller, string action, string parameters) where TModel : class
        {
            return await ServiceLocator.Resolve<IDataService>().GetListAsync<TModel>(controller, action, parameters);
        }

        protected virtual string GetSerializeObject(object value)
        {
            return JsonHelper.SerializeObject(value);
        }
        
        private void ShowWaitForm()
        {
            if (SplashScreenManager.Default == null)
                SplashScreenManager.ShowForm(this.FindForm(), typeof(wfMain), false, true, false);
        }

        private void CloseWaitForm()
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        protected virtual void RefreshDataOfWait(Action action)
        {
            RefreshData(() =>
            {
                this.ShowWaitForm();
                action.Invoke();
                this.CloseWaitForm();
            });
        }

        private void RefreshData(Action action)
        {
            RunProcess(
                () =>
                {
                    if (this.InvokeRequired)
                    {
                        //this.BeginInvoke(new ThreadStart(action));
                        this.BeginInvoke(action);
                    }
                    else
                    {
                        action.Invoke();
                    }
                },
                task =>
                {
                    if (task.IsFaulted)
                    {
                        XtraMessageBox.Show(string.Join("\n", task.Exception.Message), "錯誤信息");
                    }
                });
        }

        protected void RunProcess(Action action, Action<Task> continuationFunction)
        {
            RunProcess(action, continuationFunction, false);
        }

        protected void RunProcess(Action action, Action<Task> continuationFunction, bool runCallbackInUIThread)
        {
            lock (syncObject)
            {
                Process.RunAsync(() => action.Invoke(),
                    task =>
                    {
                        if (runCallbackInUIThread)
                        {
                            this.BeginInvoke(new Action<Task>(
                                t =>
                                {
                                    continuationFunction.Invoke(t);

                                    t.Dispose();
                                }), DispatcherPriority.Normal, task);
                        }
                        else
                        {
                            continuationFunction.Invoke(task);

                            task.Dispose();
                        }
                    });
            }
        }
    }
}
