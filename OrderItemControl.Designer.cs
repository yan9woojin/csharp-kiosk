namespace Kiosk
{
    partial class OrderItemControl
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
            this.tlpLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tlpOptionLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCup = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.tlpLabels.SuspendLayout();
            this.tlpOptionLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pbProductImage, 0, 0);
            this.tlpMain.Controls.Add(this.tlpLabels, 1, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(400, 120);
            this.tlpMain.TabIndex = 0;
            // 
            // pbProductImage
            // 
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProductImage.Image = global::Kiosk.Properties.Resources.iced_caffe_americano;
            this.pbProductImage.Location = new System.Drawing.Point(20, 10);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(160, 100);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            // 
            // tlpLabels
            // 
            this.tlpLabels.ColumnCount = 1;
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLabels.Controls.Add(this.lblProductName, 0, 0);
            this.tlpLabels.Controls.Add(this.lblQuantity, 0, 2);
            this.tlpLabels.Controls.Add(this.lblTotalPrice, 0, 3);
            this.tlpLabels.Controls.Add(this.tlpOptionLabels, 0, 1);
            this.tlpLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLabels.Location = new System.Drawing.Point(200, 10);
            this.tlpLabels.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tlpLabels.Name = "tlpLabels";
            this.tlpLabels.RowCount = 4;
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLabels.Size = new System.Drawing.Size(200, 100);
            this.tlpLabels.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductName.Location = new System.Drawing.Point(0, 0);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(200, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "아이스 카페 아메리카노";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblQuantity.ForeColor = System.Drawing.Color.Gray;
            this.lblQuantity.Location = new System.Drawing.Point(0, 50);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(200, 25);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "1개";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(0, 75);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(200, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "4,500원";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpOptionLabels
            // 
            this.tlpOptionLabels.AutoSize = true;
            this.tlpOptionLabels.ColumnCount = 2;
            this.tlpOptionLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOptionLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpOptionLabels.Controls.Add(this.lblSize, 0, 0);
            this.tlpOptionLabels.Controls.Add(this.lblCup, 1, 0);
            this.tlpOptionLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptionLabels.Location = new System.Drawing.Point(0, 25);
            this.tlpOptionLabels.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOptionLabels.Name = "tlpOptionLabels";
            this.tlpOptionLabels.RowCount = 1;
            this.tlpOptionLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionLabels.Size = new System.Drawing.Size(200, 25);
            this.tlpOptionLabels.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblSize.ForeColor = System.Drawing.Color.Gray;
            this.lblSize.Location = new System.Drawing.Point(0, 0);
            this.lblSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 25);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Tall";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCup
            // 
            this.lblCup.AutoSize = true;
            this.lblCup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCup.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblCup.ForeColor = System.Drawing.Color.Gray;
            this.lblCup.Location = new System.Drawing.Point(50, 0);
            this.lblCup.Margin = new System.Windows.Forms.Padding(0);
            this.lblCup.Name = "lblCup";
            this.lblCup.Size = new System.Drawing.Size(150, 25);
            this.lblCup.TabIndex = 1;
            this.lblCup.Text = "일회용컵";
            this.lblCup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(400, 120);
            this.MinimumSize = new System.Drawing.Size(400, 120);
            this.Name = "OrderItemControl";
            this.Size = new System.Drawing.Size(400, 120);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderItem_Paint);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.tlpLabels.ResumeLayout(false);
            this.tlpLabels.PerformLayout();
            this.tlpOptionLabels.ResumeLayout(false);
            this.tlpOptionLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.TableLayoutPanel tlpLabels;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tlpOptionLabels;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCup;
    }
}
