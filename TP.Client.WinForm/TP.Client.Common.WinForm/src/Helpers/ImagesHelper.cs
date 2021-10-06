using DevExpress.Utils;
using System.Drawing;
using TP.Client.WinForm.Common.Properties;

namespace TP.Client.WinForm.Common.Helpers
{
    public class ImagesHelper
    {
        private static ImagesHelper current;

        private static ImageCollection diskIcons;
        private static ImageCollection genderImages;
        private static ImageCollection currencyImages;
        private static ImageCollection receiptTypeImages;
        private static ImageCollection ratingImages;
        private static ImageCollection ratingLargeImages;
        private static ImageCollection activeRents;
        private static ImageCollection columnHeaderImages;
        private static ImageCollection columnHeaderSmoothImages;
        private static ImageCollection barImages;
        private static ImageCollection folderIcons;
        private static Image aboutImage;
        private static ImageCollection navigationImages;
        private static ImageCollection groupImages;
        private static ImageCollection organizationImages;
        private static ImageCollection roleImages;
        private static ImageCollection functionImages;
        private static ImageCollection dictionaryImages;

        public static ImagesHelper Current
        {
            get
            {
                if (current == null)
                    current = new ImagesHelper();
                return current;
            }
        }

        public ImageCollection DiskIcons
        {
            get
            {
                if (ImagesHelper.diskIcons == null)
                    ImagesHelper.diskIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.DiskFormats.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ImagesHelper.diskIcons;
            }
        }

        public ImageCollection GenderImages
        {
            get
            {
                if (ImagesHelper.genderImages == null)
                {
                    ImagesHelper.genderImages = new ImageCollection();

                    ImagesHelper.genderImages.AddImage(Resources.Mr);
                    ImagesHelper.genderImages.AddImage(Resources.Ms);
                }

                return ImagesHelper.genderImages;
            }
        }

        public ImageCollection CurrencyImages
        {
            get
            {
                if (ImagesHelper.currencyImages == null)
                {
                    ImagesHelper.currencyImages = new ImageCollection();

                    ImagesHelper.currencyImages.AddImage(Resources.cn);
                    ImagesHelper.currencyImages.AddImage(Resources.hk);
                    ImagesHelper.currencyImages.AddImage(Resources.us);
                    ImagesHelper.currencyImages.AddImage(Resources.jp);
                }

                return ImagesHelper.genderImages;
            }
        }

        public ImageCollection ReceiptTypeImages
        {
            get
            {
                if (ImagesHelper.receiptTypeImages == null)
                    ImagesHelper.receiptTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ReceiptType.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ImagesHelper.receiptTypeImages;
            }
        }

        public ImageCollection RatingImages
        {
            get
            {
                if (ratingImages == null)
                    ratingImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.RatingsSmall.png", typeof(ImagesHelper).Assembly, new Size(38, 16));
                return ratingImages;
            }
        }

        public ImageCollection RatingLargeImages
        {
            get
            {
                if (ratingLargeImages == null)
                    ratingLargeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.RatingsLarge.png", typeof(ImagesHelper).Assembly, new Size(250, 37));
                return ratingLargeImages;
            }
        }

        public ImageCollection ActiveRents
        {
            get
            {
                if (activeRents == null)
                    activeRents = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ActiveRents.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return activeRents;
            }
        }
        public ImageCollection BarImages
        {
            get
            {
                if (ImagesHelper.barImages == null)
                    ImagesHelper.barImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.BarImages16x16.png", typeof(ImagesHelper).Assembly, new System.Drawing.Size(16, 16));
                return ImagesHelper.barImages;
            }
        }

        public ImageCollection ColumnHeaderImages
        {
            get
            {
                if (ImagesHelper.columnHeaderImages == null)
                    ImagesHelper.columnHeaderImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ColumnHeaderImages.png", typeof(ImagesHelper).Assembly, new System.Drawing.Size(13, 13));
                return ImagesHelper.columnHeaderImages;
            }
        }

