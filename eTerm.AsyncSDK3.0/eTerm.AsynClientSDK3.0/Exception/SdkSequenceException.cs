﻿using System;
using System.Collections.Generic;
using System.Text;
using eTerm.ASynClientSDK;

namespace eTerm.ASynClientSDK {
    /// <summary>
    /// 序号错误
    /// </summary>
    public class SdkSequenceException:SdkException {
        /// <summary>
        /// Initializes a new instance of the <see cref="SdkSequenceException"/> class.
        /// </summary>
        public SdkSequenceException() : base("指令的序号不存在，请检查!") { }
    }
}
