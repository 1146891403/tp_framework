using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP.Client.WinForm.Common
{
    public class MessageBoxService
    {
        public static void Successed() => Successed("保存成功！");

        public static void Successed(string text) => Successed(text, "信息提示");

        public static void Successed(string text, string caption)
        {
            XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Failed(string error) => Failed(error, "錯誤提示");

        public static void Failed(string error, string caption)
        {
            XtraMessageBox.Show(error, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Failed(IEnumerable<string> errors) => Failed(errors, "錯誤提示");

        public static void Failed(IEnumerable<string> errors, string caption)
        {
            XtraMessageBox.Show(string.Join("\n", errors), caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
