using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Nhom4
{
	/// <summary>
	/// Summary description for RoomReportfrom.
	/// </summary>
	public class RoomReportfrom : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RoomReportfrom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RoomReportfrom));
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(512, 266);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
			// 
			// RoomReportfrom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 266);
			this.Controls.Add(this.crystalReportViewer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RoomReportfrom";
			this.Text = "RoomReportfrom";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.RoomReportfrom_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void crystalReportViewer1_Load(object sender, System.EventArgs e)
		{
			try
			{
							crv_RoomReport roomrp=new crv_RoomReport();
							this.crystalReportViewer1.ReportSource=roomrp;
//				Conetion DBConn = new Conetion();
//				SqlDataAdapter myDataAdapter = DBConn.getDataFromDB();
//
//				DataSet dataReport = new DataSet();
//				myDataAdapter.Fill(dataReport,"MybuffetReportTable");
//
//				CrystalReport1 myDataReport = new CrystalReport1();
//				myDataReport.SetDataSource(dataReport);
//				crystalReportViewer1.ReportSource = myDataReport;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void RoomReportfrom_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
