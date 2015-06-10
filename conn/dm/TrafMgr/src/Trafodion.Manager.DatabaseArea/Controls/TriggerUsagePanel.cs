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

using System.Windows.Forms;
using Trafodion.Manager.DatabaseArea.Model;

namespace Trafodion.Manager.DatabaseArea.Controls
{

    /// <summary>
    /// A a panel that displays information about a Trigger's usage info.
    /// </summary>
    public class TriggerUsagePanel : TriggerPanel
    {
        private DatabaseObjectsControl _databaseObjectsControl;

        /// <summary>
        /// Create a panel that displays information about a Trigger's usage.
        /// </summary>
        /// <param name="aDatabaseObjectsControl">The DatabaseTreeView control</param>
        /// <param name="aTrafodionTrigger">The TrafodionTrigger whose usage is to be displayed</param>
        public TriggerUsagePanel(DatabaseObjectsControl aDatabaseObjectsControl, TrafodionTrigger aTrafodionTrigger)
            : base(Properties.Resources.Usage, aTrafodionTrigger)
        {
            _databaseObjectsControl = aDatabaseObjectsControl;
            Load();
        }

        /// <summary>
        /// Populate the panel
        /// </summary>
        protected override void Load()
        {
            //Create the usage panel and add to parent container.
            TrafodionUsagePanelT<TrafodionTrigger> usagePanel = new TrafodionUsagePanelT<TrafodionTrigger>(_databaseObjectsControl, TrafodionTrigger);
            usagePanel.Dock = DockStyle.Fill;
            usagePanel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(usagePanel);

            //Add the different types of usage objects to the usage panel.
            usagePanel.AddUsageObjects(Properties.Resources.Uses, TrafodionTrigger.TheUsesTablesTrafodionTrigger);
            usagePanel.AddUsageObjects(Properties.Resources.Uses, TrafodionTrigger.TheUsesViewsTrafodionTrigger);
            usagePanel.AddUsageObjects(Properties.Resources.Uses, TrafodionTrigger.TheUsesRoutinesTrafodionTrigger);
        }

        /// <summary>
        /// Clone the panel
        /// </summary>
        /// <returns></returns>
        override public Control Clone()
        {
            return new TriggerUsagePanel(null, TrafodionTrigger);
        }
    }

}