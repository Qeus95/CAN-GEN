namespace CAN_GEN
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lineCTR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_intervalas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblByte1 = new System.Windows.Forms.Label();
            this.lblByte2 = new System.Windows.Forms.Label();
            this.lblByte3 = new System.Windows.Forms.Label();
            this.lblByte4 = new System.Windows.Forms.Label();
            this.lblByte5 = new System.Windows.Forms.Label();
            this.lblByte6 = new System.Windows.Forms.Label();
            this.lblByte7 = new System.Windows.Forms.Label();
            this.lblByte8 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.tB5 = new System.Windows.Forms.TextBox();
            this.tB6 = new System.Windows.Forms.TextBox();
            this.tB7 = new System.Windows.Forms.TextBox();
            this.tB8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCANID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLineCTR = new System.Windows.Forms.TextBox();
            this.listBoxMyBoy = new System.Windows.Forms.ListBox();
            this.parametersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packetsDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.transfer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetsDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lineCTR
            // 
            this.lineCTR.Location = new System.Drawing.Point(221, 106);
            this.lineCTR.MaxLength = 3;
            this.lineCTR.Name = "lineCTR";
            this.lineCTR.Size = new System.Drawing.Size(171, 20);
            this.lineCTR.TabIndex = 0;
            this.lineCTR.Text = "100";
            this.lineCTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lineCTR.WordWrap = false;
            this.lineCTR.TextChanged += new System.EventHandler(this.lineCTR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAN GENERATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_intervalas
            // 
            this.lbl_intervalas.AutoSize = true;
            this.lbl_intervalas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intervalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalas.Location = new System.Drawing.Point(23, 109);
            this.lbl_intervalas.Name = "lbl_intervalas";
            this.lbl_intervalas.Size = new System.Drawing.Size(193, 13);
            this.lbl_intervalas.TabIndex = 2;
            this.lbl_intervalas.Text = "Time interval between lines (ms):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CAN_GEN.Properties.Resources.generate_btn;
            this.button1.Location = new System.Drawing.Point(221, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 100);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // lblByte1
            // 
            this.lblByte1.AutoSize = true;
            this.lblByte1.BackColor = System.Drawing.Color.Transparent;
            this.lblByte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte1.Location = new System.Drawing.Point(107, 172);
            this.lblByte1.Name = "lblByte1";
            this.lblByte1.Size = new System.Drawing.Size(39, 13);
            this.lblByte1.TabIndex = 4;
            this.lblByte1.Text = "Byte1";
            this.lblByte1.Click += new System.EventHandler(this.lblByte1_Click);
            // 
            // lblByte2
            // 
            this.lblByte2.AutoSize = true;
            this.lblByte2.BackColor = System.Drawing.Color.Transparent;
            this.lblByte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte2.Location = new System.Drawing.Point(143, 172);
            this.lblByte2.Name = "lblByte2";
            this.lblByte2.Size = new System.Drawing.Size(39, 13);
            this.lblByte2.TabIndex = 5;
            this.lblByte2.Text = "Byte2";
            // 
            // lblByte3
            // 
            this.lblByte3.AutoSize = true;
            this.lblByte3.BackColor = System.Drawing.Color.Transparent;
            this.lblByte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte3.Location = new System.Drawing.Point(181, 172);
            this.lblByte3.Name = "lblByte3";
            this.lblByte3.Size = new System.Drawing.Size(39, 13);
            this.lblByte3.TabIndex = 6;
            this.lblByte3.Text = "Byte3";
            // 
            // lblByte4
            // 
            this.lblByte4.AutoSize = true;
            this.lblByte4.BackColor = System.Drawing.Color.Transparent;
            this.lblByte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte4.Location = new System.Drawing.Point(218, 172);
            this.lblByte4.Name = "lblByte4";
            this.lblByte4.Size = new System.Drawing.Size(39, 13);
            this.lblByte4.TabIndex = 7;
            this.lblByte4.Text = "Byte4";
            // 
            // lblByte5
            // 
            this.lblByte5.AutoSize = true;
            this.lblByte5.BackColor = System.Drawing.Color.Transparent;
            this.lblByte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte5.Location = new System.Drawing.Point(253, 172);
            this.lblByte5.Name = "lblByte5";
            this.lblByte5.Size = new System.Drawing.Size(39, 13);
            this.lblByte5.TabIndex = 8;
            this.lblByte5.Text = "Byte5";
            // 
            // lblByte6
            // 
            this.lblByte6.AutoSize = true;
            this.lblByte6.BackColor = System.Drawing.Color.Transparent;
            this.lblByte6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte6.Location = new System.Drawing.Point(288, 172);
            this.lblByte6.Name = "lblByte6";
            this.lblByte6.Size = new System.Drawing.Size(39, 13);
            this.lblByte6.TabIndex = 9;
            this.lblByte6.Text = "Byte6";
            // 
            // lblByte7
            // 
            this.lblByte7.AutoSize = true;
            this.lblByte7.BackColor = System.Drawing.Color.Transparent;
            this.lblByte7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte7.Location = new System.Drawing.Point(323, 172);
            this.lblByte7.Name = "lblByte7";
            this.lblByte7.Size = new System.Drawing.Size(39, 13);
            this.lblByte7.TabIndex = 10;
            this.lblByte7.Text = "Byte7";
            // 
            // lblByte8
            // 
            this.lblByte8.AutoSize = true;
            this.lblByte8.BackColor = System.Drawing.Color.Transparent;
            this.lblByte8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByte8.Location = new System.Drawing.Point(358, 172);
            this.lblByte8.Name = "lblByte8";
            this.lblByte8.Size = new System.Drawing.Size(39, 13);
            this.lblByte8.TabIndex = 11;
            this.lblByte8.Text = "Byte8";
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(110, 188);
            this.tB1.MaxLength = 2;
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(31, 20);
            this.tB1.TabIndex = 12;
            this.tB1.Text = "FF";
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(147, 188);
            this.tB2.MaxLength = 2;
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(31, 20);
            this.tB2.TabIndex = 13;
            this.tB2.Text = "FF";
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB3
            // 
            this.tB3.Location = new System.Drawing.Point(184, 188);
            this.tB3.MaxLength = 2;
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(31, 20);
            this.tB3.TabIndex = 14;
            this.tB3.Text = "FF";
            this.tB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB4
            // 
            this.tB4.Location = new System.Drawing.Point(221, 188);
            this.tB4.MaxLength = 2;
            this.tB4.Name = "tB4";
            this.tB4.Size = new System.Drawing.Size(29, 20);
            this.tB4.TabIndex = 15;
            this.tB4.Text = "FF";
            this.tB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB5
            // 
            this.tB5.Location = new System.Drawing.Point(256, 188);
            this.tB5.MaxLength = 2;
            this.tB5.Name = "tB5";
            this.tB5.Size = new System.Drawing.Size(29, 20);
            this.tB5.TabIndex = 16;
            this.tB5.Text = "FF";
            this.tB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB6
            // 
            this.tB6.Location = new System.Drawing.Point(291, 188);
            this.tB6.MaxLength = 2;
            this.tB6.Name = "tB6";
            this.tB6.Size = new System.Drawing.Size(29, 20);
            this.tB6.TabIndex = 17;
            this.tB6.Text = "FF";
            this.tB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB7
            // 
            this.tB7.Location = new System.Drawing.Point(326, 188);
            this.tB7.MaxLength = 2;
            this.tB7.Name = "tB7";
            this.tB7.Size = new System.Drawing.Size(29, 20);
            this.tB7.TabIndex = 18;
            this.tB7.Text = "FF";
            this.tB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB8
            // 
            this.tB8.Location = new System.Drawing.Point(361, 188);
            this.tB8.MaxLength = 2;
            this.tB8.Name = "tB8";
            this.tB8.Size = new System.Drawing.Size(29, 20);
            this.tB8.TabIndex = 19;
            this.tB8.Text = "FF";
            this.tB8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CAN ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCANID
            // 
            this.tbCANID.Location = new System.Drawing.Point(19, 188);
            this.tbCANID.MaxLength = 8;
            this.tbCANID.Name = "tbCANID";
            this.tbCANID.Size = new System.Drawing.Size(71, 20);
            this.tbCANID.TabIndex = 21;
            this.tbCANID.Text = "1FFFFFFF";
            this.tbCANID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Line count:";
            // 
            // tbLineCTR
            // 
            this.tbLineCTR.Location = new System.Drawing.Point(221, 132);
            this.tbLineCTR.Name = "tbLineCTR";
            this.tbLineCTR.Size = new System.Drawing.Size(171, 20);
            this.tbLineCTR.TabIndex = 23;
            this.tbLineCTR.Text = "1";
            this.tbLineCTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBoxMyBoy
            // 
            this.listBoxMyBoy.BackColor = System.Drawing.Color.White;
            this.listBoxMyBoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMyBoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxMyBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMyBoy.FormattingEnabled = true;
            this.listBoxMyBoy.Location = new System.Drawing.Point(19, 230);
            this.listBoxMyBoy.Name = "listBoxMyBoy";
            this.listBoxMyBoy.Size = new System.Drawing.Size(373, 236);
            this.listBoxMyBoy.TabIndex = 26;
            this.listBoxMyBoy.SelectedIndexChanged += new System.EventHandler(this.listBoxMyBoy_SelectedIndexChanged);
            // 
            // parametersBindingSource1
            // 
            this.parametersBindingSource1.DataMember = "parameters";
            // 
            // parametersBindingSource
            // 
            this.parametersBindingSource.DataMember = "parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(987, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Packets";
            // 
            // transfer
            // 
            this.transfer.Location = new System.Drawing.Point(389, 230);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(41, 236);
            this.transfer.TabIndex = 29;
            this.transfer.Text = "→";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(852, 218);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(349, 248);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 660);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxMyBoy);
            this.Controls.Add(this.tbLineCTR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCANID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB8);
            this.Controls.Add(this.tB7);
            this.Controls.Add(this.tB6);
            this.Controls.Add(this.tB5);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.lblByte8);
            this.Controls.Add(this.lblByte7);
            this.Controls.Add(this.lblByte6);
            this.Controls.Add(this.lblByte5);
            this.Controls.Add(this.lblByte4);
            this.Controls.Add(this.lblByte3);
            this.Controls.Add(this.lblByte2);
            this.Controls.Add(this.lblByte1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_intervalas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineCTR);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1251, 699);
            this.MinimumSize = new System.Drawing.Size(1251, 699);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAN GENERATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetsDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_intervalas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lineCTR;
        private System.Windows.Forms.Label lblByte1;
        private System.Windows.Forms.Label lblByte2;
        private System.Windows.Forms.Label lblByte3;
        private System.Windows.Forms.Label lblByte4;
        private System.Windows.Forms.Label lblByte5;
        private System.Windows.Forms.Label lblByte6;
        private System.Windows.Forms.Label lblByte7;
        private System.Windows.Forms.Label lblByte8;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.TextBox tB4;
        private System.Windows.Forms.TextBox tB5;
        private System.Windows.Forms.TextBox tB6;
        private System.Windows.Forms.TextBox tB7;
        private System.Windows.Forms.TextBox tB8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCANID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLineCTR;
        private System.Windows.Forms.ListBox listBoxMyBoy;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        //private Database1DataSet database1DataSet;
       
        private System.Windows.Forms.BindingSource parametersBindingSource;
        private System.Windows.Forms.BindingSource packetsDatasetBindingSource;
       // private packetsDataset packetsDataset;
        private System.Windows.Forms.BindingSource parametersBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.DataGridView dataGridView1;
        // private packetsDatasetTableAdapters.parametersTableAdapter parametersTableAdapter;
        // private Database1DataSet1TableAdapters.parametersTableAdapter parametersTableAdapter;
    }
}

