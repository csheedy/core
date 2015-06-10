//
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
using Trafodion.Manager.Framework.Controls;

namespace Trafodion.Manager.DatabaseArea.Controls
{

    /// <summary>
    /// A TabPage that displays a table's usage.
    /// </summary>
    public class TableUsageTabPage : DelayedPopulateClonableTabPage
    {
        private DatabaseObjectsControl _databaseObjectsControl;
        private TrafodionTable _sqlMxTable;

        /// <summary>
        /// The database objects control property.  Changing it to a new value will not have an effect
        /// until the Refresh() method is called.  We don't call it directly because we want this page to be delayed.
        /// </summary>
        public DatabaseObjectsControl TheDatabaseObjectsControl
        {
            get { return _databaseObjectsControl; }
        }

        /// <summary>
        /// The table property.  Changing it to a new value will not have an effect
        /// until the Refresh() method is called.  We don't call it directly because we want this page to be delayed.
        /// </summary>
        public TrafodionTable TrafodionTable
        {
            get { return _sqlMxTable; }
        }

        /// <summary>
        /// Create a TabPage that displays a table's usage.
        /// </summary>
        /// <param name="aDatabaseObjectsControl">The DatabaseObjectsControl whose tree we can use.  
        /// Will be null if there is no associated DatabaseObjectsControl.</param>
        /// <param name="aTrafodionTable">The table whose usage is to be displayed.</param>
        public TableUsageTabPage(DatabaseObjectsControl aDatabaseObjectsControl, TrafodionTable aTrafodionTable)
            : base(Properties.Resources.Usage)
        {
            _sqlMxTable = aTrafodionTable;
            _databaseObjectsControl = aDatabaseObjectsControl;
        }

        public override void PrepareForPopulate()
        {
            object a = _sqlMxTable.TheTrafodionMaterializedViews;
            a = _sqlMxTable.TheTrafodionViews;
            a = _sqlMxTable.TheTrafodionSynonyms;
        }
        /// <summary>
        /// Constructs a panel for displaying the usage information for this table
        /// </summary>
        override protected void Populate()
        {
            Controls.Clear();

            // Create the panel and fill this tab page with it.
            TableUsagePanel tableUsagePanel = new TableUsagePanel(TheDatabaseObjectsControl, TrafodionTable);
            tableUsagePanel.Dock = DockStyle.Fill;
            Controls.Add(tableUsagePanel);
        }

    }

}