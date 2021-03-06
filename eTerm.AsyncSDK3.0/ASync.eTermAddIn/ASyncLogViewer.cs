﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASync.MiddleWare;
using eTerm.AsyncSDK;

namespace ASync.eTermAddIn {
    public partial class ASyncLogViewer : BaseAddIn {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASyncLogViewer"/> class.
        /// </summary>
        public ASyncLogViewer() {
            InitializeComponent();
            this.Load += new EventHandler(
                    delegate(object sender, EventArgs e) {
                        dateTimeInput1.Value = DateTime.Now.AddDays(-5);
                        dateTimeInput2.Value = DateTime.Now;
                        this.richTextBox1.BackColor = Color.Black;
                        this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                        this.richTextBox1.Font = new Font("新宋体", 11.0f, FontStyle.Regular);
                        this.columnHeader1.Width = 50;
                        this.columnHeader1.Text = @"编号";
                        this.columnHeader2.Width = 80;
                        this.columnHeader2.Text = @"客户端";
                        this.columnHeader3.Width = 80;
                        this.columnHeader3.Text = @"配置帐号";
                        this.columnHeader4.Width = 150;
                        this.columnHeader4.Text = @"原始指令";
                        this.columnHeader5.Width = 120;
                        this.columnHeader5.Text = @"记录时间";
                        this.listViewEx1.DoubleClick += new EventHandler(this.listViewEx1_SelectedIndexChanged);
                        foreach (TSessionSetup session in AsyncStackNet.Instance.ASyncSetup.SessionCollection)
                            this.comboBoxEx1.Items.Add(session.SessionCode);
                        foreach (ConnectSetup setup in AsyncStackNet.Instance.ASyncSetup.AsynCollection)
                            this.comboBoxEx2.Items.Add(setup.userName);
                    }
                );
        }

        /// <summary>
        /// Queries the log.
        /// </summary>
        private void QueryLog() {
            listViewEx1.Items.Clear();
            foreach (SQLiteLog log in SQLiteExecute.Instance.PacketSQLiteLog(string.Empty, string.Empty, null, null, null)) {
                ListViewItem logItem = new ListViewItem(new string[] { 
                    string.Empty,
                    log.TSession.ToString(),
                    log.TASync.ToString(),
                    log.DbCommand,
                    log.DbDate.ToString(@"yyyy-MM-dd HH:mm:ss")
                });
                logItem.Tag = log;
                listViewEx1.Items.Add(logItem);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnQuery control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnQuery_Click(object sender, EventArgs e) {
            QueryLog();
            tabControl2.SelectedTab = tabItem1;
        }

        /// <summary>
        /// Gets the name of the button.
        /// </summary>
        /// <value>The name of the button.</value>
        public override string ButtonName {
            get { return "eTerm日志查询分析器"; }
        }

        /// <summary>
        /// Gets the image icon.
        /// </summary>
        /// <value>The image icon.</value>
        public override string ImageIcon {
            get { return "Hourglass.png"; }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listViewEx1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listViewEx1.SelectedItems.Count != 1) return;
            this.richTextBox1.Text = string.Format("☉{0}\r{1}", ((SQLiteLog)this.listViewEx1.SelectedItems[0].Tag).DbCommand, ((SQLiteLog)this.listViewEx1.SelectedItems[0].Tag).DbResult);
            tabControl2.SelectedTab = tabItem3;
        }

    }
}
