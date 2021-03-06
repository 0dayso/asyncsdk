﻿using System;
using System.Collections.Generic;
using System.Text;
using eTerm.ASynClientSDK;

namespace eTerm.ASynClientSDK.AVException {
    /// <summary>
    /// 日期错误  
    /// </summary>
    public class AVDateException:SdkException {
        /// <summary>
        /// Initializes a new instance of the <see cref="AVDateException"/> class.
        /// </summary>
        public AVDateException() : base("日期错误") { }
    }
}
