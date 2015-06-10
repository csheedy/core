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

using Trafodion.Manager.DatabaseArea.Model;

namespace Trafodion.Manager.DatabaseArea.Controls
{

    /// <summary>
    /// A panel that shows arbitrary info about a SQL MaterializedViewGroup.
    /// </summary>
    public class MaterializedViewGroupPanel : TrafodionObjectPanel
    {

        /// <summary>
        /// Default constructor for the UI designer.
        /// </summary>
        public MaterializedViewGroupPanel()
        {
        }

        /// <summary>
        /// Create a panel that shows arbitrary info about a SQL MaterializedViewGroup.
        /// </summary>
        /// <param name="aName">A name that will be appendeded to the object's name in a window title.</param>
        /// <param name="aTrafodionMaterializedViewGroup">The materializedViewGroup whose information is to be displayed.</param>
        public MaterializedViewGroupPanel(string aName, TrafodionMaterializedViewGroup aTrafodionMaterializedViewGroup)
            : base(aName, aTrafodionMaterializedViewGroup)
        {
        }

        /// <summary>
        /// The MaterializedViewGroup whose information is to be displayed.
        /// </summary>
        public TrafodionMaterializedViewGroup TrafodionMaterializedViewGroup
        {
            get { return TheTrafodionObject as TrafodionMaterializedViewGroup; }
            set { TheTrafodionObject = value; }
        }

        /// <summary>
        /// Tell the panel to populate or repopulate itself.
        /// </summary>
        virtual protected void Load()
        {
        }

    }

}