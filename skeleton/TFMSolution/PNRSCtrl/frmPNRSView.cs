﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DisplayCtrl;
using TFM.Common.Models;
using OperationCtrl.Constant;
namespace PNRSCtrl
{
    public partial class frmPNRSView : Form
    {
     
        #region event
        /// <summary>
        /// delegate swith user
        /// </summary>
        /// <returns></returns>
        public delegate void RequestSwitchUser(bool isShow);

        /// <summary>
        /// 
        /// </summary>
        public event RequestSwitchUser EventRequestSwitchUser;
        #endregion

        #region Private members
        /// <summary>
        /// 
        /// </summary>
        private SearchView frmSearchView;

        /// <summary>
        /// 
        /// </summary>
        private OperationCtrl.GetUpdatePriceListCtrl frmGetupdateFriceList;
        #endregion

        public frmPNRSView()
        {
            InitializeComponent();
            frmSearchView = new SearchView();
            frmGetupdateFriceList = new OperationCtrl.GetUpdatePriceListCtrl();
        }

        private void domainUpDown4_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSwitchUser_Click(object sender, EventArgs e)
        {
            if (EventRequestSwitchUser != null) 
            {
                EventRequestSwitchUser(true);
            }

        }

        private void frmPNRSView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (EventRequestSwitchUser != null)
            {
                EventRequestSwitchUser(false);
            }
        }

        private void toolStriptoolStripPriceList_Click(object sender, EventArgs e)
        {       
            frmGetupdateFriceList.ShowDialog();
        }

        private void toolStripSearch_Click(object sender, EventArgs e)
        {
            frmSearchView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label2.Text = PNRSUtilities.PNRSData.PNRSDataObj.pricelis;
        }
    }
}
