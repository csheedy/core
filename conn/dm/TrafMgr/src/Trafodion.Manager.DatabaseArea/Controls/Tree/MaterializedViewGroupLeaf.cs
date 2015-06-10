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

using Trafodion.Manager.DatabaseArea.Model;

namespace Trafodion.Manager.DatabaseArea.Controls.Tree
{
	/// <summary>
	/// Summary description for MaterializedViewGroupLeaf.
	/// </summary>
    public class MaterializedViewGroupLeaf : DatabaseTreeNode
	{
		public MaterializedViewGroupLeaf(TrafodionMaterializedViewGroup aTrafodionMaterializedViewGroup)
            :base(aTrafodionMaterializedViewGroup)
		{
            ImageKey = DatabaseTreeView.DB_VIEW_ICON;
            SelectedImageKey = DatabaseTreeView.DB_VIEW_ICON;
		}

        public TrafodionMaterializedViewGroup TrafodionMaterializedViewGroup
		{
            get { return (TrafodionMaterializedViewGroup)this.TrafodionObject; }
		}

        override public string LongerDescription
		{
			get
			{
                return "Materialized View Group " + TrafodionMaterializedViewGroup.VisibleAnsiName;
			}
		}
	}
}