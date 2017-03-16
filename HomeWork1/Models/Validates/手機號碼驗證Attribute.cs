using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HomeWork1.Models.Validates
{
    public class 手機號碼驗證Attribute : DataTypeAttribute
    {
        public 手機號碼驗證Attribute():base(DataType.Text)
        {
            this.ErrorMessage = "手機號碼驗證失敗";
        }

        public override bool IsValid(object value)
        {
            string svalue = Convert.ToString(value);

            Regex regex = new Regex(@"\d{4}-\d{6}");
            Match match = regex.Match(svalue);
            if (!match.Success)
            {
                return false;
            }

            return true;
        }
    }
}