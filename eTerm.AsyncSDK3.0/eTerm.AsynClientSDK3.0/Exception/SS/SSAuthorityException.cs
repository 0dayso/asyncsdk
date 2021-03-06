﻿using System;
using System.Collections.Generic;
using System.Text;
using eTerm.ASynClientSDK;

namespace eTerm.ASynClientSDK.SSException {
    /// <summary>
    /// 无订座权限
    /// </summary>
    public class SSAuthorityException:SdkException {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSAuthorityException"/> class.
        /// </summary>
        public SSAuthorityException():base("无订座权限") { }
    }
}
