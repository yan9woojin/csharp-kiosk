using System.Windows.Forms;

namespace Kiosk
{
    partial class CartItemControl
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
            this.layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpQuantity = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.layout2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCup = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.layout1.SuspendLayout();
            this.tlpQuantity.SuspendLayout();
            this.layout2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout1
            // 
            this.layout1.AutoSize = true;
            this.layout1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout1.BackColor = System.Drawing.Color.Transparent;
            this.layout1.ColumnCount = 1;
            this.layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout1.Controls.Add(this.tlpQuantity, 0, 1);
            this.layout1.Controls.Add(this.layout2, 0, 0);
            this.layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout1.Location = new System.Drawing.Point(5, 10);
            this.layout1.Margin = new System.Windows.Forms.Padding(0);
            this.layout1.MaximumSize = new System.Drawing.Size(170, 0);
            this.layout1.MinimumSize = new System.Drawing.Size(170, 0);
            this.layout1.Name = "layout1";
            this.layout1.RowCount = 2;
            this.layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.layout1.Size = new System.Drawing.Size(170, 85);
            this.layout1.TabIndex = 0;
            // 
            // tlpQuantity
            // 
            this.tlpQuantity.AutoSize = true;
            this.tlpQuantity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpQuantity.ColumnCount = 3;
            this.tlpQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpQuantity.Controls.Add(this.btnDecrease, 0, 0);
            this.tlpQuantity.Controls.Add(this.lblQuantity, 1, 0);
            this.tlpQuantity.Controls.Add(this.btnIncrease, 2, 0);
            this.tlpQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuantity.Location = new System.Drawing.Point(0, 46);
            this.tlpQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.tlpQuantity.Name = "tlpQuantity";
            this.tlpQuantity.RowCount = 1;
            this.tlpQuantity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuantity.Size = new System.Drawing.Size(170, 39);
            this.tlpQuantity.TabIndex = 1;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrease.AutoSize = true;
            this.btnDecrease.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDecrease.ForeColor = System.Drawing.Color.White;
            this.btnDecrease.Location = new System.Drawing.Point(43, 10);
            this.btnDecrease.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnDecrease.MaximumSize = new System.Drawing.Size(25, 25);
            this.btnDecrease.MinimumSize = new System.Drawing.Size(25, 25);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(25, 25);
            this.btnDecrease.TabIndex = 0;
            this.btnDecrease.Text = "−";
            this.btnDecrease.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(76, 0);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblQuantity.Size = new System.Drawing.Size(18, 39);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncrease
            // 
            this.btnIncrease.AutoSize = true;
            this.btnIncrease.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.Location = new System.Drawing.Point(102, 10);
            this.btnIncrease.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnIncrease.MaximumSize = new System.Drawing.Size(25, 25);
            this.btnIncrease.MinimumSize = new System.Drawing.Size(25, 25);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(25, 25);
            this.btnIncrease.TabIndex = 1;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.Button_Click);
            // 
            // layout2
            // 
            this.layout2.AutoSize = true;
            this.layout2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout2.ColumnCount = 2;
            this.layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout2.Controls.Add(this.lblProductPrice, 0, 2);
            this.layout2.Controls.Add(this.lblProductName, 0, 0);
            this.layout2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.layout2.Controls.Add(this.btnRemove, 1, 0);
            this.layout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout2.Location = new System.Drawing.Point(0, 0);
            this.layout2.Margin = new System.Windows.Forms.Padding(0);
            this.layout2.Name = "layout2";
            this.layout2.RowCount = 3;
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout2.Size = new System.Drawing.Size(170, 46);
            this.layout2.TabIndex = 0;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductPrice.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.lblProductPrice.Location = new System.Drawing.Point(0, 30);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(150, 16);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "4,500원";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Location = new System.Drawing.Point(0, 0);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(150, 15);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "아이스 카페 아메리카노";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblSize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 15);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSize.Location = new System.Drawing.Point(0, 0);
            this.lblSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(45, 15);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Grande";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCup
            // 
            this.lblCup.AutoSize = true;
            this.lblCup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCup.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCup.Location = new System.Drawing.Point(45, 0);
            this.lblCup.Margin = new System.Windows.Forms.Padding(0);
            this.lblCup.Name = "lblCup";
            this.lblCup.Size = new System.Drawing.Size(105, 15);
            this.lblCup.TabIndex = 4;
            this.lblCup.Text = "매장용";
            this.lblCup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.Location = new System.Drawing.Point(150, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.layout2.SetRowSpan(this.btnRemove, 3);
            this.btnRemove.Size = new System.Drawing.Size(20, 25);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "×";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.Button_Click);
            // 
            // CartItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layout1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(180, 100);
            this.MinimumSize = new System.Drawing.Size(180, 100);
            this.Name = "CartItemControl";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.Size = new System.Drawing.Size(180, 100);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CartItem_Paint);
            this.layout1.ResumeLayout(false);
            this.layout1.PerformLayout();
            this.tlpQuantity.ResumeLayout(false);
            this.tlpQuantity.PerformLayout();
            this.layout2.ResumeLayout(false);
            this.layout2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout1;
        private System.Windows.Forms.TableLayoutPanel layout2;
        private System.Windows.Forms.TableLayoutPanel tlpQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label lblQuantity;
        private Button btnRemove;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSize;
        private Label lblProductPrice;
        private Label lblCup;
    }
}
