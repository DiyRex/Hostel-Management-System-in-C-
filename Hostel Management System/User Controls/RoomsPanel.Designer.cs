namespace Hostel_Management_System.User_Controls
{
    partial class RoomsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel18 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel19 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel20 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel21 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDeleteRoom = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnUpdateRoom = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnAddRoom = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.Grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bed_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel18
            // 
            this.bunifuLabel18.AllowParentOverrides = false;
            this.bunifuLabel18.AutoEllipsis = false;
            this.bunifuLabel18.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel18.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel18.Font = new System.Drawing.Font("Azonix", 24F);
            this.bunifuLabel18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuLabel18.Location = new System.Drawing.Point(336, 32);
            this.bunifuLabel18.Name = "bunifuLabel18";
            this.bunifuLabel18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel18.Size = new System.Drawing.Size(121, 32);
            this.bunifuLabel18.TabIndex = 35;
            this.bunifuLabel18.Text = "Rooms";
            this.bunifuLabel18.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel18.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel19
            // 
            this.bunifuLabel19.AllowParentOverrides = false;
            this.bunifuLabel19.AutoEllipsis = false;
            this.bunifuLabel19.CursorType = null;
            this.bunifuLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel19.Location = new System.Drawing.Point(708, 70);
            this.bunifuLabel19.Name = "bunifuLabel19";
            this.bunifuLabel19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel19.Size = new System.Drawing.Size(44, 20);
            this.bunifuLabel19.TabIndex = 34;
            this.bunifuLabel19.Text = "Delete";
            this.bunifuLabel19.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel19.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel20
            // 
            this.bunifuLabel20.AllowParentOverrides = false;
            this.bunifuLabel20.AutoEllipsis = false;
            this.bunifuLabel20.CursorType = null;
            this.bunifuLabel20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel20.Location = new System.Drawing.Point(630, 70);
            this.bunifuLabel20.Name = "bunifuLabel20";
            this.bunifuLabel20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel20.Size = new System.Drawing.Size(50, 20);
            this.bunifuLabel20.TabIndex = 33;
            this.bunifuLabel20.Text = "Update";
            this.bunifuLabel20.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel20.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel21
            // 
            this.bunifuLabel21.AllowParentOverrides = false;
            this.bunifuLabel21.AutoEllipsis = false;
            this.bunifuLabel21.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel21.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel21.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel21.Location = new System.Drawing.Point(67, 70);
            this.bunifuLabel21.Name = "bunifuLabel21";
            this.bunifuLabel21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel21.Size = new System.Drawing.Size(28, 20);
            this.bunifuLabel21.TabIndex = 32;
            this.bunifuLabel21.Text = "Add";
            this.bunifuLabel21.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel21.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.AllowAnimations = true;
            this.btnDeleteRoom.AllowBorderColorChanges = true;
            this.btnDeleteRoom.AllowMouseEffects = true;
            this.btnDeleteRoom.AnimationSpeed = 200;
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.BorderRadius = 1;
            this.btnDeleteRoom.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnDeleteRoom.BorderThickness = 1;
            this.btnDeleteRoom.ColorContrastOnClick = 30;
            this.btnDeleteRoom.ColorContrastOnHover = 30;
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDeleteRoom.CustomizableEdges = borderEdges1;
            this.btnDeleteRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.Image")));
            this.btnDeleteRoom.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnDeleteRoom.Location = new System.Drawing.Point(699, 17);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.RoundBorders = true;
            this.btnDeleteRoom.ShowBorders = true;
            this.btnDeleteRoom.Size = new System.Drawing.Size(53, 53);
            this.btnDeleteRoom.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnDeleteRoom.TabIndex = 31;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.AllowAnimations = true;
            this.btnUpdateRoom.AllowBorderColorChanges = true;
            this.btnUpdateRoom.AllowMouseEffects = true;
            this.btnUpdateRoom.AnimationSpeed = 200;
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.BorderRadius = 1;
            this.btnUpdateRoom.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnUpdateRoom.BorderThickness = 1;
            this.btnUpdateRoom.ColorContrastOnClick = 30;
            this.btnUpdateRoom.ColorContrastOnHover = 30;
            this.btnUpdateRoom.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnUpdateRoom.CustomizableEdges = borderEdges2;
            this.btnUpdateRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRoom.Image")));
            this.btnUpdateRoom.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnUpdateRoom.Location = new System.Drawing.Point(627, 17);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.RoundBorders = true;
            this.btnUpdateRoom.ShowBorders = true;
            this.btnUpdateRoom.Size = new System.Drawing.Size(53, 53);
            this.btnUpdateRoom.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnUpdateRoom.TabIndex = 30;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AllowAnimations = true;
            this.btnAddRoom.AllowBorderColorChanges = true;
            this.btnAddRoom.AllowMouseEffects = true;
            this.btnAddRoom.AnimationSpeed = 200;
            this.btnAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.BorderRadius = 1;
            this.btnAddRoom.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.ColorContrastOnClick = 30;
            this.btnAddRoom.ColorContrastOnHover = 30;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddRoom.CustomizableEdges = borderEdges3;
            this.btnAddRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnAddRoom.Location = new System.Drawing.Point(58, 17);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.RoundBorders = false;
            this.btnAddRoom.ShowBorders = true;
            this.btnAddRoom.Size = new System.Drawing.Size(50, 50);
            this.btnAddRoom.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnAddRoom.TabIndex = 29;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // Grid
            // 
            this.Grid.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
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
            this.room_id,
            this.condition,
            this.bed_count,
            this.occupied});
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
            this.Grid.Location = new System.Drawing.Point(2, 109);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowTemplate.Height = 40;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(817, 391);
            this.Grid.TabIndex = 28;
            this.Grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // room_id
            // 
            this.room_id.FillWeight = 120F;
            this.room_id.HeaderText = "Room ID";
            this.room_id.Name = "room_id";
            // 
            // condition
            // 
            this.condition.FillWeight = 120F;
            this.condition.HeaderText = "Condition";
            this.condition.Name = "condition";
            // 
            // bed_count
            // 
            this.bed_count.FillWeight = 120F;
            this.bed_count.HeaderText = "Bed Count";
            this.bed_count.Name = "bed_count";
            // 
            // occupied
            // 
            this.occupied.FillWeight = 120F;
            this.occupied.HeaderText = "Status";
            this.occupied.Name = "occupied";
            // 
            // RoomsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuLabel18);
            this.Controls.Add(this.bunifuLabel19);
            this.Controls.Add(this.bunifuLabel20);
            this.Controls.Add(this.bunifuLabel21);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.Grid);
            this.Name = "RoomsPanel";
            this.Size = new System.Drawing.Size(820, 500);
            this.Load += new System.EventHandler(this.RoomsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel18;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel19;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel20;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel21;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnDeleteRoom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnUpdateRoom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnAddRoom;
        private Bunifu.UI.WinForms.BunifuDataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn bed_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupied;
    }
}