        public ImageCollection ColumnHeaderSmoothImages
        {
            get
            {
                if (ImagesHelper.columnHeaderSmoothImages == null)
                    ImagesHelper.columnHeaderSmoothImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ColumnHeaderSmoothImages.png", typeof(ImagesHelper).Assembly, new System.Drawing.Size(13, 13));
                return ImagesHelper.columnHeaderSmoothImages;
            }
        }

        public ImageCollection FolderIcons
        {
            get
            {
                if (folderIcons == null)
                    folderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.FolderIcons16x16.png", typeof(ImagesHelper).Assembly, new System.Drawing.Size(16, 16));
                return folderIcons;
            }
        }

        public Image AboutImage
        {
            get
            {
                if (ImagesHelper.aboutImage == null)
                    ImagesHelper.aboutImage = ResourceImageHelper.CreateImageFromResources("DevExpress.VideoRent.Resources.Images.About.png", typeof(ImagesHelper).Assembly);
                return ImagesHelper.aboutImage;
            }
        }

        public ImageCollection NavigationImages
        {
            get
            {
                if(ImagesHelper.navigationImages == null)
                {
                    ImagesHelper.navigationImages = new ImageCollection();

                    ImagesHelper.navigationImages.AddImage(Resources.home_16x16);
                    ImagesHelper.navigationImages.AddImage(Resources.documentmap_16x16);
                    ImagesHelper.navigationImages.AddImage(Resources.documentmap_16x16);
                    ImagesHelper.navigationImages.AddImage(Resources.window_16x16);
                }

                return ImagesHelper.navigationImages;
            }
        }

        public ImageCollection GroupImages
        {
            get
            {
                if (ImagesHelper.groupImages == null)
                {
                    ImagesHelper.groupImages = new ImageCollection();

                    ImagesHelper.groupImages.AddImage(Resources.groupfieldcollection_16x16);
                    ImagesHelper.groupImages.AddImage(Resources.group_16x16);
                }

                return ImagesHelper.groupImages;
            }
        }

        public ImageCollection OrganizationImages
        {
            get
            {
                if (ImagesHelper.organizationImages == null)
                {
                    ImagesHelper.organizationImages = new ImageCollection();

                    ImagesHelper.organizationImages.AddImage(Resources.home_16x16);
                    ImagesHelper.organizationImages.AddImage(Resources.documentmap_16x16);
                    ImagesHelper.organizationImages.AddImage(Resources.publicfix_16x16);
                    ImagesHelper.organizationImages.AddImage(Resources.team_16x16);
                }

                return ImagesHelper.organizationImages;
            }
        }

        public ImageCollection RoleImages
        {
            get
            {
                if(ImagesHelper.roleImages == null)
                {
                    ImagesHelper.roleImages = new ImageCollection();

                    ImagesHelper.roleImages.AddImage(Resources.home_16x16);
                    ImagesHelper.roleImages.AddImage(Resources.documentmap_16x16);
                    ImagesHelper.roleImages.AddImage(Resources.role_16x16);
                    ImagesHelper.roleImages.AddImage(Resources.role_16x16);
                }

                return ImagesHelper.roleImages;
            }
        }

        public ImageCollection FunctionImages
        {
            get
            {
                if(ImagesHelper.functionImages == null)
                {
                    ImagesHelper.functionImages = new ImageCollection();

                    ImagesHelper.functionImages.AddImage(Resources.home_16x16);
                    ImagesHelper.functionImages.AddImage(Resources.documentmap_16x16);
                    ImagesHelper.functionImages.AddImage(Resources.documentmap_16x16);
                    ImagesHelper.functionImages.AddImage(Resources.window_16x16);
                    ImagesHelper.functionImages.AddImage(Resources.morefunctions_16x16);
                }

                return ImagesHelper.functionImages;
            }
        }

        public ImageCollection DictionaryImages
        {
            get
            {
                if(ImagesHelper.dictionaryImages == null)
                {
                    ImagesHelper.dictionaryImages = new ImageCollection();

                    ImagesHelper.dictionaryImages.AddImage(Resources.text_16x16);
                    ImagesHelper.dictionaryImages.AddImage(Resources.content_16x16);
                }

                return ImagesHelper.dictionaryImages;
            }
        }
    }
}