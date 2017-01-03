﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kidd.Common.Validation.Format
{
    /// <summary>
    /// 格式驗證介面
    /// </summary>
    public interface IFormatValidation
    {
        /// <summary>
        /// 實作驗證方法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Validate(string value);
    }
}
