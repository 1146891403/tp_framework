using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Infrastructure.Common.Model;

namespace TP.Client.WinForm.Common.src.Controls
{
    public partial class MasterDetailBase : XtraUserControl
    {

        private EditModelBase MasterEditModel;

        private BindingList<EditModelBase> DetailBindingList;

        protected bool IsNew { get; set; } = false;

        protected bool IsModify { get; set; } = false;

        protected virtual GridControl GridControlMaster { get; set; }
        protected virtual GridView GridViewMaster { get; set; }
        protected virtual GridControl GridControlDetail { get; set; }
        protected virtual GridView GridViewDetail { get; set; }

        public MasterDetailBase()
        {
            InitializeComponent();

            btnNew.Click += new EventHandler(BtnNew_Click);
            btnSave.Click += new EventHandler(BtnSave_Click);
            btnDelete.Click += new EventHandler(BtnDelete_Click);
            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnNewDetail.Click += new EventHandler(BtnNewDetail_Click);
            btnDeleteDetail.Click += new EventHandler(BtnDeleteDetail_Click);

            tileViewMaster.InitNewRow += new InitNewRowEventHandler(TileViewMaster_InitNewRow);
            tileViewMaster.RowDeleted += new RowDeletedEventHandler(TileViewMaster_RowDeleted);
            tileViewMaster.RowUpdated += new RowObjectEventHandler(TileViewMaster_RowUpdated);

            GridViewDetail.InitNewRow += new InitNewRowEventHandler(GridViewDetail_InitNewRow);
            GridViewDetail.RowDeleted += new RowDeletedEventHandler(GridViewDetail_RowDeleted);
            GridViewDetail.RowUpdated += new RowObjectEventHandler(GridViewDetail_RowUpdated);

;
            //InitializeData();
        }

        public MasterDetailBase(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //private void InitializeData()
        //{
        //    GridControlMaster.DataSource = MasterEditModel;
        //    GridControlDetail.DataSource = DetailBindingList;
        //}

        /// <summary>
        /// 设置主项和细项数据
        /// </summary>
        /// <param name="masterModel">主项</param>
        /// <param name="detailModel">细项</param>
        public virtual void SetMasterDetailEditModel(EditModelBase masterModel, IEnumerable<EditModelBase> detailModel)
        {
            MasterEditModel = masterModel;
            DetailBindingList = new BindingList<EditModelBase>(detailModel.ToList());

            GridControlMaster.DataSource = MasterEditModel;
            GridControlDetail.DataSource = DetailBindingList;
        }

        protected void SetMdfState()
        {
            IsModify = true;
        }

        protected void SetUpdState()
        {
            IsNew = false;
            IsModify = false;
        }


        #region 按钮单击事件
        private void BtnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (MessageBoxService.Questioned("确定要删除吗??") == DialogResult.OK)
                GridViewDetail.DeleteRow(GridViewDetail.FocusedRowHandle);
        }

        private void BtnNewDetail_Click(object sender, EventArgs e)
        {
            GridViewDetail.AddNewRow();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e) => Delete();

        protected virtual void Delete()
        {
            if (MessageBoxService.Questioned("确定要删除吗??") == DialogResult.OK)
                tileViewMaster.DeleteRow(tileViewMaster.FocusedRowHandle);
        }

        private void BtnSave_Click(object sender, EventArgs e) => Save();

        protected virtual void Save()
        {
        }
        
        private void BtnNew_Click(object sender, EventArgs e) => Add(); 

        private void Add()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region TileViewMaster 新增 修改 删除事件
        protected virtual void TileViewMaster_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void TileViewMaster_RowUpdated(object sender, RowObjectEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void TileViewMaster_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GridViewDetail 新增 修改 删除事件
        protected virtual void GridViewDetail_RowUpdated(object sender, RowObjectEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void GridViewDetail_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void GridViewDetail_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
