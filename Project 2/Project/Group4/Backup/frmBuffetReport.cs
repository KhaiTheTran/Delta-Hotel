using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nhom4
{
	/// <summary>
	/// Summary description for frmBuffetReport.
	/// </summary>
	public class frmBuffetReport : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_buffet;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBuffetReport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBuffetReport));
			this.crv_buffet = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crv_buffet
			// 
			this.crv_buffet.ActiveViewIndex = -1;
			this.crv_buffet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crv_buffet.Location = new System.Drawing.Point(0, 0);
			this.crv_buffet.Name = "crv_buffet";
			this.crv_buffet.ReportSource = null;
			this.crv_buffet.Size = new System.Drawing.Size(376, 266);
			this.crv_buffet.TabIndex = 0;
			this.crv_buffet.Load += new System.EventHandler(this.crv_buffet_Load);
			// 
			// frmBuffetReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 266);
			this.Controls.Add(this.crv_buffet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuffetReport";
			this.Text = "frmBuffetReport";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
		#endregion

		private void crv_buffet_Load(object sender, System.EventArgs e)
		{
			crv_BuffetReport bufrp=new crv_BuffetReport();
			crv_buffet.ReportSource=bufrp;
		}
	}
}
