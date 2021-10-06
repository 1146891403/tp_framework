using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Properties;

namespace TP.Client.WinForm.Common.Helpers
{
    public class RegexValidationRule : ValidationRule
    {
        private string _pattern;
        private bool _isNotBlank;

        public RegexValidationRule() : this(string.Empty, true) { }

        public RegexValidationRule(string pattern) : this(pattern, true) { }

        public RegexValidationRule(string pattern, bool isNotBlank)
        {
            this._pattern = pattern;
            this._isNotBlank = isNotBlank;
        }

        public string Pattern { get { return this._pattern; } set { this._pattern = value; } }

        public bool IsNotBlank { get { return this._isNotBlank; } set { this._isNotBlank = value; } }

        public override bool Validate(Control control, object value)
        {
            if (value == null && _isNotBlank)
            {
                ErrorText = Resources.RuleIsNotBlankWarning;
                ErrorType = ErrorType.Critical;
                return false;
            }

            return Regex.IsMatch(value.ToString(), this._pattern);
        }
    }
}
