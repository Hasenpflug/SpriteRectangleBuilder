namespace SpriteRectangleBuilder
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
            this.pctSpritesheet = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctZoomImage = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FrameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameXLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameYLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFrameWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFrameHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblZoomSize = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pctPreviewAnimation = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRectX = new System.Windows.Forms.Label();
            this.lblRectY = new System.Windows.Forms.Label();
            this.lblRectWidth = new System.Windows.Forms.Label();
            this.lblRectHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpritesheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctZoomImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreviewAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSpritesheet
            // 
            this.pctSpritesheet.Image = ((System.Drawing.Image)(resources.GetObject("pctSpritesheet.Image")));
            this.pctSpritesheet.Location = new System.Drawing.Point(316, 12);
            this.pctSpritesheet.Name = "pctSpritesheet";
            this.pctSpritesheet.Size = new System.Drawing.Size(513, 512);
            this.pctSpritesheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctSpritesheet.TabIndex = 12;
            this.pctSpritesheet.TabStop = false;
            this.pctSpritesheet.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pctSpritesheet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctSpritesheet_MouseDown);
            this.pctSpritesheet.MouseEnter += new System.EventHandler(this.pctSpritesheet_MouseEnter);
            this.pctSpritesheet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctSpritesheet_MouseMove);
            this.pctSpritesheet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctSpritesheet_MouseUp);
            this.pctSpritesheet.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pctSpritesheet_MouseWheel);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(22, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 39);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pctZoomImage
            // 
            this.pctZoomImage.Location = new System.Drawing.Point(12, 12);
            this.pctZoomImage.Name = "pctZoomImage";
            this.pctZoomImage.Size = new System.Drawing.Size(162, 143);
            this.pctZoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctZoomImage.TabIndex = 24;
            this.pctZoomImage.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(22, 796);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 40);
            this.btnPlay.TabIndex = 25;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(117, 599);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(76, 39);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrameNumber,
            this.FrameXLocation,
            this.FrameYLocation,
            this.GridFrameWidth,
            this.GridFrameHeight});
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 362);
            this.dataGridView1.TabIndex = 27;
            // 
            // FrameNumber
            // 
            this.FrameNumber.HeaderText = "Frame Number";
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.Width = 50;
            // 
            // FrameXLocation
            // 
            this.FrameXLocation.HeaderText = "Frame X Location";
            this.FrameXLocation.Name = "FrameXLocation";
            this.FrameXLocation.Width = 50;
            // 
            // FrameYLocation
            // 
            this.FrameYLocation.HeaderText = "Frame Y Location";
            this.FrameYLocation.Name = "FrameYLocation";
            this.FrameYLocation.Width = 50;
            // 
            // GridFrameWidth
            // 
            this.GridFrameWidth.HeaderText = "Frame Width";
            this.GridFrameWidth.Name = "GridFrameWidth";
            this.GridFrameWidth.Width = 50;
            // 
            // GridFrameHeight
            // 
            this.GridFrameHeight.HeaderText = "Frame Height";
            this.GridFrameHeight.Name = "GridFrameHeight";
            this.GridFrameHeight.Width = 50;
            // 
            // lblZoomSize
            // 
            this.lblZoomSize.AutoSize = true;
            this.lblZoomSize.Location = new System.Drawing.Point(165, 165);
            this.lblZoomSize.Name = "lblZoomSize";
            this.lblZoomSize.Size = new System.Drawing.Size(0, 13);
            this.lblZoomSize.TabIndex = 29;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(216, 796);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pctPreviewAnimation
            // 
            this.pctPreviewAnimation.Location = new System.Drawing.Point(68, 647);
            this.pctPreviewAnimation.Name = "pctPreviewAnimation";
            this.pctPreviewAnimation.Size = new System.Drawing.Size(162, 143);
            this.pctPreviewAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctPreviewAnimation.TabIndex = 31;
            this.pctPreviewAnimation.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(216, 599);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRectX
            // 
            this.lblRectX.AutoSize = true;
            this.lblRectX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectX.Location = new System.Drawing.Point(180, 30);
            this.lblRectX.Name = "lblRectX";
            this.lblRectX.Size = new System.Drawing.Size(62, 20);
            this.lblRectX.TabIndex = 33;
            this.lblRectX.Text = "Rect X:";
            // 
            // lblRectY
            // 
            this.lblRectY.AutoSize = true;
            this.lblRectY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectY.Location = new System.Drawing.Point(178, 61);
            this.lblRectY.Name = "lblRectY";
            this.lblRectY.Size = new System.Drawing.Size(62, 20);
            this.lblRectY.TabIndex = 34;
            this.lblRectY.Text = "Rect Y:";
            // 
            // lblRectWidth
            // 
            this.lblRectWidth.AutoSize = true;
            this.lblRectWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectWidth.Location = new System.Drawing.Point(178, 92);
            this.lblRectWidth.Name = "lblRectWidth";
            this.lblRectWidth.Size = new System.Drawing.Size(74, 20);
            this.lblRectWidth.TabIndex = 35;
            this.lblRectWidth.Text = "R Width: ";
            // 
            // lblRectHeight
            // 
            this.lblRectHeight.AutoSize = true;
            this.lblRectHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectHeight.Location = new System.Drawing.Point(178, 122);
            this.lblRectHeight.Name = "lblRectHeight";
            this.lblRectHeight.Size = new System.Drawing.Size(80, 20);
            this.lblRectHeight.TabIndex = 36;
            this.lblRectHeight.Text = "R Height: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1125, 974);
            this.Controls.Add(this.lblRectHeight);
            this.Controls.Add(this.lblRectWidth);
            this.Controls.Add(this.lblRectY);
            this.Controls.Add(this.lblRectX);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pctPreviewAnimation);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblZoomSize);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pctZoomImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctSpritesheet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSpritesheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctZoomImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreviewAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSpritesheet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pctZoomImage;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameXLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameYLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFrameWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFrameHeight;
        private System.Windows.Forms.Label lblZoomSize;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pctPreviewAnimation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRectX;
        private System.Windows.Forms.Label lblRectY;
        private System.Windows.Forms.Label lblRectWidth;
        private System.Windows.Forms.Label lblRectHeight;
    }
}

