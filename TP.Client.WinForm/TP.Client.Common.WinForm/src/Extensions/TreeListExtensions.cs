using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System.Collections.Generic;
using System.Windows.Forms;
using TP.Infrastructure.Common.Model;

namespace TP.Client.WinForm.Common.Extensions
{
    public static class TreeListExtensions
    {
        /// <summary>
        /// TreeList Column Name is "DisplayName"
        /// TreeList.OptionsView.ShowCheckBoxes = false
        /// </summary>
        /// <param name="treeList"></param>
        /// <param name="caption"></param>
        /// <param name="imageCollection"></param>
        public static void Initialize<TTreeListModel>(this TreeList treeList, string caption, ImageCollection imageCollection, IEnumerable<TTreeListModel> listModel, bool showCheckBoxes = false)
             where TTreeListModel : TreeListModelBase
        {
            Initialize(treeList, caption, "DisplayName", imageCollection, listModel, showCheckBoxes);
        }

        /// <summary>
        /// TreeList.OptionsView.ShowCheckBoxes = false
        /// </summary>
        /// <param name="treeList"></param>
        /// <param name="caption"></param>
        /// <param name="columnName"></param>
        /// <param name="imageCollection"></param>
        public static void Initialize<TTreeListModel>(this TreeList treeList, string caption, string columnName, ImageCollection imageCollection, IEnumerable<TTreeListModel> listModel)
             where TTreeListModel : TreeListModelBase
        {
            Initialize(treeList, caption, columnName, imageCollection, listModel, false);
        }

        public static void Initialize<TTreeListModel>(this TreeList treeList, string caption, string columnName, ImageCollection imageCollection, IEnumerable<TTreeListModel> listModel, bool showCheckBoxes)
             where TTreeListModel : TreeListModelBase
        {
            if (treeList != null)
            {
                treeList.Columns.Clear();

                treeList.KeyFieldName = "Id";
                treeList.ParentFieldName = "ParentId";
                treeList.SelectImageList = imageCollection;
                treeList.RowHeight = 22;

                TreeListColumn column = treeList.Columns.AddVisible(columnName);
                column.Caption = caption;
                column.OptionsColumn.AllowSort = false;

                treeList.OptionsBehavior.Editable = false;
                treeList.OptionsBehavior.AllowRecursiveNodeChecking = showCheckBoxes;

                treeList.OptionsView.ShowHorzLines = false;
                treeList.OptionsView.ShowIndicator = false;
                treeList.OptionsView.ShowVertLines = false;
                treeList.OptionsView.ShowCheckBoxes = showCheckBoxes;

                RefreshDataSource(treeList, listModel);
            }
        }

        public static void RefreshDataSource<TTreeListModel>(this TreeList treeList, IEnumerable<TTreeListModel> listModel)
            where TTreeListModel : TreeListModelBase
        {
            treeList.Nodes.Clear();
            treeList.BeginUpdate();
            treeList.DataSource = listModel;
            treeList.ExpandAll();
            treeList.EndUpdate();
        }

        public static void SetParentNodeCheckState(this TreeList treeList, TreeListNode node)
        {
            if (node != null)
            {
                var aaa = node.GetValue("DisplayName");

                if (IsCheckedAllChildNode(treeList, node))
                    node.CheckState = CheckState.Checked;
                else
                    node.CheckState = CheckState.Indeterminate;

                if (node.ParentNode != null)
                    SetParentNodeCheckState(treeList, node.ParentNode);
            }
        }

        public static bool IsCheckedAllChildNode(this TreeList treeList, TreeListNode node)
        {
            foreach (TreeListNode child in node.Nodes)
            {
                if (child.CheckState != CheckState.Checked)
                    return false;

                if (child.HasChildren)
                    IsCheckedAllChildNode(treeList, child);
            }

            return true;
        }
    }
}
