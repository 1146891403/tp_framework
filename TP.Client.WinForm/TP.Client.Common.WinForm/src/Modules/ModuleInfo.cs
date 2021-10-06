using DevExpress.Utils.Design;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Helpers;

namespace TP.Client.WinForm.Common
{
    public class ModuleInfo
    {
        private string name;
        private string description;
        private string group;
        private Type moduleType;
        private string imageName;
        private bool wasShown;
        private Control module;
        //private Assembly moduleAssembly;

        public ModuleInfo(string name, Type moduleType) : this(name, moduleType, "")
        {
        }

        public ModuleInfo(string name, Type moduleType, string description) : this(name, moduleType, description, "")
        {
        }

        public ModuleInfo(string name, Type moduleType, string description, string imageName) : this(name, moduleType, description, imageName, "")
        {
        }

        public ModuleInfo(string name, Type moduleType, string description, string imageName, string group)
        {
            this.name = name;
            this.moduleType = moduleType;
            this.description = description;
            this.imageName = imageName;
            this.group = group;
        }

        public string Name { get { return this.name; } }

        public string Description { get { return this.description; } }

        public string Group { get { return this.group; } }

        public string TypeName { get { return this.FullTypeName.Substring(this.FullTypeName.LastIndexOf('.') + 1); } }

        public string FullTypeName { get { return this.moduleType.FullName; } }

        public Image SmallImage { get { return ElementHelper.GetImage(moduleType, imageName, ImageSize.Size16x16); } }

        public Image LargeImage { get { return ElementHelper.GetImage(moduleType, imageName, ImageSize.Size32x32); } }

        public bool Created { get { return this.module != null; } }

        public bool WasShown { get { return this.wasShown; } set { this.wasShown = value; } }

        public Control TModule
        {
            get
            {
                if(this.module == null || this.module.IsDisposed)
                {
                    ConstructorInfo constructor = moduleType.GetConstructor(Type.EmptyTypes);
                    if(constructor == null)
                        throw new ApplicationException(moduleType.FullName + " doesn't have public constructor with empty parameters");
                    try
                    {
                        this.module = (constructor.Invoke(null) as Control);
                    }
                    catch (TargetInvocationException ex)
                    {
                        string str = "Module " + moduleType.FullName + " constructor throws an exception:";
                        throw new ApplicationException(str + Environment.NewLine, ex.InnerException);
                    }
                }

                return this.module;
            }
        }
        
        public void ModuleDispose()
        {
            if (this.module != null)
            {
                //this.module.ResetPibbonPage();
                this.module.Dispose();
                this.module = null;
            }
        }
    }
}