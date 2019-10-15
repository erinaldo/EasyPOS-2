﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software
{
    public partial class SysSoftwareForm : Form
    {
        public SysSoftwareForm()
        {
            InitializeComponent();
            InitializeDefaultForm();
        }

        TabPage tabPageItemList = new TabPage { Name = "tabPageItemList", Text = "Item List" };
        TabPage tabPagePOSSalesList = new TabPage { Name = "tabPagePOSSalesList", Text = "Sales List" };
        TabPage tabPagePOSSalesDetail = new TabPage { Name = "tabPagePOSSalesDetail", Text = "Sales Detail" };
        TabPage tabPageDiscountingList = new TabPage { Name = "tabPageDiscountingList", Text = "Discounting List" };
        TabPage tabPagePOSReport = new TabPage { Name = "tabPagePOSReport", Text = "POS Report" };

        MstItem.MstItemListForm mstItemListForm = null;
        MstDiscounting.MstDiscountingListForm mstDiscountingListForm = null;
        TrnPOS.TrnSalesListForm trnSalesListForm = null;
        TrnPOS.TrnSalesDetailForm trnSalesDetailForm = null;
        RepPOSReport.RepPOSReportForm repPOSReportForm = null;

        public void InitializeDefaultForm()
        {
            SysMenu.SysMenuForm sysMenuForm = new SysMenu.SysMenuForm(this)
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill
            };

            tabPageSysMenu.Controls.Add(sysMenuForm);
        }

        public void AddTabPageItemList()
        {
            tabPagePOSSalesDetail.Controls.Remove(mstItemListForm);

            mstItemListForm = new MstItem.MstItemListForm(this)
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill
            };

            tabPageItemList.Controls.Add(mstItemListForm);

            if (tabControlSoftware.TabPages.Contains(tabPageItemList) == true)
            {
                tabControlSoftware.SelectTab(tabPageItemList);
            }
            else
            {
                tabControlSoftware.TabPages.Add(tabPageItemList);
                tabControlSoftware.SelectTab(tabPageItemList);
            }
        }

        public void AddTabPageDiscountingList()
        {
            tabPagePOSSalesDetail.Controls.Remove(mstDiscountingListForm);

            mstDiscountingListForm = new MstDiscounting.MstDiscountingListForm(this)
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill
            };

            tabPageDiscountingList.Controls.Add(mstDiscountingListForm);

            if (tabControlSoftware.TabPages.Contains(tabPageDiscountingList) == true)
            {
                tabControlSoftware.SelectTab(tabPageDiscountingList);
            }
            else
            {
                tabControlSoftware.TabPages.Add(tabPageDiscountingList);
                tabControlSoftware.SelectTab(tabPageDiscountingList);
            }
        }

        public void AddTabPagePOSSalesList()
        {
            tabPagePOSSalesDetail.Controls.Remove(trnSalesListForm);

            trnSalesListForm = new TrnPOS.TrnSalesListForm(this)
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill
            };

            tabPagePOSSalesList.Controls.Add(trnSalesListForm);

            if (tabControlSoftware.TabPages.Contains(tabPagePOSSalesList) == true)
            {
                tabControlSoftware.SelectTab(tabPagePOSSalesList);
            }
            else
            {
                tabControlSoftware.TabPages.Add(tabPagePOSSalesList);
                tabControlSoftware.SelectTab(tabPagePOSSalesList);
            }
        }

        public void AddTabPagePOSSalesDetail(TrnPOS.TrnSalesListForm salesListForm)
        {
            tabPagePOSSalesDetail.Controls.Remove(trnSalesDetailForm);

            trnSalesDetailForm = new TrnPOS.TrnSalesDetailForm(this, salesListForm)
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill
            };

            tabPagePOSSalesDetail.Controls.Add(trnSalesDetailForm);

            if (tabControlSoftware.TabPages.Contains(tabPagePOSSalesDetail) == true)
            {
                tabControlSoftware.SelectTab(tabPagePOSSalesDetail);
            }
            else
            {
                tabControlSoftware.TabPages.Add(tabPagePOSSalesDetail);
                tabControlSoftware.SelectTab(tabPagePOSSalesDetail);
            }
        }

        public void AddTabPagePOSReport()
        {
            tabPagePOSSalesDetail.Controls.Remove(repPOSReportForm);

            repPOSReportForm = new RepPOSReport.RepPOSReportForm(this)
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill
            };

            tabPagePOSReport.Controls.Add(repPOSReportForm);

            if (tabControlSoftware.TabPages.Contains(tabPagePOSReport) == true)
            {
                tabControlSoftware.SelectTab(tabPagePOSReport);
            }
            else
            {
                tabControlSoftware.TabPages.Add(tabPagePOSReport);
                tabControlSoftware.SelectTab(tabPagePOSReport);
            }
        }

        public void RemoveTabPage()
        {
            tabControlSoftware.TabPages.Remove(tabControlSoftware.SelectedTab);
            tabControlSoftware.SelectTab(tabControlSoftware.TabPages.Count - 1);
        }
    }
}