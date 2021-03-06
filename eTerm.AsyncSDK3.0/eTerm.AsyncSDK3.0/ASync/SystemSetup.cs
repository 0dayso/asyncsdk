﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using eTerm.AsyncSDK.Base;

namespace eTerm.AsyncSDK {
    /// <summary>
    /// SDK配置体
    /// </summary>
    [Serializable]
    public sealed class SystemSetup:BaseBinary<SystemSetup> {

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemSetup"/> class.
        /// </summary>
        public SystemSetup() {
            SessionCollection = new List<TSessionSetup>();
            PlugInCollection = new List<PlugInSetup>();
            AsynCollection = new List<ConnectSetup>();
            GroupCollection = new List<SDKGroup>();
        }

        /// <summary>
        /// Gets or sets the session collection.
        /// </summary>
        /// <value>The session collection.</value>
        public List<TSessionSetup> SessionCollection { get; set; }

        /// <summary>
        /// Gets or sets the group collection.
        /// </summary>
        /// <value>The group collection.</value>
        public List<SDKGroup> GroupCollection { get; set; }

        /// <summary>
        /// Gets or sets the plug in collection.
        /// </summary>
        /// <value>The plug in collection.</value>
        [XmlIgnore]
        public List<PlugInSetup> PlugInCollection { get; set; }

        /// <summary>
        /// Gets or sets the asyn collection.
        /// </summary>
        /// <value>The asyn collection.</value>
        public List<ConnectSetup> AsynCollection { get; set; }

        /// <summary>
        /// Gets or sets the plug in path.
        /// </summary>
        /// <value>The plug in path.</value>
        public string PlugInPath { get; set; }

        /// <summary>
        /// Gets or sets the allow plug in.
        /// </summary>
        /// <value>The allow plug in.</value>
        public bool? AllowPlugIn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [auto reconnect].
        /// </summary>
        /// <value><c>true</c> if [auto reconnect]; otherwise, <c>false</c>.</value>
        public bool? AutoReconnect { get; set; }

        /// <summary>
        /// Gets or sets the allow secret key.
        /// </summary>
        /// <value>The allow secret key.</value>
        public bool? AllowSecretKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [max reconnect].
        /// </summary>
        /// <value><c>true</c> if [max reconnect]; otherwise, <c>false</c>.</value>
        public int? MaxReconnect { get; set; }

        /// <summary>
        /// Gets or sets the reconnect delay.
        /// </summary>
        /// <value>The reconnect delay.</value>
        public int? ReconnectDelay { get; set; }

        /// <summary>
        /// 流量统计保存频率(默认为10分钟).
        /// </summary>
        /// <value>The statistical frequency.</value>
        public int? StatisticalFrequency { get; set; }

        /// <summary>
        /// 端口号.
        /// </summary>
        /// <value>The external port.</value>
        public int? ExternalPort { get; set; }

        /// <summary>
        /// 配置连接维护频率(分钟).
        /// </summary>
        /// <value>The sequence rate.</value>
        public int? SequenceRate { get; set; }

        /// <summary>
        /// 配置连接维护指令.
        /// </summary>
        /// <value>The sequence directive.</value>
        public string SequenceDirective { get; set; }

        /// <summary>
        /// 中心指令服务器(127.0.0.1).
        /// </summary>
        /// <value>The core server.</value>
        public string CoreServer { get; set; }

        /// <summary>
        /// 中心指令服务器端口号.
        /// </summary>
        /// <value>The core server port.</value>
        public int? CoreServerPort { get; set; }

        /// <summary>
        /// 中心指令用户名.
        /// </summary>
        /// <value>The core account.</value>
        public string CoreAccount { get; set; }

        /// <summary>
        /// 中心指令用户密码.
        /// </summary>
        /// <value>The core pass.</value>
        public string CorePass { get; set; }

        /// <summary>
        /// 是否允许日志.
        /// </summary>
        /// <value>The allow log.</value>
        public bool? AllowLog { get; set; }
    }
}
