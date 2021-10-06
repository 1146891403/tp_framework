using System;
using System.Drawing;

namespace TP.Client.WinForm.Common.Controls
{
    public partial class ButtonLabel : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler ButtonClick;

        public ButtonLabel()
        {
            InitializeComponent();

            labelButton.Click += new EventHandler(LabelButton_Click);
        }
        
        public string Id { get; set; }

        private Image _buttonImage;
        public Image ButtonImage
        {
            get { return _buttonImage; }
            set
            {
                if(_buttonImage != value)
                {
                    _buttonImage = value;
                    labelButton.ImageOptions.Image = value;
                }
            }
        }

        private string _buttonName;
        public string ButtonName
        {
            get { return _buttonName; }
            set
            {
                if(_buttonName != value)
                {
                    _buttonName = value;
                    labelButton.Name = value;
                }
            }
        }

        private string _labelText;
        public string LabelText
        {
            get { return _labelText; }
            set
            {
                if(_labelText != value)
                {
                    _labelText = value;
                    lcText.Text = value;
                }
            }
        }

        private void LabelButton_Click(object sender, EventArgs e) => ButtonClick?.Invoke(sender, e);
    }
}
