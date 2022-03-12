namespace V_Excel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LABEL_SEQ = new System.Windows.Forms.Label();
            this.TB_SEQ = new System.Windows.Forms.TextBox();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_分類1 = new System.Windows.Forms.ComboBox();
            this.LABEL_MSG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBO_分類2 = new System.Windows.Forms.ComboBox();
            this.LABEL_樣態大屬性 = new System.Windows.Forms.Label();
            this.CBO_樣態大屬性 = new System.Windows.Forms.ComboBox();
            this.LABEL_樣態小屬性 = new System.Windows.Forms.Label();
            this.CBO_樣態小屬性 = new System.Windows.Forms.ComboBox();
            this.BTN_QUERY = new System.Windows.Forms.Button();
            this.TB_新聞內容 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_發布機關 = new System.Windows.Forms.TextBox();
            this.TB_主辦機關 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_協辦機關 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_通報機關 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_關鍵字1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_關鍵字2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_關鍵字3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_品名 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_下游 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_上游 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_廠商 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_法條 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_處置 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CBO_品項 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CBO_符合標準 = new System.Windows.Forms.ComboBox();
            this.TB_新聞標題 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_主鍵值 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_事件 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LABEL_SEQ
            // 
            this.LABEL_SEQ.AutoSize = true;
            this.LABEL_SEQ.Location = new System.Drawing.Point(20, 20);
            this.LABEL_SEQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_SEQ.Name = "LABEL_SEQ";
            this.LABEL_SEQ.Size = new System.Drawing.Size(39, 18);
            this.LABEL_SEQ.TabIndex = 0;
            this.LABEL_SEQ.Text = "SEQ";
            // 
            // TB_SEQ
            // 
            this.TB_SEQ.Location = new System.Drawing.Point(68, 12);
            this.TB_SEQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_SEQ.Name = "TB_SEQ";
            this.TB_SEQ.Size = new System.Drawing.Size(96, 29);
            this.TB_SEQ.TabIndex = 1;
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Location = new System.Drawing.Point(417, 12);
            this.BTN_CLEAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(112, 34);
            this.BTN_CLEAR.TabIndex = 2;
            this.BTN_CLEAR.Text = "CLEAN";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(296, 12);
            this.BTN_UPDATE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(112, 34);
            this.BTN_UPDATE.TabIndex = 3;
            this.BTN_UPDATE.Text = "UPDATE";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "分類1";
            // 
            // CBO_分類1
            // 
            this.CBO_分類1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBO_分類1.FormattingEnabled = true;
            this.CBO_分類1.ItemHeight = 20;
            this.CBO_分類1.Location = new System.Drawing.Point(76, 72);
            this.CBO_分類1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_分類1.Name = "CBO_分類1";
            this.CBO_分類1.Size = new System.Drawing.Size(132, 28);
            this.CBO_分類1.TabIndex = 5;
            // 
            // LABEL_MSG
            // 
            this.LABEL_MSG.AutoSize = true;
            this.LABEL_MSG.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LABEL_MSG.Location = new System.Drawing.Point(538, 18);
            this.LABEL_MSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_MSG.Name = "LABEL_MSG";
            this.LABEL_MSG.Size = new System.Drawing.Size(102, 23);
            this.LABEL_MSG.TabIndex = 6;
            this.LABEL_MSG.Text = "訊息在此";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(228, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "分類2";
            // 
            // CBO_分類2
            // 
            this.CBO_分類2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBO_分類2.FormattingEnabled = true;
            this.CBO_分類2.Location = new System.Drawing.Point(291, 72);
            this.CBO_分類2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_分類2.Name = "CBO_分類2";
            this.CBO_分類2.Size = new System.Drawing.Size(164, 28);
            this.CBO_分類2.TabIndex = 8;
            // 
            // LABEL_樣態大屬性
            // 
            this.LABEL_樣態大屬性.AutoSize = true;
            this.LABEL_樣態大屬性.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LABEL_樣態大屬性.Location = new System.Drawing.Point(18, 130);
            this.LABEL_樣態大屬性.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_樣態大屬性.Name = "LABEL_樣態大屬性";
            this.LABEL_樣態大屬性.Size = new System.Drawing.Size(121, 20);
            this.LABEL_樣態大屬性.TabIndex = 9;
            this.LABEL_樣態大屬性.Text = "樣態(大屬性)";
            // 
            // CBO_樣態大屬性
            // 
            this.CBO_樣態大屬性.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBO_樣態大屬性.FormattingEnabled = true;
            this.CBO_樣態大屬性.ItemHeight = 24;
            this.CBO_樣態大屬性.Location = new System.Drawing.Point(158, 122);
            this.CBO_樣態大屬性.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_樣態大屬性.Name = "CBO_樣態大屬性";
            this.CBO_樣態大屬性.Size = new System.Drawing.Size(404, 32);
            this.CBO_樣態大屬性.TabIndex = 10;
            this.CBO_樣態大屬性.SelectedIndexChanged += new System.EventHandler(this.CBO_樣態大屬性_CHANGE);
            // 
            // LABEL_樣態小屬性
            // 
            this.LABEL_樣態小屬性.AutoSize = true;
            this.LABEL_樣態小屬性.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LABEL_樣態小屬性.Location = new System.Drawing.Point(18, 184);
            this.LABEL_樣態小屬性.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_樣態小屬性.Name = "LABEL_樣態小屬性";
            this.LABEL_樣態小屬性.Size = new System.Drawing.Size(121, 20);
            this.LABEL_樣態小屬性.TabIndex = 11;
            this.LABEL_樣態小屬性.Text = "樣態(小屬性)";
            // 
            // CBO_樣態小屬性
            // 
            this.CBO_樣態小屬性.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBO_樣態小屬性.FormattingEnabled = true;
            this.CBO_樣態小屬性.Location = new System.Drawing.Point(155, 176);
            this.CBO_樣態小屬性.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_樣態小屬性.Name = "CBO_樣態小屬性";
            this.CBO_樣態小屬性.Size = new System.Drawing.Size(988, 32);
            this.CBO_樣態小屬性.TabIndex = 12;
            this.CBO_樣態小屬性.TextUpdate += new System.EventHandler(this.CBO_樣態小屬性_TEXTUPDATE);
            // 
            // BTN_QUERY
            // 
            this.BTN_QUERY.Location = new System.Drawing.Point(174, 12);
            this.BTN_QUERY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_QUERY.Name = "BTN_QUERY";
            this.BTN_QUERY.Size = new System.Drawing.Size(112, 34);
            this.BTN_QUERY.TabIndex = 14;
            this.BTN_QUERY.Text = "QUERY";
            this.BTN_QUERY.UseVisualStyleBackColor = true;
            this.BTN_QUERY.Click += new System.EventHandler(this.BTN_QUERY_Click);
            // 
            // TB_新聞內容
            // 
            this.TB_新聞內容.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_新聞內容.Location = new System.Drawing.Point(13, 543);
            this.TB_新聞內容.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_新聞內容.Name = "TB_新聞內容";
            this.TB_新聞內容.ReadOnly = true;
            this.TB_新聞內容.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TB_新聞內容.Size = new System.Drawing.Size(1130, 382);
            this.TB_新聞內容.TabIndex = 15;
            this.TB_新聞內容.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(18, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "發布機關";
            // 
            // TB_發布機關
            // 
            this.TB_發布機關.Location = new System.Drawing.Point(116, 226);
            this.TB_發布機關.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_發布機關.Name = "TB_發布機關";
            this.TB_發布機關.Size = new System.Drawing.Size(236, 29);
            this.TB_發布機關.TabIndex = 18;
            // 
            // TB_主辦機關
            // 
            this.TB_主辦機關.Location = new System.Drawing.Point(116, 268);
            this.TB_主辦機關.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_主辦機關.Name = "TB_主辦機關";
            this.TB_主辦機關.Size = new System.Drawing.Size(236, 29);
            this.TB_主辦機關.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "主辦機關";
            // 
            // TB_協辦機關
            // 
            this.TB_協辦機關.Location = new System.Drawing.Point(116, 310);
            this.TB_協辦機關.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_協辦機關.Name = "TB_協辦機關";
            this.TB_協辦機關.Size = new System.Drawing.Size(236, 29);
            this.TB_協辦機關.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(18, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "協辦機關";
            // 
            // TB_通報機關
            // 
            this.TB_通報機關.Location = new System.Drawing.Point(116, 356);
            this.TB_通報機關.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_通報機關.Name = "TB_通報機關";
            this.TB_通報機關.Size = new System.Drawing.Size(236, 29);
            this.TB_通報機關.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(18, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "通報機關";
            // 
            // TB_關鍵字1
            // 
            this.TB_關鍵字1.Location = new System.Drawing.Point(483, 226);
            this.TB_關鍵字1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_關鍵字1.Name = "TB_關鍵字1";
            this.TB_關鍵字1.Size = new System.Drawing.Size(236, 29);
            this.TB_關鍵字1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(386, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "關鍵字1";
            // 
            // TB_關鍵字2
            // 
            this.TB_關鍵字2.Location = new System.Drawing.Point(483, 272);
            this.TB_關鍵字2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_關鍵字2.Name = "TB_關鍵字2";
            this.TB_關鍵字2.Size = new System.Drawing.Size(236, 29);
            this.TB_關鍵字2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(386, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "關鍵字2";
            // 
            // TB_關鍵字3
            // 
            this.TB_關鍵字3.Location = new System.Drawing.Point(483, 316);
            this.TB_關鍵字3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_關鍵字3.Name = "TB_關鍵字3";
            this.TB_關鍵字3.Size = new System.Drawing.Size(236, 29);
            this.TB_關鍵字3.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(386, 324);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "關鍵字3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(606, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "品項";
            // 
            // TB_品名
            // 
            this.TB_品名.Location = new System.Drawing.Point(805, 105);
            this.TB_品名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_品名.Name = "TB_品名";
            this.TB_品名.Size = new System.Drawing.Size(338, 29);
            this.TB_品名.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(747, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "品名";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(468, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "符合標準(Y/N)";
            // 
            // TB_下游
            // 
            this.TB_下游.Location = new System.Drawing.Point(907, 314);
            this.TB_下游.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_下游.Name = "TB_下游";
            this.TB_下游.Size = new System.Drawing.Size(236, 29);
            this.TB_下游.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(848, 321);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "下游";
            // 
            // TB_上游
            // 
            this.TB_上游.Location = new System.Drawing.Point(907, 268);
            this.TB_上游.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_上游.Name = "TB_上游";
            this.TB_上游.Size = new System.Drawing.Size(236, 29);
            this.TB_上游.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(848, 273);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "上游";
            // 
            // TB_廠商
            // 
            this.TB_廠商.Location = new System.Drawing.Point(907, 224);
            this.TB_廠商.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_廠商.Name = "TB_廠商";
            this.TB_廠商.Size = new System.Drawing.Size(236, 29);
            this.TB_廠商.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(848, 228);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "廠商";
            // 
            // TB_法條
            // 
            this.TB_法條.Location = new System.Drawing.Point(619, 398);
            this.TB_法條.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_法條.Name = "TB_法條";
            this.TB_法條.Size = new System.Drawing.Size(524, 29);
            this.TB_法條.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(558, 402);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "法條";
            // 
            // TB_處置
            // 
            this.TB_處置.Location = new System.Drawing.Point(68, 396);
            this.TB_處置.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_處置.Name = "TB_處置";
            this.TB_處置.Size = new System.Drawing.Size(403, 29);
            this.TB_處置.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(18, 402);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "處置";
            // 
            // CBO_品項
            // 
            this.CBO_品項.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBO_品項.FormattingEnabled = true;
            this.CBO_品項.Location = new System.Drawing.Point(662, 60);
            this.CBO_品項.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_品項.Name = "CBO_品項";
            this.CBO_品項.Size = new System.Drawing.Size(481, 32);
            this.CBO_品項.TabIndex = 47;
            this.CBO_品項.TextUpdate += new System.EventHandler(this.CBO_品項_TEXTUPDATE);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(995, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 29);
            this.textBox1.TabIndex = 48;
            this.textBox1.Text = "、";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 356);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(148, 29);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "、";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(616, 356);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(148, 29);
            this.textBox3.TabIndex = 50;
            this.textBox3.Text = "、";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(995, 356);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(148, 29);
            this.textBox4.TabIndex = 51;
            this.textBox4.Text = "、";
            // 
            // CBO_符合標準
            // 
            this.CBO_符合標準.FormattingEnabled = true;
            this.CBO_符合標準.Items.AddRange(new object[] {
            "",
            "N",
            "Y"});
            this.CBO_符合標準.Location = new System.Drawing.Point(486, 81);
            this.CBO_符合標準.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_符合標準.Name = "CBO_符合標準";
            this.CBO_符合標準.Size = new System.Drawing.Size(96, 26);
            this.CBO_符合標準.TabIndex = 52;
            // 
            // TB_新聞標題
            // 
            this.TB_新聞標題.Location = new System.Drawing.Point(117, 502);
            this.TB_新聞標題.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_新聞標題.Name = "TB_新聞標題";
            this.TB_新聞標題.ReadOnly = true;
            this.TB_新聞標題.Size = new System.Drawing.Size(1026, 29);
            this.TB_新聞標題.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(21, 506);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "新聞標題";
            // 
            // TB_主鍵值
            // 
            this.TB_主鍵值.Location = new System.Drawing.Point(1019, 13);
            this.TB_主鍵值.Margin = new System.Windows.Forms.Padding(4);
            this.TB_主鍵值.Name = "TB_主鍵值";
            this.TB_主鍵值.ReadOnly = true;
            this.TB_主鍵值.Size = new System.Drawing.Size(124, 29);
            this.TB_主鍵值.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(950, 22);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 18);
            this.label19.TabIndex = 56;
            this.label19.Text = "主鍵值";
            // 
            // TB_事件
            // 
            this.TB_事件.Location = new System.Drawing.Point(117, 453);
            this.TB_事件.Margin = new System.Windows.Forms.Padding(4);
            this.TB_事件.Name = "TB_事件";
            this.TB_事件.Size = new System.Drawing.Size(1024, 29);
            this.TB_事件.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(19, 457);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 20);
            this.label20.TabIndex = 57;
            this.label20.Text = "事件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1161, 956);
            this.Controls.Add(this.TB_事件);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TB_主鍵值);
            this.Controls.Add(this.TB_新聞標題);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CBO_符合標準);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CBO_品項);
            this.Controls.Add(this.TB_法條);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TB_處置);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TB_下游);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TB_上游);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TB_廠商);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_品名);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_關鍵字3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_關鍵字2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_關鍵字1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_通報機關);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_協辦機關);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_主辦機關);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_發布機關);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_新聞內容);
            this.Controls.Add(this.BTN_QUERY);
            this.Controls.Add(this.CBO_樣態小屬性);
            this.Controls.Add(this.LABEL_樣態小屬性);
            this.Controls.Add(this.CBO_樣態大屬性);
            this.Controls.Add(this.LABEL_樣態大屬性);
            this.Controls.Add(this.CBO_分類2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LABEL_MSG);
            this.Controls.Add(this.CBO_分類1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.TB_SEQ);
            this.Controls.Add(this.LABEL_SEQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "V_Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_SEQ;
        private System.Windows.Forms.TextBox TB_SEQ;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_分類1;
        private System.Windows.Forms.Label LABEL_MSG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBO_分類2;
        private System.Windows.Forms.Label LABEL_樣態大屬性;
        private System.Windows.Forms.ComboBox CBO_樣態大屬性;
        private System.Windows.Forms.Label LABEL_樣態小屬性;
        private System.Windows.Forms.ComboBox CBO_樣態小屬性;
        private System.Windows.Forms.Button BTN_QUERY;
        private System.Windows.Forms.RichTextBox TB_新聞內容;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_發布機關;
        private System.Windows.Forms.TextBox TB_主辦機關;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_協辦機關;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_通報機關;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_關鍵字1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_關鍵字2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_關鍵字3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_品名;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_下游;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_上游;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_廠商;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_法條;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_處置;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CBO_品項;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox CBO_符合標準;
        private System.Windows.Forms.TextBox TB_新聞標題;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_主鍵值;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TB_事件;
        private System.Windows.Forms.Label label20;
    }
}

