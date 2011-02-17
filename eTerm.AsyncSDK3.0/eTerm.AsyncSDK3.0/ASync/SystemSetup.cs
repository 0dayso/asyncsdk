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
    }
}