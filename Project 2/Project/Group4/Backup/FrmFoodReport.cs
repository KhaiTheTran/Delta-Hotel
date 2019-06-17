using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nhom4
{
	/// <summary>
	/// Summary description for FrmFoodReport.
	/// </summary>
	public class FrmFoodReport : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_food;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFoodReport()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmFoodReport));
			this.crv_food = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crv_food
			// 
			this.crv_food.ActiveViewIndex = -1;
			this.crv_food.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crv_food.Location = new System.Drawing.Point(0, 0);
			this.crv_food.Name = "crv_food";
			this.crv_food.ReportSource = null;
			this.crv_food.Size = new System.Drawing.Size(416, 266);
			this.crv_food.TabIndex = 0;
			this.crv_food.Load += new System.EventHandler(this.crystalReportViewer1_Load);
			// 
			// FrmFoodReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 266);
			this.Controls.Add(this.crv_food);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmFoodReport";
			this.Text = "FrmFoodReport";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
		#endregion

		private void crystalReportViewer1_Load(object sender, System.EventArgs e)
		{
			crv_FoodReport frp=new crv_FoodReport();
			crv_food.ReportSource=frp;
		}
	}
}
