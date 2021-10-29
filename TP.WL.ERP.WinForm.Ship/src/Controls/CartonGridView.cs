using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Controls;
using TP.WL.ERP.Model.Ship;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using TP.Infrastructure.Common.Helper;
using TP.Infrastructure.Common.Dependency;
using TP.Client.WinForm.Common;

namespace TP.WL.ERP.WinForm.Ship.Controls
{
    public partial class CartonGridView : ControlBase
    {
        private GridControl GridControl;
        private GridView GridView;
        private BindingList<ShipCartonEditModel> BDList;

        private List<long> ModifiyListId = new List<long> { };

        public CartonGridView()
        {
            InitializeComponent();

            GridControl = gridControl;
            GridView = gridView;

            //初始化GridControl
            InitializeAsync();

            InitializeButton();

        }

        #region 初始化
        private void InitializeButton()
        {
            btnNew.Click += new EventHandler(BtnNew_Click);
            btnSave.Click += new EventHandler(BtnSave_Click);
            btnDelete.Click += new EventHandler(BtnDelete_Click);
            btnSearch.Click += new EventHandler(BtnSearch_ClickAsync);
            btnTest.Click += new EventHandler(BtnTest_Click);
        }

        private async void InitializeAsync()
        {
            await ResetDataSource();

            GridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            GridView.RowDeleted += new RowDeletedEventHandler(GridView_RowDeleted);
            GridView.RowUpdated += new RowObjectEventHandler(GridView_RowUpdate);
        }

        private async Task ResetDataSource()
        {
            var list = await GetDeserializeObjectAsync<ShipCartonEditModel>("carton");

            BDList = new BindingList<ShipCartonEditModel>(list.ToList());

            GridControl.DataSource = BDList;

        }
        #endregion

        #region 所有的按钮单击事件
        private async void BtnSearch_ClickAsync(object sender, EventArgs e)
        {
            await ResetDataSource();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBoxService.Questioned("确定要删除吗?");

            if (dialogResult == DialogResult.Yes)
            {
                GridView.DeleteRow(GridView.FocusedRowHandle);
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //根据id找到 修改或新增的数据
            IEnumerable<ShipCartonEditModel> shipCartonList = BDList.Where(x => ModifiyListId.Contains(x.Id));

            foreach (var item in shipCartonList)
            {
                System.Diagnostics.Debug.WriteLine($"修改或新增的数据,id={item.Id},JobNumber={item.JobNumber}");
            }
            var parameters = JsonHelper.SerializeObject(shipCartonList);

            var result = await ServiceLocator.Resolve<IDataService>().RPutAsync("carton", "update_list", parameters);

            if(result)
                ModifiyListId.Clear();
        }

        private new void BtnNew_Click(object sender, EventArgs e)
        {
            GridView.AddNewRow();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var row = GridView.GetSelectedRows();
            
            System.Diagnostics.Debug.WriteLine($"row={JsonHelper.SerializeObject(row)}");
            for (int i = 0; i < row.Length; i++)
            {
                var cells = GridView.GetSelectedCells(row[i]);
                //var cells = GridView.GetSelectedCells();
                System.Diagnostics.Debug.WriteLine($"cells={JsonHelper.SerializeObject(cells)}");
            }

        }
        #endregion

        #region Grid 新增 修改 删除 事件
        private void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "DeliveryDate", DateTime.Now);

            System.Diagnostics.Debug.WriteLine($"新增 RowHandle={e.RowHandle}");
        }

        private void GridView_RowUpdate(object sender, RowObjectEventArgs e)
        {
            //记录修改的行
            ShipCartonEditModel editModel = (ShipCartonEditModel)e.Row;
            ModifiyListId.Add(editModel.Id);
            System.Diagnostics.Debug.WriteLine($"修改 Row={e.Row},RowHandle={e.RowHandle},id={editModel.Id}");
        }

        private void GridView_RowDeleted(object sender, RowDeletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"删除 Row={e.Row},RowHandle={e.RowHandle},ListSourceIndex={e.ListSourceIndex}");
        }
        #endregion


    }
}
