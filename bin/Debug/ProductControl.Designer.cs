namespace Kiosk
{
    partial class ProductControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pbProductImage, 0, 0);
            this.tlpMain.Controls.Add(this.lblProductName, 0, 1);
            this.tlpMain.Controls.Add(this.lblProductPrice, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(5, 5);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.MaximumSize = new System.Drawing.Size(170, 170);
            this.tlpMain.MinimumSize = new System.Drawing.Size(170, 170);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(170, 170);
            this.tlpMain.TabIndex = 0;
            this.tlpMain.Click += new System.EventHandler(this.ProductControl_Click);
            this.tlpMain.MouseEnter += new System.EventHandler(this.ProductControl_MouseEnter);
            this.tlpMain.MouseLeave += new System.EventHandler(this.ProductItem_MouseLeave);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProductImage.Image = global::Kiosk.Properties.Resources.iced_caffe_americano;
            this.pbProductImage.Location = new System.Drawing.Point(5, 5);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(160, 120);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.ProductControl_Click);
            this.pbProductImage.MouseEnter += new System.EventHandler(this.ProductControl_MouseEnter);
            this.pbProductImage.MouseLeave += new System.EventHandler(this.ProductItem_MouseLeave);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Location = new System.Drawing.Point(0, 130);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(170, 20);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "아이스 카페 아메리카노";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductName.Click += new System.EventHandler(this.ProductControl_Click);
            this.lblProductName.MouseEnter += new System.EventHandler(this.ProductControl_MouseEnter);
            this.lblProductName.MouseLeave += new System.EventHandler(this.ProductItem_MouseLeave);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductPrice.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.lblProductPrice.Location = new System.Drawing.Point(0, 150);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(170, 20);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "4,500원";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductPrice.Click += new System.EventHandler(this.ProductControl_Click);
            this.lblProductPrice.MouseEnter += new System.EventHandler(this.ProductControl_MouseEnter);
            this.lblProductPrice.MouseLeave += new System.EventHandler(this.ProductItem_MouseLeave);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(180, 180);
            this.MinimumSize = new System.Drawing.Size(180, 180);
            this.Name = "ProductControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(180, 180);
            this.Click += new System.EventHandler(this.ProductControl_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductControl_Paint);
            this.MouseLeave += new System.EventHandler(this.ProductItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ProductControl_MouseEnter);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
    }
}
