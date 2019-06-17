using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Nhom4
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toobar1;
		private System.Windows.Forms.ToolBarButton toobar2;
		private System.Windows.Forms.ToolBarButton toobar3;
		private System.Windows.Forms.ToolBarButton toobar4;
		private System.Windows.Forms.ToolBarButton toobar5;
		private System.Windows.Forms.ToolBarButton toobar6;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.ToolBarButton toobar7;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.StatusBar sbr_mainform;
		private System.Windows.Forms.StatusBarPanel sbr_1;
		private System.Windows.Forms.StatusBarPanel sbr_2;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		public static MainForm main;
		public MainForm()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toobar1 = new System.Windows.Forms.ToolBarButton();
			this.toobar2 = new System.Windows.Forms.ToolBarButton();
			this.toobar3 = new System.Windows.Forms.ToolBarButton();
			this.toobar4 = new System.Windows.Forms.ToolBarButton();
			this.toobar5 = new System.Windows.Forms.ToolBarButton();
			this.toobar6 = new System.Windows.Forms.ToolBarButton();
			this.toobar7 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.sbr_mainform = new System.Windows.Forms.StatusBar();
			this.sbr_1 = new System.Windows.Forms.StatusBarPanel();
			this.sbr_2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.sbr_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbr_2)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem13});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem7,
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem8});
			this.menuItem1.Text = "&Manager";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
			this.menuItem2.Text = "Log Out";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
			this.menuItem7.Text = "User Manager";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 2;
			this.menuItem11.Text = "Booking Room";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 3;
			this.menuItem12.Text = "Add Customer";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.Text = "Close";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem9,
																					  this.menuItem10});
			this.menuItem3.Text = "&Edit";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.menuItem5.Text = "Buffer Manager";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
			this.menuItem6.Text = "Booking Buffer";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "BillRoom";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Text = "BillBuffer";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "&Exit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem14,
																					   this.menuItem15});
			this.menuItem13.Text = "Help";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.Text = "About US!";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "Help!";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toobar1,
																						this.toobar2,
																						this.toobar3,
																						this.toobar4,
																						this.toobar5,
																						this.toobar6,
																						this.toobar7});
			this.toolBar1.ButtonSize = new System.Drawing.Size(110, 45);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(776, 51);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toobar1
			// 
			this.toobar1.ImageIndex = 0;
			this.toobar1.Text = "Search Room";
			// 
			// toobar2
			// 
			this.toobar2.ImageIndex = 1;
			this.toobar2.Text = "Check In";
			// 
			// toobar3
			// 
			this.toobar3.ImageIndex = 2;
			this.toobar3.Text = "Check Out";
			// 
			// toobar4
			// 
			this.toobar4.ImageIndex = 3;
			this.toobar4.Text = "Buffet Order";
			// 
			// toobar5
			// 
			this.toobar5.ImageIndex = 5;
			this.toobar5.Text = "Change Room";
			// 
			// toobar6
			// 
			this.toobar6.ImageIndex = 6;
			this.toobar6.Text = "User Manager";
			// 
			// toobar7
			// 
			this.toobar7.ImageIndex = 7;
			this.toobar7.Text = "Report";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// sbr_mainform
			// 
			this.sbr_mainform.Location = new System.Drawing.Point(0, 434);
			this.sbr_mainform.Name = "sbr_mainform";
			this.sbr_mainform.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																							this.sbr_1,
																							this.sbr_2});
			this.sbr_mainform.ShowPanels = true;
			this.sbr_mainform.Size = new System.Drawing.Size(776, 22);
			this.sbr_mainform.TabIndex = 3;
			// 
			// sbr_1
			// 
			this.sbr_1.Text = "Background";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(776, 456);
			this.Controls.Add(this.sbr_mainform);
			this.Controls.Add(this.toolBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "DeltaHotel";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.sbr_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbr_2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			
			//sbr_mainform.stat.Text=MainForm.ActiveForm.Text.ToString();
			sbr_2.Text=DateTime.Now.ToString();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			BillRoom billroom = new BillRoom();
			billroom.MdiParent=this;
			billroom.Show();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			try
			{
				if(e.Button.Equals(toobar1))
				{
					SearchRoom sear = new SearchRoom();
					sear.MdiParent=this;
					sear.Show();
				}
				else if(e.Button.Equals(toobar2))
				{
					CheckIn checkin = new CheckIn();
					checkin.MdiParent=this;
					checkin.Show();
				}
				else if(e.Button.Equals(toobar3))
				{
					CheckOut checkout = new CheckOut();
					checkout.MdiParent=this;
					checkout.Show();
				}
				else if(e.Button.Equals(toobar4))
				{
					BufferOrder bufer = new BufferOrder();
					bufer.MdiParent=this;
					bufer.Show();
				}
				else if(e.Button.Equals(toobar5))
				{
					ChangeRoom chang = new ChangeRoom();
					chang.MdiParent=this;
					chang.Show();
				}
				else if(e.Button.Equals(toobar6))
				{
					UserManager use = new UserManager();
					use.MdiParent=this;
					use.Show();
				}
				else if(e.Button.Equals(toobar7))
				{
					Report repo = new Report();
					repo.MdiParent=this;
					repo.Show();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			frm_Login f1 = new frm_Login();
			f1.Show();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			UserManager use = new UserManager();
			use.MdiParent=this;
			use.Show();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			BufferManager mager = new BufferManager();
			mager.MdiParent=this;
			mager.Show();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			BookingBuffer bookfer = new BookingBuffer();
			bookfer.MdiParent=this;
			bookfer.Show();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			BillBuffer bill = new BillBuffer();
			bill.MdiParent=this;
			bill.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(      "Are you sure!\n       Exit now!","Choose!",MessageBoxButtons.YesNo).ToString()=="Yes")
			{
																															 
				Application.Exit();
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			BookingRoom bu = new BookingRoom();
			bu.MdiParent=this;
			bu.Show();
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			Customer cus = new Customer();
			cus.MdiParent=this;
			cus.Show();
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			try
			{
				string var_PATH = Application.StartupPath ;
				
				var_PATH = Application.StartupPath + "\\Aboutus.doc";	

				Help.ShowHelp(new Form(), var_PATH);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			try
			{
				string var_PATH = Application.StartupPath ;
				
				var_PATH = Application.StartupPath + "\\User Manual.doc";	

				Help.ShowHelp(new Form(), var_PATH);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

	}
}
