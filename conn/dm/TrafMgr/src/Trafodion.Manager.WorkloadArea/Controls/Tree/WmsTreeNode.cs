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

using Trafodion.Manager.Framework.Navigation;
using Trafodion.Manager.WorkloadArea.Model;

namespace Trafodion.Manager.WorkloadArea.Controls.Tree
{
    /// <summary>
    /// A leaf node that holds a WmsObject
    /// </summary>
    public class WmsTreeNode : NavigationTreeNode
    {
        #region Member variables
        
        private WmsObject _wmsObject = null;
        private System.EventHandler<WmsObject.WmsModelEventArgs> _wmsModelEventHandler = null;

        #endregion Member variables

        #region Properties

        /// <summary>
        /// The Wms Object contained in the tree node
        /// </summary>
        public WmsObject WmsObject
        {
            get { return _wmsObject; }
            set { _wmsObject = value; }
        }
        /// <summary>
        /// The short description of the Wms object contained in the tree node
        /// </summary>
        public override string ShortDescription
        {
            get { return WmsObject.Name; }
        }
        /// <summary>
        /// The long description of the Wms object contained in the tree node
        /// </summary>
        public override string LongerDescription
        {
            get { return WmsObject.Name; }
        }
        #endregion Properties


        /// <summary>
        /// Constructs the leaf node for the Wms object
        /// </summary>
        /// <param name="aWmsObject"></param>
        public WmsTreeNode(WmsObject aWmsObject)
		{
            ImageKey = NavigationTreeView.BLANK_DOCUMENT_ICON;
            SelectedImageKey = NavigationTreeView.BLANK_DOCUMENT_ICON;
            _wmsObject = aWmsObject;
            Text = aWmsObject.Name;

            _wmsModelEventHandler = new System.EventHandler<WmsObject.WmsModelEventArgs>(WmsObject_ModelEvent);

            //Register the event handlers for the Wms object model
            AddHandlers(WmsObject);
        }

        /// <summary>
        /// Register to listen on the Wms object model events
        /// </summary>
        /// <param name="aWmsObject"></param>
        private void AddHandlers(WmsObject aWmsObject)
        {
            aWmsObject.WmsModelEvent += _wmsModelEventHandler;
        }

        /// <summary>
        /// Unregister listeners on the Wms object model
        /// </summary>
        /// <param name="aWmsObject"></param>
        private void RemoveHandlers(WmsObject aWmsObject)
        {
            aWmsObject.WmsModelEvent -= _wmsModelEventHandler;
        }

        /// <summary>
        /// Handle the model replaced event
        /// </summary>
        /// <param name="sender">the wms model that was replaced</param>
        /// <param name="e">Contains the new model that replaces the old</param>
        void WmsObject_ModelEvent(object sender, WmsObject.WmsModelEventArgs e)
        {
            ////Remove the model event handlers from the old wms model
            //RemoveHandlers((WmsObject)sender);

            ////Set the new wms model and register handlers to listen to the model events
            //this.WmsObject = e.WmsObject;
            //AddHandlers(WmsObject);

            //if (TreeView.SelectedNode == this)
            //{
            //    System.Windows.Forms.MessageBox.Show(
            //    System.String.Format("Object {0} has changed. It may have been recreated in another session.", ((WmsObject)sender).Name),
            //    "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning
            //    );
            //}
        }

        /// <summary>
        /// Refreshes the node
        /// </summary>
        /// <param name="aNavigationTreeNameFilter"></param>
        protected override void Refresh(NavigationTreeNameFilter aNavigationTreeNameFilter)
        {
            WmsObject.Refresh();
        }
    }
}