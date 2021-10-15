using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Collections;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraEditors;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Controls
{
    public partial class TreeListDemo : GridViewBase
    {
        public TreeListDemo()
        {
            InitializeComponent();
            

            treeList1.DragDrop += new DragEventHandler(TreeList1_DragDrop);
            treeList1.DragEnter += new DragEventHandler(TreeList1_DragEnter);
            Load += new EventHandler(TreeListDemo_LoadAsync);
        }

        private async void TreeListDemo_LoadAsync(object sender, EventArgs e)
        {
            //var list = new List<UserList>() {
            //     new UserList("0","-1","第1层","主项",45),
            //     new UserList("1","0","第2层","在主项下面1",65),
            //     new UserList("2","0","第2层","在主项下面2",22),

            //     new UserList("3","2","第3层","第二层下面1",55),
            //     new UserList("4","2","第3层","第二层下面2",44),
            //     new UserList("5","2","第3层","第二层下面3",88),

            //     new UserList("6","-1","第1层","主项",33),
            //     new UserList("7","-1","第1层","主项",44),
            //};

            treeList1.KeyFieldName = "Id";
            treeList1.ParentFieldName = "ParentId";

            treeList1.DataSource = await GetDeserializeObjectAsync<ViewLinkListModel>("navs");

            //是否可以拖动  单个  和  多个  节点  或者 禁用
            treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Multiple;
            treeList1.ExpandAll();
        }

        private TreeListNode GetDragNode(IDataObject data)
        {
            System.Diagnostics.Debug.WriteLine("GetDragNode");
            return (TreeListNode)data.GetData(typeof(TreeListNode));

        }

        private void TreeList1_DragDrop(object sender, DragEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("开始拖动");
            TreeListNode node = GetDragNode(e.Data);

            if (node == null) return;

            TreeList list = (TreeList)sender;

            if (list == node.TreeList) return;

            TreeListHitInfo info = list.CalcHitInfo(list.PointToClient(new Point(e.X, e.Y)));

            InsertBrush(list, node, info.Node == null ? -1 : info.Node.Id);

        }

        private void TreeList1_DragEnter(object sender, DragEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("结束拖动");
            TreeList list = (TreeList)sender;

            TreeListNode node = GetDragNode(e.Data);

            if (node != null && node.TreeList != list)

                e.Effect = DragDropEffects.Copy;

        }

        private void InsertBrush(TreeList list, TreeListNode node, int parent)
        {
            System.Diagnostics.Debug.WriteLine("InsertBrush");
            ArrayList data = new ArrayList();

            foreach (TreeListColumn column in node.TreeList.Columns)
            {
                data.Add(node[column]);

            }

            parent = list.AppendNode(data.ToArray(), parent).Id;

            if (node.HasChildren)

                foreach (TreeListNode n in node.Nodes)

                    InsertBrush(list, n, parent);

        }
    }
}
