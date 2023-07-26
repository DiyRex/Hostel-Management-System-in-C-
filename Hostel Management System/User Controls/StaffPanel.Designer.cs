namespace Hostel_Management_System.User_Controls
{
    partial class StaffPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.bunifuLabel22 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuLabel23 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnProfileService = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuLabel24 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDeleteService = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuLabel25 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnUpdateService = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuLabel26 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddService = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel22
            // 
            this.bunifuLabel22.AllowParentOverrides = false;
            this.bunifuLabel22.AutoEllipsis = false;
            this.bunifuLabel22.CursorType = null;
            this.bunifuLabel22.Font = new System.Drawing.Font("Azonix", 24F);
            this.bunifuLabel22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuLabel22.Location = new System.Drawing.Point(321, 29);
            this.bunifuLabel22.Name = "bunifuLabel22";
            this.bunifuLabel22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel22.Size = new System.Drawing.Size(125, 32);
            this.bunifuLabel22.TabIndex = 50;
            this.bunifuLabel22.Text = "Staff";
            this.bunifuLabel22.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel22.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Grid
            // 
            this.Grid.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeight = 40;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.role,
            this.fname,
            this.lname,
            this.nic,
            this.address,
            this.contact});
            this.Grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.Grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Grid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.Grid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Grid.CurrentTheme.Name = null;
            this.Grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Grid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Grid.HeaderBgColor = System.Drawing.Color.Empty;
            this.Grid.HeaderForeColor = System.Drawing.Color.White;
            this.Grid.Location = new System.Drawing.Point(3, 113);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowTemplate.Height = 40;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(814, 387);
            this.Grid.TabIndex = 41;
            this.Grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 35.533F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // role
            // 
            this.role.FillWeight = 110.7445F;
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // fname
            // 
            this.fname.FillWeight = 110.7445F;
            this.fname.HeaderText = "FirstName";
            this.fname.Name = "fname";
            // 
            // lname
            // 
            this.lname.FillWeight = 110.7445F;
            this.lname.HeaderText = "LastName";
            this.lname.Name = "lname";
            // 
            // nic
            // 
            this.nic.FillWeight = 110.7445F;
            this.nic.HeaderText = "NIC";
            this.nic.Name = "nic";
            // 
            // address
            // 
            this.address.FillWeight = 110.7445F;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // contact
            // 
            this.contact.FillWeight = 110.7445F;
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            // 
            // bunifuLabel23
            // 
            this.bunifuLabel23.AllowParentOverrides = false;
            this.bunifuLabel23.AutoEllipsis = false;
            this.bunifuLabel23.CursorType = null;
            this.bunifuLabel23.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel23.Location = new System.Drawing.Point(591, 75);
            this.bunifuLabel23.Name = "bunifuLabel23";
            this.bunifuLabel23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel23.Size = new System.Drawing.Size(38, 17);
            this.bunifuLabel23.TabIndex = 49;
            this.bunifuLabel23.Text = "Profile";
            this.bunifuLabel23.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel23.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel23.Visible = false;
            // 
            // btnProfileService
            // 
            this.btnProfileService.AllowAnimations = true;
            this.btnProfileService.AllowBorderColorChanges = true;
            this.btnProfileService.AllowMouseEffects = true;
            this.btnProfileService.AnimationSpeed = 200;
            this.btnProfileService.BackColor = System.Drawing.Color.Transparent;
            this.btnProfileService.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnProfileService.BorderColor = System.Drawing.Color.Transparent;
            this.btnProfileService.BorderRadius = 3;
            this.btnProfileService.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnProfileService.BorderThickness = 2;
            this.btnProfileService.ColorContrastOnClick = 30;
            this.btnProfileService.ColorContrastOnHover = 30;
            this.btnProfileService.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnProfileService.CustomizableEdges = borderEdges1;
            this.btnProfileService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfileService.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileService.Image")));
            this.btnProfileService.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnProfileService.Location = new System.Drawing.Point(584, 23);
            this.btnProfileService.Name = "btnProfileService";
            this.btnProfileService.RoundBorders = false;
            this.btnProfileService.ShowBorders = true;
            this.btnProfileService.Size = new System.Drawing.Size(53, 53);
            this.btnProfileService.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnProfileService.TabIndex = 48;
            this.btnProfileService.Visible = false;
            // 
            // bunifuLabel24
            // 
            this.bunifuLabel24.AllowParentOverrides = false;
            this.bunifuLabel24.AutoEllipsis = false;
            this.bunifuLabel24.CursorType = null;
            this.bunifuLabel24.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel24.Location = new System.Drawing.Point(712, 74);
            this.bunifuLabel24.Name = "bunifuLabel24";
            this.bunifuLabel24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel24.Size = new System.Drawing.Size(38, 17);
            this.bunifuLabel24.TabIndex = 47;
            this.bunifuLabel24.Text = "Delete";
            this.bunifuLabel24.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel24.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.AllowAnimations = true;
            this.btnDeleteService.AllowBorderColorChanges = true;
            this.btnDeleteService.AllowMouseEffects = true;
            this.btnDeleteService.AnimationSpeed = 200;
            this.btnDeleteService.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteService.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDeleteService.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteService.BorderRadius = 3;
            this.btnDeleteService.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnDeleteService.BorderThickness = 2;
            this.btnDeleteService.ColorContrastOnClick = 30;
            this.btnDeleteService.ColorContrastOnHover = 30;
            this.btnDeleteService.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDeleteService.CustomizableEdges = borderEdges2;
            this.btnDeleteService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteService.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.Image")));
            this.btnDeleteService.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnDeleteService.Location = new System.Drawing.Point(705, 23);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.RoundBorders = false;
            this.btnDeleteService.ShowBorders = true;
            this.btnDeleteService.Size = new System.Drawing.Size(53, 53);
            this.btnDeleteService.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnDeleteService.TabIndex = 46;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // bunifuLabel25
            // 
            this.bunifuLabel25.AllowParentOverrides = false;
            this.bunifuLabel25.AutoEllipsis = false;
            this.bunifuLabel25.CursorType = null;
            this.bunifuLabel25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel25.Location = new System.Drawing.Point(649, 75);
            this.bunifuLabel25.Name = "bunifuLabel25";
            this.bunifuLabel25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel25.Size = new System.Drawing.Size(44, 17);
            this.bunifuLabel25.TabIndex = 45;
            this.bunifuLabel25.Text = "Update";
            this.bunifuLabel25.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel25.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.AllowAnimations = true;
            this.btnUpdateService.AllowBorderColorChanges = true;
            this.btnUpdateService.AllowMouseEffects = true;
            this.btnUpdateService.AnimationSpeed = 200;
            this.btnUpdateService.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateService.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdateService.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateService.BorderRadius = 3;
            this.btnUpdateService.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnUpdateService.BorderThickness = 2;
            this.btnUpdateService.ColorContrastOnClick = 30;
            this.btnUpdateService.ColorContrastOnHover = 30;
            this.btnUpdateService.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnUpdateService.CustomizableEdges = borderEdges3;
            this.btnUpdateService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateService.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateService.Image")));
            this.btnUpdateService.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnUpdateService.Location = new System.Drawing.Point(643, 23);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.RoundBorders = false;
            this.btnUpdateService.ShowBorders = true;
            this.btnUpdateService.Size = new System.Drawing.Size(53, 53);
            this.btnUpdateService.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnUpdateService.TabIndex = 44;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // bunifuLabel26
            // 
            this.bunifuLabel26.AllowParentOverrides = false;
            this.bunifuLabel26.AutoEllipsis = false;
            this.bunifuLabel26.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel26.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel26.Location = new System.Drawing.Point(93, 78);
            this.bunifuLabel26.Name = "bunifuLabel26";
            this.bunifuLabel26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel26.Size = new System.Drawing.Size(25, 17);
            this.bunifuLabel26.TabIndex = 43;
            this.bunifuLabel26.Text = "Add";
            this.bunifuLabel26.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel26.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddService
            // 
            this.btnAddService.AllowAnimations = true;
            this.btnAddService.AllowBorderColorChanges = true;
            this.btnAddService.AllowMouseEffects = true;
            this.btnAddService.AnimationSpeed = 200;
            this.btnAddService.BackColor = System.Drawing.Color.Transparent;
            this.btnAddService.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddService.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddService.BorderRadius = 3;
            this.btnAddService.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnAddService.BorderThickness = 0;
            this.btnAddService.ColorContrastOnClick = 30;
            this.btnAddService.ColorContrastOnHover = 30;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnAddService.CustomizableEdges = borderEdges4;
            this.btnAddService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.Image")));
            this.btnAddService.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnAddService.Location = new System.Drawing.Point(84, 29);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.RoundBorders = false;
            this.btnAddService.ShowBorders = true;
            this.btnAddService.Size = new System.Drawing.Size(53, 53);
            this.btnAddService.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnAddService.TabIndex = 42;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // StaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuLabel22);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.bunifuLabel23);
            this.Controls.Add(this.btnProfileService);
            this.Controls.Add(this.bunifuLabel24);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.bunifuLabel25);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.bunifuLabel26);
            this.Controls.Add(this.btnAddService);
            this.Name = "StaffPanel";
            this.Size = new System.Drawing.Size(820, 500);
            this.Load += new System.EventHandler(this.StaffPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel22;
        private Bunifu.UI.WinForms.BunifuDataGridView Grid;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel23;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnProfileService;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel24;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnDeleteService;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel25;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnUpdateService;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel26;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnAddService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
    }
}
