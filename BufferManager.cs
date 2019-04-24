using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Nhom4
{
	/// <summary>
	/// Summary description for FoodManager.
	/// </summary>
	public class BufferManager : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lbl_country;
		private System.Windows.Forms.Label lbl_type;
		private System.Windows.Forms.Label lbl_kind;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Label lbl_buffermaneger;
		private System.Windows.Forms.GroupBox grp_bufferdetail;
		private System.Windows.Forms.Label lbl_buffername;
		private System.Windows.Forms.GroupBox lbl_vnd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_iname;
		private System.Windows.Forms.ComboBox comb_type;
		private System.Windows.Forms.ComboBox combo_kind;
		private System.Windows.Forms.TextBox txt_origin;
		private System.Windows.Forms.ComboBox combo_buf_type;
		private System.Windows.Forms.TextBox txt_id;
		SqlConnection cn;
		SqlCommand comd,comd1,comd2;
		DataSet ds=new DataSet();
		DataSet ds1=new DataSet();
		SqlDataAdapter adap,adap1;
		string str,str1,str3,str4;
		int food_id;
		bool flat=false;
		private System.Windows.Forms.TextBox txt_buf_id;
		private System.Windows.Forms.TextBox txt_price;
		private System.Windows.Forms.ComboBox combo_status;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btn_print_buffet;
		private System.Windows.Forms.Button btn_print_food;
		private System.Windows.Forms.DataGrid dbg_buffet;
		private System.Windows.Forms.DataGrid dbg_food;
		private System.Windows.Forms.Label lbl_food;
		private System.Windows.Forms.Label lbl_buf_type;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_price;
		private System.Windows.Forms.Label lbl_Sdate;
		private System.Windows.Forms.Label lbl_buf_id;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BufferManager()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BufferManager));
			this.lbl_buffermaneger = new System.Windows.Forms.Label();
			this.grp_bufferdetail = new System.Windows.Forms.GroupBox();
			this.dbg_buffet = new System.Windows.Forms.DataGrid();
			this.dbg_food = new System.Windows.Forms.DataGrid();
			this.lbl_vnd = new System.Windows.Forms.GroupBox();
			this.lbl_buffername = new System.Windows.Forms.Label();
			this.lbl_country = new System.Windows.Forms.Label();
			this.lbl_type = new System.Windows.Forms.Label();
			this.lbl_kind = new System.Windows.Forms.Label();
			this.txt_iname = new System.Windows.Forms.TextBox();
			this.comb_type = new System.Windows.Forms.ComboBox();
			this.combo_kind = new System.Windows.Forms.ComboBox();
			this.txt_origin = new System.Windows.Forms.TextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.lbl_food = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_buf_type = new System.Windows.Forms.Label();
			this.lbl_status = new System.Windows.Forms.Label();
			this.lbl_price = new System.Windows.Forms.Label();
			this.lbl_Sdate = new System.Windows.Forms.Label();
			this.txt_price = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.combo_buf_type = new System.Windows.Forms.ComboBox();
			this.combo_status = new System.Windows.Forms.ComboBox();
			this.txt_buf_id = new System.Windows.Forms.TextBox();
			this.lbl_buf_id = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_print_buffet = new System.Windows.Forms.Button();
			this.btn_print_food = new System.Windows.Forms.Button();
			this.grp_bufferdetail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_buffet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbg_food)).BeginInit();
			this.lbl_vnd.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_buffermaneger
			// 
			this.lbl_buffermaneger.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_buffermaneger.ForeColor = System.Drawing.Color.Blue;
			this.lbl_buffermaneger.Location = new System.Drawing.Point(135, 9);
			this.lbl_buffermaneger.Name = "lbl_buffermaneger";
			this.lbl_buffermaneger.Size = new System.Drawing.Size(362, 32);
			this.lbl_buffermaneger.TabIndex = 0;
			this.lbl_buffermaneger.Text = "Foods and Buffet Manager";
			// 
			// grp_bufferdetail
			// 
			this.grp_bufferdetail.Controls.Add(this.dbg_buffet);
			this.grp_bufferdetail.Controls.Add(this.dbg_food);
			this.grp_bufferdetail.Controls.Add(this.lbl_vnd);
			this.grp_bufferdetail.Controls.Add(this.groupBox1);
			this.grp_bufferdetail.Controls.Add(this.btn_print_buffet);
			this.grp_bufferdetail.Controls.Add(this.btn_print_food);
			this.grp_bufferdetail.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_bufferdetail.ForeColor = System.Drawing.Color.Blue;
			this.grp_bufferdetail.Location = new System.Drawing.Point(24, 48);
			this.grp_bufferdetail.Name = "grp_bufferdetail";
			this.grp_bufferdetail.Size = new System.Drawing.Size(584, 384);
			this.grp_bufferdetail.TabIndex = 1;
			this.grp_bufferdetail.TabStop = false;
			this.grp_bufferdetail.Text = "Information Details";
			// 
			// dbg_buffet
			// 
			this.dbg_buffet.CaptionText = "List Buffets ";
			this.dbg_buffet.DataMember = "";
			this.dbg_buffet.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_buffet.Location = new System.Drawing.Point(296, 208);
			this.dbg_buffet.Name = "dbg_buffet";
			this.dbg_buffet.Size = new System.Drawing.Size(272, 136);
			this.dbg_buffet.TabIndex = 14;
			// 
			// dbg_food
			// 
			this.dbg_food.CaptionText = "Menu Foods";
			this.dbg_food.DataMember = "";
			this.dbg_food.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_food.Location = new System.Drawing.Point(16, 208);
			this.dbg_food.Name = "dbg_food";
			this.dbg_food.Size = new System.Drawing.Size(272, 136);
			this.dbg_food.TabIndex = 13;
			// 
			// lbl_vnd
			// 
			this.lbl_vnd.BackColor = System.Drawing.SystemColors.Control;
			this.lbl_vnd.Controls.Add(this.lbl_buffername);
			this.lbl_vnd.Controls.Add(this.lbl_country);
			this.lbl_vnd.Controls.Add(this.lbl_type);
			this.lbl_vnd.Controls.Add(this.lbl_kind);
			this.lbl_vnd.Controls.Add(this.txt_iname);
			this.lbl_vnd.Controls.Add(this.comb_type);
			this.lbl_vnd.Controls.Add(this.combo_kind);
			this.lbl_vnd.Controls.Add(this.txt_origin);
			this.lbl_vnd.Controls.Add(this.txt_id);
			this.lbl_vnd.Controls.Add(this.lbl_food);
			this.lbl_vnd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_vnd.Location = new System.Drawing.Point(16, 24);
			this.lbl_vnd.Name = "lbl_vnd";
			this.lbl_vnd.Size = new System.Drawing.Size(272, 176);
			this.lbl_vnd.TabIndex = 12;
			this.lbl_vnd.TabStop = false;
			this.lbl_vnd.Text = "Food Details";
			// 
			// lbl_buffername
			// 
			this.lbl_buffername.Location = new System.Drawing.Point(14, 56);
			this.lbl_buffername.Name = "lbl_buffername";
			this.lbl_buffername.Size = new System.Drawing.Size(88, 23);
			this.lbl_buffername.TabIndex = 1;
			this.lbl_buffername.Text = "Food Name: ";
			// 
			// lbl_country
			// 
			this.lbl_country.Location = new System.Drawing.Point(14, 80);
			this.lbl_country.Name = "lbl_country";
			this.lbl_country.Size = new System.Drawing.Size(88, 23);
			this.lbl_country.TabIndex = 2;
			this.lbl_country.Text = "Original:";
			// 
			// lbl_type
			// 
			this.lbl_type.Location = new System.Drawing.Point(14, 104);
			this.lbl_type.Name = "lbl_type";
			this.lbl_type.Size = new System.Drawing.Size(88, 23);
			this.lbl_type.TabIndex = 3;
			this.lbl_type.Text = "Food Type:";
			// 
			// lbl_kind
			// 
			this.lbl_kind.Location = new System.Drawing.Point(14, 131);
			this.lbl_kind.Name = "lbl_kind";
			this.lbl_kind.Size = new System.Drawing.Size(88, 23);
			this.lbl_kind.TabIndex = 4;
			this.lbl_kind.Text = "Food Kind:";
			// 
			// txt_iname
			// 
			this.txt_iname.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_iname.Location = new System.Drawing.Point(110, 56);
			this.txt_iname.Name = "txt_iname";
			this.txt_iname.Size = new System.Drawing.Size(144, 22);
			this.txt_iname.TabIndex = 8;
			this.txt_iname.Text = "";
			// 
			// comb_type
			// 
			this.comb_type.ForeColor = System.Drawing.SystemColors.ControlText;
			this.comb_type.Items.AddRange(new object[] {
														   "Breakfast",
														   "Lunch",
														   "Dinner"});
			this.comb_type.Location = new System.Drawing.Point(110, 104);
			this.comb_type.Name = "comb_type";
			this.comb_type.Size = new System.Drawing.Size(144, 24);
			this.comb_type.TabIndex = 6;
			this.comb_type.SelectedIndexChanged += new System.EventHandler(this.comb_type_SelectedIndexChanged);
			// 
			// combo_kind
			// 
			this.combo_kind.ForeColor = System.Drawing.SystemColors.ControlText;
			this.combo_kind.Items.AddRange(new object[] {
															"Starter",
															"Sup",
															"Main Course"});
			this.combo_kind.Location = new System.Drawing.Point(110, 129);
			this.combo_kind.Name = "combo_kind";
			this.combo_kind.Size = new System.Drawing.Size(144, 24);
			this.combo_kind.TabIndex = 11;
			this.combo_kind.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// txt_origin
			// 
			this.txt_origin.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_origin.Location = new System.Drawing.Point(110, 80);
			this.txt_origin.Name = "txt_origin";
			this.txt_origin.Size = new System.Drawing.Size(144, 22);
			this.txt_origin.TabIndex = 8;
			this.txt_origin.Text = "";
			// 
			// txt_id
			// 
			this.txt_id.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_id.Location = new System.Drawing.Point(110, 32);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(82, 22);
			this.txt_id.TabIndex = 8;
			this.txt_id.Text = "";
			// 
			// lbl_food
			// 
			this.lbl_food.Location = new System.Drawing.Point(16, 32);
			this.lbl_food.Name = "lbl_food";
			this.lbl_food.Size = new System.Drawing.Size(64, 24);
			this.lbl_food.TabIndex = 1;
			this.lbl_food.Text = "Food ID: ";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.lbl_buf_type);
			this.groupBox1.Controls.Add(this.lbl_status);
			this.groupBox1.Controls.Add(this.lbl_price);
			this.groupBox1.Controls.Add(this.lbl_Sdate);
			this.groupBox1.Controls.Add(this.txt_price);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.combo_buf_type);
			this.groupBox1.Controls.Add(this.combo_status);
			this.groupBox1.Controls.Add(this.txt_buf_id);
			this.groupBox1.Controls.Add(this.lbl_buf_id);
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(296, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 176);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buffet Details";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(104, 133);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
			this.dateTimePicker1.TabIndex = 13;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// lbl_buf_type
			// 
			this.lbl_buf_type.Location = new System.Drawing.Point(8, 58);
			this.lbl_buf_type.Name = "lbl_buf_type";
			this.lbl_buf_type.Size = new System.Drawing.Size(88, 23);
			this.lbl_buf_type.TabIndex = 1;
			this.lbl_buf_type.Text = "Buffet Type: ";
			// 
			// lbl_status
			// 
			this.lbl_status.Location = new System.Drawing.Point(7, 85);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(88, 23);
			this.lbl_status.TabIndex = 3;
			this.lbl_status.Text = "Status:";
			// 
			// lbl_price
			// 
			this.lbl_price.Location = new System.Drawing.Point(7, 109);
			this.lbl_price.Name = "lbl_price";
			this.lbl_price.Size = new System.Drawing.Size(88, 23);
			this.lbl_price.TabIndex = 4;
			this.lbl_price.Text = "Price:";
			// 
			// lbl_Sdate
			// 
			this.lbl_Sdate.Location = new System.Drawing.Point(5, 133);
			this.lbl_Sdate.Name = "lbl_Sdate";
			this.lbl_Sdate.Size = new System.Drawing.Size(96, 23);
			this.lbl_Sdate.TabIndex = 5;
			this.lbl_Sdate.Text = "Service Date:";
			// 
			// txt_price
			// 
			this.txt_price.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_price.Location = new System.Drawing.Point(104, 109);
			this.txt_price.Name = "txt_price";
			this.txt_price.Size = new System.Drawing.Size(96, 22);
			this.txt_price.TabIndex = 8;
			this.txt_price.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(207, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "USD";
			// 
			// combo_buf_type
			// 
			this.combo_buf_type.ForeColor = System.Drawing.SystemColors.ControlText;
			this.combo_buf_type.Items.AddRange(new object[] {
																"Breakfast",
																"Lunch",
																"Dinner"});
			this.combo_buf_type.Location = new System.Drawing.Point(104, 56);
			this.combo_buf_type.Name = "combo_buf_type";
			this.combo_buf_type.Size = new System.Drawing.Size(160, 24);
			this.combo_buf_type.TabIndex = 6;
			this.combo_buf_type.SelectedIndexChanged += new System.EventHandler(this.combo_buf_type_SelectedIndexChanged);
			// 
			// combo_status
			// 
			this.combo_status.ForeColor = System.Drawing.SystemColors.ControlText;
			this.combo_status.Items.AddRange(new object[] {
															  "Yes",
															  "No"});
			this.combo_status.Location = new System.Drawing.Point(104, 83);
			this.combo_status.Name = "combo_status";
			this.combo_status.Size = new System.Drawing.Size(96, 24);
			this.combo_status.TabIndex = 11;
			this.combo_status.SelectedIndexChanged += new System.EventHandler(this.combo_status_SelectedIndexChanged);
			// 
			// txt_buf_id
			// 
			this.txt_buf_id.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_buf_id.Location = new System.Drawing.Point(104, 32);
			this.txt_buf_id.Name = "txt_buf_id";
			this.txt_buf_id.Size = new System.Drawing.Size(96, 22);
			this.txt_buf_id.TabIndex = 8;
			this.txt_buf_id.Text = "";
			// 
			// lbl_buf_id
			// 
			this.lbl_buf_id.Location = new System.Drawing.Point(8, 34);
			this.lbl_buf_id.Name = "lbl_buf_id";
			this.lbl_buf_id.Size = new System.Drawing.Size(72, 24);
			this.lbl_buf_id.TabIndex = 1;
			this.lbl_buf_id.Text = "Buffet ID: ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn_close);
			this.groupBox3.Controls.Add(this.btn_cancel);
			this.groupBox3.Controls.Add(this.btn_delete);
			this.groupBox3.Controls.Add(this.btn_update);
			this.groupBox3.Controls.Add(this.btn_Add);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.Blue;
			this.groupBox3.Location = new System.Drawing.Point(24, 432);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(584, 48);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(415, 16);
			this.btn_close.Name = "btn_close";
			this.btn_close.TabIndex = 4;
			this.btn_close.Text = "Close";
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(335, 16);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "Clear";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(255, 16);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.TabIndex = 2;
			this.btn_delete.Text = "Delete";
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(175, 16);
			this.btn_update.Name = "btn_update";
			this.btn_update.TabIndex = 1;
			this.btn_update.Text = "Update";
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.Color.Blue;
			this.btn_Add.Location = new System.Drawing.Point(95, 16);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.TabIndex = 0;
			this.btn_Add.Text = "Add";
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_print_buffet
			// 
			this.btn_print_buffet.Location = new System.Drawing.Point(397, 352);
			this.btn_print_buffet.Name = "btn_print_buffet";
			this.btn_print_buffet.Size = new System.Drawing.Size(93, 23);
			this.btn_print_buffet.TabIndex = 4;
			this.btn_print_buffet.Text = "Print Buffet";
			this.btn_print_buffet.Click += new System.EventHandler(this.btn_print_buffet_Click);
			// 
			// btn_print_food
			// 
			this.btn_print_food.Location = new System.Drawing.Point(95, 352);
			this.btn_print_food.Name = "btn_print_food";
			this.btn_print_food.Size = new System.Drawing.Size(88, 23);
			this.btn_print_food.TabIndex = 4;
			this.btn_print_food.Text = "Print Food";
			this.btn_print_food.Click += new System.EventHandler(this.btn_print_food_Click);
			// 
			// BufferManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 494);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.grp_bufferdetail);
			this.Controls.Add(this.lbl_buffermaneger);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BufferManager";
			this.Text = "BufferManager";
			this.Load += new System.EventHandler(this.FoodManager_Load);
			this.grp_bufferdetail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_buffet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbg_food)).EndInit();
			this.lbl_vnd.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		public void update()
		{
			try
			{
				cn=Conetion.conet();
				comd2=new SqlCommand("select Foods.Food_ID,foods.Name_Food,foods.Country_Food,foods.Type_Food from foods",cn);
				adap=new SqlDataAdapter(comd2);
				ds.Clear();
				adap.Fill(ds,"data");
				dbg_food.DataSource=ds;
				dbg_food.DataMember="data";
				/////////////////////////////
				comd1=new SqlCommand("select Buffet_ID,Type_Buffet,Status,Price,Buffet_Date from Buffet",cn);
				adap1=new SqlDataAdapter(comd1);
				ds1.Clear();
				adap1.Fill(ds1,"data");
				dbg_buffet.DataSource=ds1;
				dbg_buffet.DataMember="data";
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void FoodManager_Load(object sender, System.EventArgs e)
		{
			update();
		
		}


		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public void cleartext()
		{
			txt_id.Text="";
			txt_buf_id.Text="";
			txt_iname.Text="";
			txt_origin.Text="";
			txt_price.Text="";
			comb_type.Text="";
			combo_buf_type.Text="";
			combo_kind.Text="";
			
			combo_status.Text="";
		}
		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			cleartext();
		}

		private void btn_Add_Click(object sender, System.EventArgs e)
		{
			///add Foods Item
			if(Regex.IsMatch(txt_id.Text.Trim(),@"[a-zA-Z0-9]+$"))
			{
				MessageBox.Show("System was automatic generated Item Id!");
			}
			if(Regex.IsMatch(txt_iname.Text.Trim(),@"[a-zA-z0-9 ]+$")&&(MessageBox.Show("Would you like to save Item record?","Addition",MessageBoxButtons.YesNo).ToString()=="Yes"))
			{
			
				if(txt_iname.Text=="")
				{
					MessageBox.Show("Please, Enter Item name Correctly!");
					
				}			
				else if(txt_origin.Text=="")
				{
					MessageBox.Show("Please, Enter Original Correctly!");
				}			
				else if(str==null)
				{
					MessageBox.Show("Please, select type Correctly!");
				}			
				else if(str1==null)
				{
					MessageBox.Show("Please, Select kind Correctly!");
				}
				else
				{
					try
					{						
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						try
						{
							comd1=new SqlCommand("select max(Food_ID) from foods",cn);
						
							food_id=Convert.ToInt32(comd1.ExecuteScalar());
						
						}
						catch(Exception ex)
						{
							food_id=0;
							Console.WriteLine(ex);
						}
						food_id=food_id+1;										
						comd=new SqlCommand("set dateformat dmy insert into Foods values("+food_id+",'"+txt_iname.Text.Trim()+"','"+txt_origin.Text.Trim()+"','"+str.Trim()+"','"+str1.Trim()+"')",cn);
						comd.ExecuteNonQuery();
						cn.Close();
						MessageBox.Show("Item Record has been saved!");
				
					}
					catch(Exception ex)

					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			///add Buffet
			if(Regex.IsMatch(txt_price.Text.Trim(),@"[0-9]+$")&&(MessageBox.Show("Would you like to save Buffet record?","Addition",MessageBoxButtons.YesNo).ToString()=="Yes"))
			{
				flat=true;
			}
			
			if(flat==true)
			{
				flat=false;
				if(Regex.IsMatch(txt_buf_id.Text.Trim(),@"[a-zA-Z0-9]+$"))
				{
					MessageBox.Show("System was automatic generated Buffet Id!");
				}
				if(str3==null)
				{
					MessageBox.Show("Please, Select Buffet Type!");
				}				
				else if(!Regex.IsMatch(txt_price.Text.Trim(),@"[0-9]+$"))
				{
					MessageBox.Show("Please, Enter this field in digits!");
				}
				else if(str4==null)
				{
					MessageBox.Show("Please, Select date correctly!");
				}
				else
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						try
						{
							comd1=new SqlCommand("select max(buffet_ID) from buffet",cn);
							
							food_id=Convert.ToInt32(comd1.ExecuteScalar());

						}
						catch(Exception ex)
						{
							food_id=0;
							
							Console.WriteLine(ex);
						}
						food_id=food_id+1;					
						comd=new SqlCommand("set dateformat dmy insert into Buffet values("+food_id+",'"+combo_buf_type.Text+"','"+combo_status.Text+"',"+txt_price.Text+",'"+str4+"')",cn);
						comd.ExecuteNonQuery();
						MessageBox.Show("Record Buffet has been saved!");
						cn.Close();
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			cleartext();
		}
		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str1 =combo_kind.SelectedItem.ToString();			
		}
		private void comb_type_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str =comb_type.SelectedItem.ToString();			
		}
		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			if(Regex.IsMatch(txt_id.Text.Trim(),@"[0-9]+$"))
			{
				if(!Regex.IsMatch(txt_id.Text.Trim(),@"[0-9]+$"))
				{
					MessageBox.Show("Please, Enter Item Id in number!");
				}
				else if(MessageBox.Show("        Are you sure?\n         Delete this Item!","Addition",MessageBoxButtons.YesNo).ToString()=="Yes")		
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						comd2=new SqlCommand("delete from Foods where rtrim(Food_Id)="+txt_id.Text.Trim(),cn);
						comd2.ExecuteNonQuery();
						MessageBox.Show("Item has been deleted!");				
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					cn.Close();
				}
			}
			if(Regex.IsMatch(txt_buf_id.Text.Trim(),@"[0-9]+$"))
			{

				if(!Regex.IsMatch(txt_buf_id.Text.Trim(),@"[0-9]+$"))
				{
					MessageBox.Show("Please, Enter Item Id in number!");
				}
				else if(MessageBox.Show("        Are you sure?\n			Delete this buffet item!","Addition",MessageBoxButtons.YesNo).ToString()=="Yes")		
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						comd2=new SqlCommand("delete from buffet where rtrim(Buffet_ID)="+txt_buf_id.Text.Trim(),cn);
						comd2.ExecuteNonQuery();
						MessageBox.Show("Item has been deleted!");				
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					cn.Close();
				}
			}
			cleartext();
		}

		private void combo_buf_type_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str3=combo_buf_type.SelectedItem.ToString();
		}

		private void combo_status_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void combo_pay_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//str4=combo_pay.SelectedItem.ToString();
		}

		private void btn_update_Click(object sender, System.EventArgs e)
		{
			update();	
		
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			str4=dateTimePicker1.Text.ToString();
			

		}

		private void btn_print_food_Click(object sender, System.EventArgs e)
		{
			FrmFoodReport frp=new FrmFoodReport();
			frp.Show();
		}

		private void btn_print_buffet_Click(object sender, System.EventArgs e)
		{
			frmBuffetReport brp=new frmBuffetReport();
			brp.Show();
		}
	}
}
