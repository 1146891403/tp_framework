using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using TP.Client.WinForm.Common.Properties;

namespace TP.Client.WinForm.Common.Menus
{
    public class GridViewPopupMenu : GridViewMenu
    {
        public GridViewPopupMenu(GridView view) : base(view) { }

        private bool _canEdit = false;
        public bool CanEdit
        {
            get { return _canEdit; }
            set
            {
                if(_canEdit != value && value)
                {
                    AddMenuNew();
                    AddMenuEdit();
                }
            }
        }

        private bool _canApporve = false;
        public bool CanApprove
        {
            get { return _canApporve; }
            set
            {
                if(_canApporve != value && value)
                {
                    AddMenuApprove();
                    AddMenuReject();
                }
            }
        }

        private bool _canDelete = false;
        public bool CanDelete
        {
            get { return _canDelete; }
            set
            {
                if(_canDelete != value && value)
                {
                    AddMenuDelete();
                }
            }
        }

        public virtual void Initialize()
        {
            AddMenuRefresh();

            if (CanEdit)
            {
                AddMenuCopy();
            }

            AddMenuPrint();
            AddmenuExportToPdf();
        }
        
        private void AddMenuNew()
        {
            Items.Add(new DXMenuItem("新建", new EventHandler(MenuNew_ItemClick), Resources.add_16x16));
        }

        private void AddMenuEdit()
        {
            Items.Add(new DXMenuItem("編輯", new EventHandler(MenuEdit_ItemClick), Resources.edit_16x16));
        }

        private void AddMenuDelete()
        {
            Items.Add(new DXMenuItem("刪除", new EventHandler(MenuDelete_ItemClick), Resources.delete_16x16));
        }

        private void AddMenuRefresh()
        {
            Items.Add(new DXMenuItem("刷新", new EventHandler(MenuRefresh_ItemClick), Resources.refresh_16x16) { BeginGroup = true });
        }

        private void AddMenuApprove()
        {
            Items.Add(new DXMenuItem("批准", new EventHandler(MenuApprove_ItemClick), Resources.apply_16x16) { BeginGroup = true });
        }

        private void AddMenuReject()
        {
            Items.Add(new DXMenuItem("拒絕", new EventHandler(MenuReject_ItemClick), Resources.cancel_16x16));
        }

        private void AddMenuCopy()
        {
            Items.Add(new DXMenuItem("複製並新建", new EventHandler(MenuCopy_ItemClick), Resources.copy_16x16) { BeginGroup = true });
        }

        private void AddMenuPrint()
        {
            Items.Add(new DXMenuItem("打印", new EventHandler(MenuPrint_ItemClick), Resources.print_16x16) { BeginGroup = true });
        }

        private void AddmenuExportToPdf()
        {
            Items.Add(new DXMenuItem("導出PDF", new EventHandler(MenuExportToPdf_ItemClick), Resources.exporttopdf_16x16));
        }

        public event EventHandler ItemNew_Click;
        private void MenuNew_ItemClick(object sender, EventArgs e) => ItemNew_Click?.Invoke(sender, e);

        public event EventHandler ItemEdit_Click;
        private void MenuEdit_ItemClick(object sender, EventArgs e) => ItemEdit_Click?.Invoke(sender, e);

        public event EventHandler ItemDelete_Click;
        private void MenuDelete_ItemClick(object sender, EventArgs e) => ItemDelete_Click?.Invoke(sender, e);

        public event EventHandler ItemRefresh_Click;
        private void MenuRefresh_ItemClick(object sender, EventArgs e) => ItemRefresh_Click?.Invoke(sender, e);

        public event EventHandler ItemApprove_Click;
        private void MenuApprove_ItemClick(object sender, EventArgs e) => ItemApprove_Click?.Invoke(sender, e);

        public event EventHandler ItemReject_Click;
        private void MenuReject_ItemClick(object sender, EventArgs e) => ItemReject_Click?.Invoke(sender, e);

        public event EventHandler ItemCopy_Click;
        private void MenuCopy_ItemClick(object sender, EventArgs e) => ItemCopy_Click?.Invoke(sender, e);

        public event EventHandler ItemPrint_Click;
        private void MenuPrint_ItemClick(object sender, EventArgs e) => ItemPrint_Click?.Invoke(sender, e);

        public event EventHandler ItemExportToPdf_Click;
        private void MenuExportToPdf_ItemClick(object sender, EventArgs e) => ItemExportToPdf_Click?.Invoke(sender, e);

    }
}
