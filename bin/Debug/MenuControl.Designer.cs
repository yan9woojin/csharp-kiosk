namespace Kiosk
{
    partial class MenuControl
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
            this.flpProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.flpCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.flpProductList, 0, 1);
            this.tlpMain.Controls.Add(this.flpCategories, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tlpMain.ForeColor = System.Drawing.Color.Black;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(667, 942);
            this.tlpMain.TabIndex = 0;
            // 
            // flpProductList
            // 
            this.flpProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpProductList.AutoSize = true;
            this.flpProductList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProductList.Location = new System.Drawing.Point(333, 40);
            this.flpProductList.Margin = new System.Windows.Forms.Padding(0);
            this.flpProductList.Name = "flpProductList";
            this.flpProductList.Size = new System.Drawing.Size(0, 902);
            this.flpProductList.TabIndex = 1;
            // 
            // flpCategories
            // 
            this.flpCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpCategories.AutoScroll = true;
            this.flpCategories.AutoSize = true;
            this.flpCategories.BackColor = System.Drawing.Color.Transparent;
            this.flpCategories.Controls.Add(this.btnDrink);
            this.flpCategories.Controls.Add(this.btnFood);
            this.flpCategories.Location = new System.Drawing.Point(243, 0);
            this.flpCategories.Margin = new System.Windows.Forms.Padding(0);
            this.flpCategories.MaximumSize = new System.Drawing.Size(180, 40);
            this.flpCategories.MinimumSize = new System.Drawing.Size(180, 40);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(180, 40);
            this.flpCategories.TabIndex = 0;
            // 
            // btnDrink
            // 
            this.btnDrink.AutoSize = true;
            this.btnDrink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.Location = new System.Drawing.Point(5, 5);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDrink.MaximumSize = new System.Drawing.Size(80, 35);
            this.btnDrink.MinimumSize = new System.Drawing.Size(80, 35);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(80, 35);
            this.btnDrink.TabIndex = 0;
            this.btnDrink.Text = "음료";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.BtnCategory_Click);
            this.btnDrink.MouseEnter += new System.EventHandler(this.BtnCategory_MouseEnter);
            this.btnDrink.MouseLeave += new System.EventHandler(this.BtnCategory_MouseLeave);
            // 
            // btnFood
            // 
            this.btnFood.AutoSize = true;
            this.btnFood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFood.Location = new System.Drawing.Point(95, 5);
            this.btnFood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnFood.MaximumSize = new System.Drawing.Size(80, 35);
            this.btnFood.MinimumSize = new System.Drawing.Size(80, 35);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(80, 35);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "푸드";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.BtnCategory_Click);
            this.btnFood.MouseEnter += new System.EventHandler(this.BtnCategory_MouseEnter);
            this.btnFood.MouseLeave += new System.EventHandler(this.BtnCategory_MouseLeave);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(667, 942);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.flpCategories.ResumeLayout(false);
            this.flpCategories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpProductList;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFood;
    }
}
