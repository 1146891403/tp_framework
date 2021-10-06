using DevExpress.XtraEditors.DXErrorProvider;
using TP.Client.WinForm.Common.Properties;

namespace TP.Client.WinForm.Common.Helpers
{
    public class ValidationRulesHelper
    {
        private static ConditionValidationRule ruleIsNotBlank = null;
        public static ConditionValidationRule RuleIsNotBlank
        {
            get
            {
                if(ruleIsNotBlank == null)
                {
                    ruleIsNotBlank = new ConditionValidationRule
                    {
                        ConditionOperator = ConditionOperator.IsNotBlank,
                        ErrorText = Resources.RuleIsNotBlankWarning,
                        ErrorType = ErrorType.Critical
                    };
                }

                return ruleIsNotBlank;
            }
        }

        private static ConditionValidationRule ruleIsNotBlankOfTreeList = null;
        public static ConditionValidationRule RuleIsNOtBlankOfTreeList
        {
            get
            {
                if(ruleIsNotBlankOfTreeList == null)
                {
                    ruleIsNotBlankOfTreeList = new ConditionValidationRule
                    {
                        ConditionOperator = ConditionOperator.Greater,
                        Value1 = 0,
                        ErrorText = Resources.RuleIsNotBlankWarning,
                        ErrorType = ErrorType.Critical
                    };
                }

                return ruleIsNotBlankOfTreeList;
            }
        }

        private static ConditionValidationRule ruleGreaterZero = null;
        public static ConditionValidationRule RuleGreaterZero
        {
            get
            {
                if(ruleGreaterZero == null)
                {
                    ruleGreaterZero = new ConditionValidationRule
                    {
                        ConditionOperator = ConditionOperator.Greater,
                        Value1 = 0,
                        ErrorText = Resources.RuleGreaterZeroWarning,
                        ErrorType = ErrorType.Critical
                    };
                }

                return ruleGreaterZero;
            }
        }

        private static RegexValidationRule ruleUserName = null;
        public static RegexValidationRule RuleUserName
        {
            get
            {
                if(ruleUserName == null)
                {
                    ruleUserName = new RegexValidationRule
                    {
                        Pattern = "^[a-z][a-z0-9_-]{3,20}$",
                        IsNotBlank = true,
                        ErrorText = Resources.RuleUserNameWarning,
                        ErrorType = ErrorType.Critical
                    };
                }

                return ruleUserName;
            }
        }

        private static RegexValidationRule rulePassword = null;
        public static RegexValidationRule RulePassword
        {
            get
            {
                if(rulePassword == null)
                {
                    rulePassword = new RegexValidationRule
                    {
                        Pattern = "^[a-zA-Z0-9_-]{6,20}$",
                        IsNotBlank = true,
                        ErrorText = Resources.RulePasswordWarning,
                        ErrorType = ErrorType.Critical
                    };
                }

                return rulePassword;
            }
        }

        public static object CheckNull(object obj)
        {
            if (obj == null) return string.Empty;

            return obj;
        }
    }
}
