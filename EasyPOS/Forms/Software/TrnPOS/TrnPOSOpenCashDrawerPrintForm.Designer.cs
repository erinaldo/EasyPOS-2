﻿
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSOpenCashDrawerPrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDocumentOpenCashDrawer = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printDocumentOpenCashDrawer
            // 
            this.printDocumentOpenCashDrawer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentOpenCashDrawer_PrintPage);
            // 
            // TrnPOSOpenCashDrawerPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 106);
            this.ControlBox = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrnPOSOpenCashDrawerPrintForm";
            this.Text = "Print  - Open Cash Drawer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocumentOpenCashDrawer;
    }
}