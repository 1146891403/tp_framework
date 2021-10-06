using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Infrastructure.Common.Model;

namespace TP.Client.WinForm.Common.Controls
{
    public partial class GridTreeListViewBase : ControlBase
    {
        public GridTreeListViewBase()
        {
            InitializeComponent();

            InitTreeListComponet();

            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnNew.Click += new EventHandler(BtnNew_Click);
            pagination.PageChanged += new PageChangedEventHandler(Pagination_PageChanged);
        }
        
        protected virtual TreeList Tree => treeList;

        protected virtual string TreeCaption => string.Empty;

        protected virtual ImageCollection TreeSelectImages => null;

        protected virtual IEnumerable<TreeListModelBase> BindingTreeModels { get; set; }

        protected virtual object CurrentTreeModel
        {
            get
            {
                if (Tree == null || Tree.FocusedNode == null) return null;

                return Tree.GetDataRecordByNode(Tree.FocusedNode);
            }
        }

        protected override async Task InitializeDataAsync()
        {
            await RefreshTreeBindingSourceAsync();

            await base.InitializeDataAsync();
        }

        protected virtual void InitTreeListComponet()
        {
            lcgTreeList.Text = TreeCaption;

            Tree.KeyFieldName = "Id";
            Tree.ParentFieldName = "ParentId";
            Tree.RowHeight = 22;

            if (TreeSelectImages != null)
                Tree.SelectImageList = TreeSelectImages;

            Tree.OptionsBehavior.Editable = false;

            Tree.OptionsView.ShowColumns = false;
            Tree.OptionsView.ShowIndicator = false;
            Tree.OptionsView.ShowHorzLines = false;
            Tree.OptionsView.ShowVertLines = false;

            Tree.Columns.Clear();
            TreeListColumn column = Tree.Columns.AddVisible("DisplayName");
            column.OptionsColumn.AllowSort = false;

            Tree.MouseDoubleClick += new MouseEventHandler(TreeList_MouseDoubleClick);
            Tree.FocusedNodeChanged += new FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            Tree.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TreeList_CustomDrawNodeImages);
        }

        protected virtual void TreeList_MouseDoubleClick(object sender, MouseEventArgs e) { }

        protected virtual void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) => IsRefreshGrid = true;

        protected virtual void TreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
        
        protected virtual async Task RefreshTreeBindingSourceAsync()
        {
            await RefreshTreeDataAsync();

            if (BindingTreeModels != null)
            {
                Tree.Nodes.Clear();
                Tree.BeginUpdate();

                Tree.DataSource = BindingTreeModels;

                Tree.ExpandAll();
                Tree.EndUpdate();
            }
        }

        protected virtual async Task RefreshTreeDataAsync() { await Task.FromResult(0); }

        protected override void MainView_DataSourceChanged(object sender, EventArgs e)
        {
            base.MainView_DataSourceChanged(sender, e);

            pagination.InitPageInfo(TotalRecords);
        }
    }
}
