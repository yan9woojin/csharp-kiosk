namespace Kiosk
{
    partial class OrderControl
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
            this.tlp주문내역 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl주문내역 = new System.Windows.Forms.Label();
            this.flpOrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp결제수단 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl결제수단 = new System.Windows.Forms.Label();
            this.tlpPayOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnApplePay = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp총주문금액 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl총주문금액 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlp주문내역.SuspendLayout();
            this.tlp결제수단.SuspendLayout();
            this.tlpPayOption.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlp총주문금액.SuspendLayout();
            this.tlpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoScroll = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlp주문내역, 0, 0);
            this.tlpMain.Controls.Add(this.tlp결제수단, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.Size = new System.Drawing.Size(438, 524);
            this.tlpMain.TabIndex = 0;
            // 
            // tlp주문내역
            // 
            this.tlp주문내역.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlp주문내역.AutoScroll = true;
            this.tlp주문내역.AutoSize = true;
            this.tlp주문내역.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp주문내역.ColumnCount = 1;
            this.tlp주문내역.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp주문내역.Controls.Add(this.lbl주문내역, 0, 0);
            this.tlp주문내역.Controls.Add(this.flpOrderList, 0, 1);
            this.tlp주문내역.Location = new System.Drawing.Point(10, 10);
            this.tlp주문내역.Margin = new System.Windows.Forms.Padding(0);
            this.tlp주문내역.MaximumSize = new System.Drawing.Size(420, 0);
            this.tlp주문내역.MinimumSize = new System.Drawing.Size(420, 0);
            this.tlp주문내역.Name = "tlp주문내역";
            this.tlp주문내역.RowCount = 2;
            this.tlp주문내역.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp주문내역.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp주문내역.Size = new System.Drawing.Size(420, 190);
            this.tlp주문내역.TabIndex = 0;
            // 
            // lbl주문내역
            // 
            this.lbl주문내역.AutoSize = true;
            this.lbl주문내역.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl주문내역.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lbl주문내역.Location = new System.Drawing.Point(0, 0);
            this.lbl주문내역.Margin = new System.Windows.Forms.Padding(0);
            this.lbl주문내역.Name = "lbl주문내역";
            this.lbl주문내역.Size = new System.Drawing.Size(420, 19);
            this.lbl주문내역.TabIndex = 0;
            this.lbl주문내역.Text = "주문내역";
            this.lbl주문내역.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpOrderList
            // 
            this.flpOrderList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpOrderList.AutoScroll = true;
            this.flpOrderList.AutoSize = true;
            this.flpOrderList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOrderList.BackColor = System.Drawing.Color.White;
            this.flpOrderList.Location = new System.Drawing.Point(210, 29);
            this.flpOrderList.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpOrderList.Name = "flpOrderList";
            this.flpOrderList.Size = new System.Drawing.Size(0, 0);
            this.flpOrderList.TabIndex = 1;
            // 
            // tlp결제수단
            // 
            this.tlp결제수단.ColumnCount = 1;
            this.tlp결제수단.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp결제수단.Controls.Add(this.lbl결제수단, 0, 0);
            this.tlp결제수단.Controls.Add(this.tlpPayOption, 0, 1);
            this.tlp결제수단.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp결제수단.Location = new System.Drawing.Point(10, 312);
            this.tlp결제수단.Margin = new System.Windows.Forms.Padding(0);
            this.tlp결제수단.Name = "tlp결제수단";
            this.tlp결제수단.RowCount = 2;
            this.tlp결제수단.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp결제수단.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp결제수단.Size = new System.Drawing.Size(418, 151);
            this.tlp결제수단.TabIndex = 1;
            // 
            // lbl결제수단
            // 
            this.lbl결제수단.AutoSize = true;
            this.lbl결제수단.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl결제수단.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lbl결제수단.Location = new System.Drawing.Point(0, 0);
            this.lbl결제수단.Margin = new System.Windows.Forms.Padding(0);
            this.lbl결제수단.Name = "lbl결제수단";
            this.lbl결제수단.Size = new System.Drawing.Size(418, 30);
            this.lbl결제수단.TabIndex = 0;
            this.lbl결제수단.Text = "결제수단";
            this.lbl결제수단.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tlpPayOption
            // 
            this.tlpPayOption.AutoSize = true;
            this.tlpPayOption.ColumnCount = 3;
            this.tlpPayOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPayOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPayOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPayOption.Controls.Add(this.btnCard, 0, 0);
            this.tlpPayOption.Controls.Add(this.btnPhone, 1, 0);
            this.tlpPayOption.Controls.Add(this.btnApplePay, 2, 0);
            this.tlpPayOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayOption.Location = new System.Drawing.Point(0, 30);
            this.tlpPayOption.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPayOption.Name = "tlpPayOption";
            this.tlpPayOption.RowCount = 1;
            this.tlpPayOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpPayOption.Size = new System.Drawing.Size(418, 121);
            this.tlpPayOption.TabIndex = 1;
            // 
            // btnCard
            // 
            this.btnCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCard.BackColor = System.Drawing.Color.White;
            this.btnCard.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.ForeColor = System.Drawing.Color.Black;
            this.btnCard.Location = new System.Drawing.Point(19, 0);
            this.btnCard.Margin = new System.Windows.Forms.Padding(0);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(120, 120);
            this.btnCard.TabIndex = 0;
            this.btnCard.Text = "신용카드";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnPayOption_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhone.AutoSize = true;
            this.btnPhone.BackColor = System.Drawing.Color.White;
            this.btnPhone.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.ForeColor = System.Drawing.Color.Black;
            this.btnPhone.Location = new System.Drawing.Point(139, 0);
            this.btnPhone.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(139, 120);
            this.btnPhone.TabIndex = 1;
            this.btnPhone.Text = "Samsung Pay";
            this.btnPhone.UseVisualStyleBackColor = false;
            this.btnPhone.Click += new System.EventHandler(this.btnPayOption_Click);
            // 
            // btnApplePay
            // 
            this.btnApplePay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnApplePay.AutoSize = true;
            this.btnApplePay.BackColor = System.Drawing.Color.White;
            this.btnApplePay.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnApplePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplePay.ForeColor = System.Drawing.Color.Black;
            this.btnApplePay.Location = new System.Drawing.Point(278, 0);
            this.btnApplePay.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplePay.Name = "btnApplePay";
            this.btnApplePay.Size = new System.Drawing.Size(140, 120);
            this.btnApplePay.TabIndex = 2;
            this.btnApplePay.Text = "Apple Pay";
            this.btnApplePay.UseVisualStyleBackColor = false;
            this.btnApplePay.Click += new System.EventHandler(this.btnPayOption_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tlp총주문금액, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlpActions, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 463);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 51);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tlp총주문금액
            // 
            this.tlp총주문금액.AutoSize = true;
            this.tlp총주문금액.ColumnCount = 2;
            this.tlp총주문금액.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp총주문금액.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp총주문금액.Controls.Add(this.lbl총주문금액, 0, 0);
            this.tlp총주문금액.Controls.Add(this.lblTotalPrice, 1, 0);
            this.tlp총주문금액.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp총주문금액.Location = new System.Drawing.Point(0, 0);
            this.tlp총주문금액.Margin = new System.Windows.Forms.Padding(0);
            this.tlp총주문금액.Name = "tlp총주문금액";
            this.tlp총주문금액.RowCount = 1;
            this.tlp총주문금액.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp총주문금액.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp총주문금액.Size = new System.Drawing.Size(418, 25);
            this.tlp총주문금액.TabIndex = 0;
            // 
            // lbl총주문금액
            // 
            this.lbl총주문금액.AutoSize = true;
            this.lbl총주문금액.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl총주문금액.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lbl총주문금액.Location = new System.Drawing.Point(0, 0);
            this.lbl총주문금액.Margin = new System.Windows.Forms.Padding(0);
            this.lbl총주문금액.Name = "lbl총주문금액";
            this.lbl총주문금액.Size = new System.Drawing.Size(209, 25);
            this.lbl총주문금액.TabIndex = 0;
            this.lbl총주문금액.Text = "총 주문금액";
            this.lbl총주문금액.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(209, 0);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTotalPrice.Size = new System.Drawing.Size(209, 25);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "4,500원";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpActions
            // 
            this.tlpActions.AutoSize = true;
            this.tlpActions.ColumnCount = 2;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpActions.Controls.Add(this.btnBack, 0, 0);
            this.tlpActions.Controls.Add(this.btnPay, 1, 0);
            this.tlpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActions.Location = new System.Drawing.Point(0, 25);
            this.tlpActions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.Size = new System.Drawing.Size(418, 26);
            this.tlpActions.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 26);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = true;
            this.btnPay.BackColor = System.Drawing.Color.LightGray;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(88, 0);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(330, 26);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "결제하기";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(438, 524);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlp주문내역.ResumeLayout(false);
            this.tlp주문내역.PerformLayout();
            this.tlp결제수단.ResumeLayout(false);
            this.tlp결제수단.PerformLayout();
            this.tlpPayOption.ResumeLayout(false);
            this.tlpPayOption.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tlp총주문금액.ResumeLayout(false);
            this.tlp총주문금액.PerformLayout();
            this.tlpActions.ResumeLayout(false);
            this.tlpActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlp주문내역;
        private System.Windows.Forms.Label lbl주문내역;
        private System.Windows.Forms.TableLayoutPanel tlp결제수단;
        private System.Windows.Forms.Label lbl결제수단;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlp총주문금액;
        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private System.Windows.Forms.Label lbl총주문금액;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TableLayoutPanel tlpPayOption;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnApplePay;
        private System.Windows.Forms.FlowLayoutPanel flpOrderList;
    }
}
