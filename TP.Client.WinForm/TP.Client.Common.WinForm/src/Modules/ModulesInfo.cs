using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using TP.Infrastructure.Common.Enums;

namespace TP.Client.WinForm.Common
{
    public class ModulesInfo
    {
        public event EventHandler CurrentModuleChanged;
        
        private static ModulesInfo instance;
        private ModuleInfo currentModule;
        private ModuleInfoCollection collection;

        static ModulesInfo()
        {
            instance = new ModulesInfo();
        }

        public ModulesInfo()
        {
            this.collection = new ModuleInfoCollection();
            this.currentModule = null;
        }

        public ModuleInfoCollection Collection { get { return collection; } }

        public ModuleInfo CurrentModulebase
        {
            get { return currentModule; }
            set { currentModule = value; }
        }
        
        public static int Count { get { return instance.collection.Count; } }

        public static ModulesInfo Instance { get { return instance; } }

        public static ModuleInfo CurrentModuleInfo { get { return instance.currentModule; } }

        public static Control CurrentModule
        {
            get
            {
                if (CurrentModuleInfo != null)
                    return CurrentModuleInfo.TModule;
                return null;
            }
        }
        public static void Add(string name, Type moduleType)
        {
            Add(name, moduleType, "");
        }

        public static void Add(string name, Type moduleType, string description)
        {
            Add(name, moduleType, description, null);
        }

        public static void Add(string name, Type moduleType, string description, string imageName)
        {
            Add(name, moduleType, description, imageName, "");
        }

        public static void Add(string name, Type moduleType, string description, string imageName, string group)
        {
            ModuleInfo value = new ModuleInfo(name, moduleType, description, imageName, group);
            Instance.Collection.Add(value);
        }

        public static ModuleInfo GetItem(int index) { return instance.Collection[index]; }

        public static ModuleInfo GetItem(string name) { return instance.Collection[name]; }

        public static void RemoveItem(string name)
        {
            ModuleInfo info = GetItem(name);
            if (info != null)
                instance.Collection.Remove(info);
        }

        protected static void RaiseModuleChanged()
        {
            if (Instance.CurrentModuleChanged != null)
                Instance.CurrentModuleChanged(Instance, EventArgs.Empty);
        }

        public static void FillNavBar(NavBarControl navBar)
        {
            FillNavBar(navBar, NavBarGroupStyle.LargeIconsText, NavBarImage.Small);
        }

        public static void FillRibbon(RibbonControl ribbon, IEnumerable<UserNavigation> navigations)
        {
            if (ribbon == null) return;

            FillRibbon(ribbon, null, null, navigations);
        }

        public static void FillRibbon(RibbonControl ribbon, RibbonPage page, RibbonPageGroup group, IEnumerable<UserNavigation> navigations)
        {
            foreach (var nav in navigations)
            {
                if (nav.Category == NavigationCategory.Page)
                {
                    page = GetRibbonPage(ribbon, nav.Name, nav.Text);
                    FillRibbon(ribbon, page, null, nav.Children);
                }
                if (nav.Category == NavigationCategory.Group)
                {
                    group = GetRibbonPageGroup(page, nav.Name, nav.Text);
                    FillRibbon(ribbon, null, group, nav.Children);
                }

                if (nav.Category == NavigationCategory.Button && GetItem(nav.Name) is ModuleInfo module)
                {
                    BarButtonItem barBtn = new BarButtonItem()
                    {
                        Name = nav.Name,
                        Caption = nav.Text,
                        Glyph = module.SmallImage,
                        LargeGlyph = module.LargeImage
                    };

                    ribbon.Items.Add(barBtn);

                    group.ItemLinks.Add(barBtn);
                }
            }
        }


        public static RibbonPage GetRibbonPage(RibbonControl ribbon, string pageName, string pageText)
        {
            var page = ribbon.Pages.GetPageByName(pageName);

            if (page != null) return page;

            var newPage = new RibbonPage() { Name = pageName, Text = pageText };
            ribbon.Pages.Add(newPage);

            return newPage;
        }

        public static RibbonPageGroup GetRibbonPageGroup(RibbonPage page, string groupName, string groupText)
        {
            var group = page.GetGroupByName(groupName);

            if (group != null) return group;

            var newGroup = new RibbonPageGroup() { Name = groupName, Text = groupText };
            page.Groups.Add(newGroup);

            return newGroup;
        }

        public static void FillNavBar(NavBarControl navBar, NavBarGroupStyle groupStyle, NavBarImage groupCaptionImage)
        {
            if (navBar == null) return;
            navBar.BeginUpdate();
            for (int i = 0; i < Count; i++)
            {
                if (GetItem(i).Group == "About") continue;
                NavBarItem item = new NavBarItem();
                navBar.Items.Add(item);
                item.Caption = GetItem(i).Name;
                item.SmallImage = GetItem(i).SmallImage;
                item.LargeImage = GetItem(i).LargeImage;
                item.Tag = GetItem(i);
                GetNavBarGroup(navBar, GetItem(i).Group, groupStyle, groupCaptionImage).ItemLinks.Add(new NavBarItemLink(item));
            }
            navBar.EndUpdate();
        }

        private static NavBarGroup GetNavBarGroup(NavBarControl navBar, string groupName, NavBarGroupStyle groupStyle, NavBarImage groupCaptionImage)
        {
            foreach (NavBarGroup group in navBar.Groups)
            {
                if (group.Caption == groupName) return group;
            }
            NavBarGroup newGroup = navBar.Groups.Add();
            newGroup.Caption = groupName;
            newGroup.Name = groupName;
            newGroup.GroupStyle = groupStyle;
            newGroup.GroupCaptionUseImage = groupCaptionImage;
            return newGroup;
        }

        public static void ShowModule(string key, string name, TabbedView tabbedView)
        {
            ModuleInfo item = GetItem(key);
            var control = item.TModule as XtraUserControl;

            DocumentSettings settings = new DocumentSettings
            {
                Caption = name
            };
            DocumentSettings.Attach(control, settings);
            control.Padding = new Padding(0);
            tabbedView.AddDocument(control);
            tabbedView.ActivateDocument(control);
        }

        public static void ShowModule(ModuleInfo item, string name, Form form, TabbedView tabbedView)
        {
            var control = item.TModule as XtraUserControl;

            Process.RunAsync(
                () =>
                {
                    DocumentSettings settings = new DocumentSettings
                    {
                        Caption = name
                    };
                    DocumentSettings.Attach(control, settings);
                    control.Padding = new Padding(0);
                    if (form.InvokeRequired)
                    {
                        form.BeginInvoke(new ThreadStart(() =>
                        {
                            tabbedView.AddDocument(control);
                            tabbedView.ActivateDocument(control);
                        }));
                    }
                    else
                    {
                        tabbedView.AddDocument(control);
                        tabbedView.ActivateDocument(control);
                    }
                }, t => { });
        }
    }
}
