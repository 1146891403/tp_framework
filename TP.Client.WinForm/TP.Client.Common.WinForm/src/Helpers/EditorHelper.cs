using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Columns;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Properties;
using TP.Infrastructure.Common.Dependency;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Model;
using TP.WL.ERP.Model.Administration;
using TP.WL.ERP.Model.Utilities;

namespace TP.Client.WinForm.Common.Helpers
{
    public class EditorHelper
    {
        private static int GetGenderImages(Gender gender)
        {
            if (gender == Gender.Female)
                return 1;

            return 0;
        }

        public static RepositoryItemImageComboBox CreateGenderImageComboBox(RepositoryItemImageComboBox edit)
        {
            RepositoryItemImageComboBox icb = edit ?? new RepositoryItemImageComboBox();
            
            icb.Items.Add(new ImageComboBoxItem(Resources.Gender_Male, Gender.Male.ToString(), 0));
            icb.Items.Add(new ImageComboBoxItem(Resources.Gender_Female, Gender.Female.ToString(), 1));
            icb.SmallImages = ImagesHelper.Current.GenderImages;

            return icb;
        }

        public static RepositoryItemImageComboBox CreateCurrencyImageComboBox(RepositoryItemImageComboBox edit)
        {
            RepositoryItemImageComboBox icb = edit ?? new RepositoryItemImageComboBox();
            
            icb.Items.Add(new ImageComboBoxItem(Resources.Currency_RMB, Currency.RMB.ToString(), 0));
            icb.Items.Add(new ImageComboBoxItem(Resources.Currency_HKD, Currency.HKD.ToString(), 1));
            icb.Items.Add(new ImageComboBoxItem(Resources.Currency_USD, Currency.USD.ToString(), 2));
            icb.Items.Add(new ImageComboBoxItem(Resources.Currency_JPY, Currency.JPY.ToString(), 3));
            icb.SmallImages = ImagesHelper.Current.CurrencyImages;

            return icb;
        }
        
        public static async Task<RepositoryItemLookUpEdit> CreateSubsidiaryLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            return await CreateSubsidiaryLookUpEdit(edit, collection, false);
        }

