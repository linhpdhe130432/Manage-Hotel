namespace ManageHotel
{
    partial class ListBooking
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
            this.BookingView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingView
            // 
            this.BookingView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BookingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingView.Location = new System.Drawing.Point(256, 90);
            this.BookingView.Name = "BookingView";
            this.BookingView.RowHeadersWidth = 72;
            this.BookingView.RowTemplate.Height = 31;
            this.BookingView.Size = new System.Drawing.Size(930, 615);
            this.BookingView.TabIndex = 0;
            this.BookingView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking Records";
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(532, 725);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(381, 90);
            this.btnDeleteBooking.TabIndex = 2;
            this.btnDeleteBooking.Text = "Cancel booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // ListBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1437, 859);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookingView);
            this.Name = "ListBooking";
            this.Text = "ListBooking";
            this.Load += new System.EventHandler(this.ListBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookingView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBooking;
    }
}