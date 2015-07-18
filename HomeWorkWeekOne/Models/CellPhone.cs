using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace HomeWorkWeekOne.Models
{
    public class CellPhone : ValidationAttribute , IClientValidatable
    {
        /// <summary>
        /// 驗證手機格式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;
            if (value is String)
                return Regex.IsMatch(value.ToString(), @"\d{4}-\d{6}");
            else
                return true;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule Rule = new ModelClientValidationRule
            {
                ValidationType = "cellphone",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            };
            Rule.ValidationParameters["input"] = "09XXXXXXXX";
            yield return Rule;
        }

    }
}