        public static async Task<RepositoryItemLookUpEdit> CreateSubsidiaryLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, bool key)
        {
            RepositoryItemLookUpEdit lue = edit ?? new RepositoryItemLookUpEdit();
            if (collection != null)
                collection.Add(lue);
            
            lue.ValueMember = "Id";
            lue.DisplayMember = "LegalName";
            lue.DataSource = await ServiceLocator.Resolve<IDataService>().GetListAsync<SubsidiaryListModel>("subsidiaries");
            lue.NullText = string.Empty;
            lue.Columns.Clear();
            lue.Columns.Add(new LookUpColumnInfo("LegalName"));
            lue.ShowHeader = false;
            lue.DropDownRows = 5;

            return lue;
        }

        public static async Task<RepositoryItemLookUpEdit> CreateDepartmentLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            return await CreateDepartmentLookUpEdit(edit, collection, false);
        }

        public static async Task<RepositoryItemLookUpEdit> CreateDepartmentLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, bool key)
        {
            RepositoryItemLookUpEdit lue = edit ?? new RepositoryItemLookUpEdit();
            if (collection != null)
                collection.Add(lue);
            
            lue.ValueMember = "Id";
            lue.DisplayMember = "DisplayName";
            lue.DataSource = await ServiceLocator.Resolve<IDataService>().GetListAsync<DepartmentListModel>("departments");
            lue.NullText = string.Empty;
            lue.Columns.Clear();
            lue.Columns.Add(new LookUpColumnInfo("DisplayName"));
            lue.ShowHeader = false;
            lue.DropDownRows = 10;

            return lue;
        }
        
        public static RepositoryItemLookUpEdit CreateOrganizationCategoryLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            var content = new List<SelectListItemModel<string>>
            {
                new SelectListItemModel<string>() { Value = OrganizationCategory.Group.ToString(), Text = Resources.Organization_Group },
                new SelectListItemModel<string>() { Value = OrganizationCategory.Subsidiary.ToString(), Text = Resources.Organization_Subsidiary },
                new SelectListItemModel<string>() { Value = OrganizationCategory.Department.ToString(), Text = Resources.Organization_Department },
                new SelectListItemModel<string>() { Value = OrganizationCategory.WorkingGroup.ToString(), Text = Resources.Organization_WorkingGroup }
            };

            return CreateCommonLookUpEdit(edit, collection, content, "Value", "Text", "Text");
        }
        
        public static async Task<RepositoryItemLookUpEdit> CreateDictionaryTypeLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<DictionaryTypeListModel>("dictionaries", "get_types", "parentId=0");

            return CreateCommonLookUpEdit(edit, collection, content);
        }

        public static async Task<RepositoryItemTreeListLookUpEdit> CreateDictionaryTypeTreeListLookUpEdit(RepositoryItemTreeListLookUpEdit edit, RepositoryItemCollection itemCollection)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<DictionaryTypeListModel>("dictionaries", "get_types");

            return CreateCommonTreeListLookUpEdit(edit, itemCollection, ImagesHelper.Current.DictionaryImages, content);
        }

        public static async Task<RepositoryItemLookUpEdit> CreateDictionaryDataLookUpEdit(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, long typeId)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<DictionaryDataListModel>("dictionaries", "get_datas", $"typeId={typeId}");

            return CreateCommonLookUpEdit(edit, collection, content);
        }

        public static async Task<RepositoryItemTreeListLookUpEdit> CreateNavigationTreeListLookUpEdit(RepositoryItemTreeListLookUpEdit edit, RepositoryItemCollection itemCollection)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<ViewLinkListModel>("navs", "get_directories");

            return CreateCommonTreeListLookUpEdit(edit, itemCollection, ImagesHelper.Current.NavigationImages, content);
        }

        public static async Task<RepositoryItemTreeListLookUpEdit> CreateNavigationLinkTreeListLookUpEdit(RepositoryItemTreeListLookUpEdit edit, RepositoryItemCollection itemCollection)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<ViewLinkListModel>("navs");

            return CreateCommonTreeListLookUpEdit(edit, itemCollection, ImagesHelper.Current.NavigationImages, content);
        }

        public static async Task<RepositoryItemTreeListLookUpEdit> CreateOrganizationTreeListLookUpEdit(RepositoryItemTreeListLookUpEdit edit, RepositoryItemCollection itemCollection)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<OrganizationListModel>("organizations");

            return CreateCommonTreeListLookUpEdit(edit, itemCollection, ImagesHelper.Current.OrganizationImages, content);
        }

        public static async Task<RepositoryItemTreeListLookUpEdit> CreateSubsidiaryTreeListLookUpEdit(RepositoryItemTreeListLookUpEdit edit, RepositoryItemCollection itemCollection)
        {
            var content = await ServiceLocator.Resolve<IDataService>().GetListAsync<OrganizationListModel>("organizations", "get_subsidiaries");

            return CreateCommonTreeListLookUpEdit(edit, itemCollection, ImagesHelper.Current.OrganizationImages, content);
        }

        private static RepositoryItemLookUpEdit CreateCommonLookUpEdit<TModel>(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, IEnumerable<TModel> content) where TModel : class
        {
            return CreateCommonLookUpEdit<TModel>(edit, collection, content, "Id", "DisplayName", "DisplayName");
        }

        private static RepositoryItemLookUpEdit CreateCommonLookUpEdit<TModel>(RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, IEnumerable<TModel> content, string valueMember, string displayMember, string fieldName)
        {
            RepositoryItemLookUpEdit lue = edit ?? new RepositoryItemLookUpEdit();
            if (collection != null)
                collection.Add(lue);

            lue.ValueMember = valueMember;
            lue.DisplayMember = displayMember;
            lue.DataSource = content;
            lue.NullText = string.Empty;
            lue.Columns.Clear();
            lue.Columns.Add(new LookUpColumnInfo(fieldName));
            lue.ShowHeader = false;
            lue.ShowFooter = false;
            lue.DropDownRows = 10;
            lue.TextEditStyle = TextEditStyles.Standard;
            lue.AllowNullInput = DefaultBoolean.True;

            return lue;
        }

        private static RepositoryItemTreeListLookUpEdit CreateCommonTreeListLookUpEdit<TModel>(RepositoryItemTreeListLookUpEdit edit, RepositoryItemCollection itemCollection, ImageCollection imageCollection, IEnumerable<TModel> content) where TModel : class
        {
            RepositoryItemTreeListLookUpEdit tllue = edit ?? new RepositoryItemTreeListLookUpEdit();
            if (itemCollection != null)
                itemCollection.Add(tllue);
            
            tllue.ValueMember = "Id";
            tllue.DisplayMember = "DisplayName";
            tllue.DataSource = content;
            tllue.NullText = string.Empty;
            tllue.TextEditStyle = TextEditStyles.Standard;
            tllue.AllowNullInput = DefaultBoolean.True;
            tllue.ShowFooter = false;

            tllue.TreeList.Columns.Clear();
            TreeListColumn column = tllue.TreeList.Columns.AddVisible("DisplayName");
            column.OptionsColumn.AllowSort = false;

            tllue.TreeList.KeyFieldName = "Id";
            tllue.TreeList.ParentFieldName = "ParentId";
            tllue.TreeList.SelectImageList = imageCollection;
            tllue.TreeList.OptionsView.ShowColumns = false;
            tllue.TreeList.OptionsView.ShowIndicator = false;
            
            return tllue;
        }
    }
}
