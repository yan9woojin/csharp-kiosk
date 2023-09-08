namespace Kiosk
{
    partial class OptionControl
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
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnVenti = new System.Windows.Forms.Button();
            this.btnGrande = new System.Windows.Forms.Button();
            this.사이즈 = new System.Windows.Forms.Label();
            this.컵 = new System.Windows.Forms.Label();
            this.btnGlass = new System.Windows.Forms.Button();
            this.btnTumbler = new System.Windows.Forms.Button();
            this.btnPlastic = new System.Windows.Forms.Button();
            this.btnTall = new System.Windows.Forms.Button();
            this.수량 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tlpAction = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl총주문금액 = new System.Windows.Forms.Label();
            this.lblAmountPrice = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpOption.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.tlpAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoScroll = true;
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpOption, 0, 1);
            this.tlpMain.Controls.Add(this.tlpProduct, 0, 0);
            this.tlpMain.Controls.Add(this.tlpAction, 0, 3);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(555, 779);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpOption
            // 
            this.tlpOption.AutoScroll = true;
            this.tlpOption.AutoSize = true;
            this.tlpOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOption.ColumnCount = 3;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpOption.Controls.Add(this.btnVenti, 2, 1);
            this.tlpOption.Controls.Add(this.btnGrande, 1, 1);
            this.tlpOption.Controls.Add(this.사이즈, 0, 0);
            this.tlpOption.Controls.Add(this.컵, 0, 2);
            this.tlpOption.Controls.Add(this.btnGlass, 0, 3);
            this.tlpOption.Controls.Add(this.btnTumbler, 2, 3);
            this.tlpOption.Controls.Add(this.btnPlastic, 1, 3);
            this.tlpOption.Controls.Add(this.btnTall, 0, 1);
            this.tlpOption.Controls.Add(this.수량, 0, 4);
            this.tlpOption.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(0, 279);
            this.tlpOption.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 6;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOption.Size = new System.Drawing.Size(555, 400);
            this.tlpOption.TabIndex = 3;
            // 
            // btnVenti
            // 
            this.btnVenti.AutoSize = true;
            this.btnVenti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenti.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnVenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenti.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnVenti.Location = new System.Drawing.Point(333, 40);
            this.btnVenti.Margin = new System.Windows.Forms.Padding(0);
            this.btnVenti.MaximumSize = new System.Drawing.Size(80, 80);
            this.btnVenti.MinimumSize = new System.Drawing.Size(80, 80);
            this.btnVenti.Name = "btnVenti";
            this.btnVenti.Padding = new System.Windows.Forms.Padding(5);
            this.btnVenti.Size = new System.Drawing.Size(80, 80);
            this.btnVenti.TabIndex = 13;
            this.btnVenti.Text = "Venti\r\n\r\n+1000원";
            this.btnVenti.UseVisualStyleBackColor = true;
            this.btnVenti.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnGrande
            // 
            this.btnGrande.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGrande.AutoSize = true;
            this.btnGrande.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrande.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnGrande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrande.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnGrande.Location = new System.Drawing.Point(237, 40);
            this.btnGrande.Margin = new System.Windows.Forms.Padding(0);
            this.btnGrande.MaximumSize = new System.Drawing.Size(80, 80);
            this.btnGrande.MinimumSize = new System.Drawing.Size(80, 80);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Padding = new System.Windows.Forms.Padding(5);
            this.btnGrande.Size = new System.Drawing.Size(80, 80);
            this.btnGrande.TabIndex = 12;
            this.btnGrande.Text = "Grande\r\n\r\n+500원";
            this.btnGrande.UseVisualStyleBackColor = true;
            this.btnGrande.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // 사이즈
            // 
            this.사이즈.AutoSize = true;
            this.tlpOption.SetColumnSpan(this.사이즈, 3);
            this.사이즈.Dock = System.Windows.Forms.DockStyle.Fill;
            this.사이즈.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.사이즈.Location = new System.Drawing.Point(20, 0);
            this.사이즈.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.사이즈.Name = "사이즈";
            this.사이즈.Size = new System.Drawing.Size(515, 20);
            this.사이즈.TabIndex = 0;
            this.사이즈.Text = "사이즈 선택";
            this.사이즈.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 컵
            // 
            this.컵.AutoSize = true;
            this.tlpOption.SetColumnSpan(this.컵, 3);
            this.컵.Dock = System.Windows.Forms.DockStyle.Fill;
            this.컵.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.컵.Location = new System.Drawing.Point(20, 140);
            this.컵.Margin = new System.Windows.Forms.Padding(20);
            this.컵.Name = "컵";
            this.컵.Size = new System.Drawing.Size(515, 20);
            this.컵.TabIndex = 1;
            this.컵.Text = "컵 선택";
            this.컵.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGlass
            // 
            this.btnGlass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGlass.AutoSize = true;
            this.btnGlass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlass.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlass.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnGlass.Location = new System.Drawing.Point(142, 180);
            this.btnGlass.Margin = new System.Windows.Forms.Padding(0);
            this.btnGlass.MaximumSize = new System.Drawing.Size(80, 80);
            this.btnGlass.MinimumSize = new System.Drawing.Size(80, 80);
            this.btnGlass.Name = "btnGlass";
            this.btnGlass.Size = new System.Drawing.Size(80, 80);
            this.btnGlass.TabIndex = 7;
            this.btnGlass.Text = "매장컵";
            this.btnGlass.UseVisualStyleBackColor = true;
            this.btnGlass.Click += new System.EventHandler(this.btnCup_Click);
            // 
            // btnTumbler
            // 
            this.btnTumbler.AutoSize = true;
            this.btnTumbler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTumbler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTumbler.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTumbler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumbler.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnTumbler.Location = new System.Drawing.Point(333, 180);
            this.btnTumbler.Margin = new System.Windows.Forms.Padding(0);
            this.btnTumbler.MaximumSize = new System.Drawing.Size(80, 80);
            this.btnTumbler.MinimumSize = new System.Drawing.Size(80, 80);
            this.btnTumbler.Name = "btnTumbler";
            this.btnTumbler.Size = new System.Drawing.Size(80, 80);
            this.btnTumbler.TabIndex = 6;
            this.btnTumbler.Text = "개인컵";
            this.btnTumbler.UseVisualStyleBackColor = true;
            this.btnTumbler.Click += new System.EventHandler(this.btnCup_Click);
            // 
            // btnPlastic
            // 
            this.btnPlastic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlastic.AutoSize = true;
            this.btnPlastic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlastic.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPlastic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlastic.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnPlastic.Location = new System.Drawing.Point(237, 180);
            this.btnPlastic.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlastic.MaximumSize = new System.Drawing.Size(80, 80);
            this.btnPlastic.MinimumSize = new System.Drawing.Size(80, 80);
            this.btnPlastic.Name = "btnPlastic";
            this.btnPlastic.Size = new System.Drawing.Size(80, 80);
            this.btnPlastic.TabIndex = 5;
            this.btnPlastic.Text = "일회용컵";
            this.btnPlastic.UseVisualStyleBackColor = true;
            this.btnPlastic.Click += new System.EventHandler(this.btnCup_Click);
            // 
            // btnTall
            // 
            this.btnTall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTall.AutoSize = true;
            this.btnTall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTall.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTall.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnTall.Location = new System.Drawing.Point(142, 40);
            this.btnTall.Margin = new System.Windows.Forms.Padding(0);
            this.btnTall.MaximumSize = new System.Drawing.Size(80, 80);
            this.btnTall.MinimumSize = new System.Drawing.Size(80, 80);
            this.btnTall.Name = "btnTall";
            this.btnTall.Padding = new System.Windows.Forms.Padding(5);
            this.btnTall.Size = new System.Drawing.Size(80, 80);
            this.btnTall.TabIndex = 11;
            this.btnTall.Text = "Tall\r\n\r\n+0원\r\n";
            this.btnTall.UseVisualStyleBackColor = true;
            this.btnTall.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // 수량
            // 
            this.수량.AutoSize = true;
            this.tlpOption.SetColumnSpan(this.수량, 3);
            this.수량.Dock = System.Windows.Forms.DockStyle.Fill;
            this.수량.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.수량.Location = new System.Drawing.Point(20, 280);
            this.수량.Margin = new System.Windows.Forms.Padding(20);
            this.수량.Name = "수량";
            this.수량.Size = new System.Drawing.Size(515, 20);
            this.수량.TabIndex = 14;
            this.수량.Text = "수량";
            this.수량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tlpOption.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.lblAmount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMinus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPlus, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 320);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 80);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(257, 5);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblAmount.Size = new System.Drawing.Size(39, 31);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "1";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(222, 0);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(301, 0);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 30);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tlpProduct
            // 
            this.tlpProduct.AutoSize = true;
            this.tlpProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpProduct.ColumnCount = 1;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.Controls.Add(this.pbProductImage, 0, 0);
            this.tlpProduct.Controls.Add(this.lblProductName, 0, 1);
            this.tlpProduct.Controls.Add(this.lblProductPrice, 0, 2);
            this.tlpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProduct.Location = new System.Drawing.Point(3, 3);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.RowCount = 3;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpProduct.Size = new System.Drawing.Size(549, 273);
            this.tlpProduct.TabIndex = 4;
            // 
            // pbProductImage
            // 
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProductImage.Image = global::Kiosk.Properties.Resources.iced_caffe_americano;
            this.pbProductImage.Location = new System.Drawing.Point(10, 10);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(10);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(529, 171);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblProductName.Location = new System.Drawing.Point(0, 191);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(549, 40);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "아이스 카페 아메리카노";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductPrice.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.lblProductPrice.Location = new System.Drawing.Point(0, 231);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(549, 20);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "4,500원";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpAction
            // 
            this.tlpAction.AutoSize = true;
            this.tlpAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.tlpAction.ColumnCount = 2;
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpAction.Controls.Add(this.btnBack, 0, 0);
            this.tlpAction.Controls.Add(this.btnAdd, 1, 0);
            this.tlpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAction.Location = new System.Drawing.Point(0, 729);
            this.tlpAction.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAction.MaximumSize = new System.Drawing.Size(0, 50);
            this.tlpAction.MinimumSize = new System.Drawing.Size(0, 50);
            this.tlpAction.Name = "tlpAction";
            this.tlpAction.RowCount = 1;
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAction.Size = new System.Drawing.Size(555, 50);
            this.tlpAction.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnBack.Location = new System.Drawing.Point(10, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "취소";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(116, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(429, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl총주문금액, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountPrice, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 679);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 50);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbl총주문금액
            // 
            this.lbl총주문금액.AutoSize = true;
            this.lbl총주문금액.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl총주문금액.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lbl총주문금액.Location = new System.Drawing.Point(0, 0);
            this.lbl총주문금액.Margin = new System.Windows.Forms.Padding(0);
            this.lbl총주문금액.Name = "lbl총주문금액";
            this.lbl총주문금액.Size = new System.Drawing.Size(444, 50);
            this.lbl총주문금액.TabIndex = 0;
            this.lbl총주문금액.Text = "총 주문금액";
            this.lbl총주문금액.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountPrice
            // 
            this.lblAmountPrice.AutoSize = true;
            this.lblAmountPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmountPrice.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAmountPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.lblAmountPrice.Location = new System.Drawing.Point(444, 0);
            this.lblAmountPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblAmountPrice.Name = "lblAmountPrice";
            this.lblAmountPrice.Size = new System.Drawing.Size(111, 50);
            this.lblAmountPrice.TabIndex = 1;
            this.lblAmountPrice.Text = "4,500원";
            this.lblAmountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Option";
            this.Size = new System.Drawing.Size(555, 779);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpOption.ResumeLayout(false);
            this.tlpOption.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpProduct.ResumeLayout(false);
            this.tlpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.tlpAction.ResumeLayout(false);
            this.tlpAction.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Label 사이즈;
        private System.Windows.Forms.Label 컵;
        private System.Windows.Forms.Button btnTumbler;
        private System.Windows.Forms.Button btnPlastic;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Button btnGlass;
        private System.Windows.Forms.Button btnTall;
        private System.Windows.Forms.Button btnGrande;
        private System.Windows.Forms.Button btnVenti;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tlpAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl총주문금액;
        private System.Windows.Forms.Label 수량;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblAmountPrice;
    }
}
