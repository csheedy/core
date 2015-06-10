﻿//
// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2007-2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trafodion.Manager.Framework.Controls
{
    public partial class SystemMonitorStatusLightPopup : Form
    {
        bool enableCloseHandler = true;

        public bool EnableCloseHandler
        {
            get { return enableCloseHandler; }
            set { enableCloseHandler = value; }
        }

        public SystemMonitorStatusLightPopup(string windowTitle)
        {
            InitializeComponent();
            this.Text = windowTitle;
        }

        public Trafodion.Manager.Framework.Controls.TrafodionIGrid ErrorGrid
        {
            get { return TrafodionIGrid1; }
            set { TrafodionIGrid1 = value; }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!EnableCloseHandler)
                return;
            
            // The window must only be minimized in tray
            e.Cancel = true;
            this.Hide();
        }

        //public void ClearIgrid()
    }
}