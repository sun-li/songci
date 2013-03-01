namespace appSongCi
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTemplate = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoetry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCopyToClip = new System.Windows.Forms.Button();
            this.btnSaveTo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.tabTemplate.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNumber.Location = new System.Drawing.Point(17, 30);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumber.Size = new System.Drawing.Size(496, 72);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "㈠ 请输入一串数（每两位数会被智能转换为一个词， 位数不足时转换为★）";
            // 
            // tabTemplate
            // 
            this.tabTemplate.Controls.Add(this.tabPage6);
            this.tabTemplate.Controls.Add(this.tabPage2);
            this.tabTemplate.Controls.Add(this.tabPage4);
            this.tabTemplate.Controls.Add(this.tabPage1);
            this.tabTemplate.Controls.Add(this.tabPage8);
            this.tabTemplate.Controls.Add(this.tabPage7);
            this.tabTemplate.Controls.Add(this.tabPage3);
            this.tabTemplate.Controls.Add(this.tabPage5);
            this.tabTemplate.Location = new System.Drawing.Point(17, 130);
            this.tabTemplate.Margin = new System.Windows.Forms.Padding(5);
            this.tabTemplate.Multiline = true;
            this.tabTemplate.Name = "tabTemplate";
            this.tabTemplate.SelectedIndex = 0;
            this.tabTemplate.Size = new System.Drawing.Size(243, 294);
            this.tabTemplate.TabIndex = 8;
            this.tabTemplate.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabTemplate_Selected);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Location = new System.Drawing.Point(4, 50);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(235, 240);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "天净沙";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(235, 240);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "（马致远）\r\n\r\n枯藤老树昏鸦\r\n小桥流水人家\r\n古道西风瘦马\r\n夕阳西下\r\n断肠人在天涯";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 50);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(235, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "西江月";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(235, 240);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "（辛弃疾）\r\n\r\n明月别枝惊鹊\r\n清风半夜鸣蝉\r\n稻花香里说丰年\r\n听取蛙声一片\r\n\r\n七八个星天外\r\n两三点雨山前\r\n旧时茅店社林边\r\n路转溪桥忽见";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 50);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(235, 240);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "清平乐";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(235, 240);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "（辛弃疾）\r\n\r\n绕床饥鼠\r\n蝙蝠翻灯舞\r\n屋上松风吹急雨\r\n破纸窗间自语\r\n\r\n平生塞北江南\r\n归来华发苍颜\r\n布被秋宵梦觉\r\n眼前万里江山";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 50);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(235, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "如梦令";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(235, 240);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "（李清照）\r\n\r\n昨夜雨疏风骤\r\n浓睡不消残酒\r\n试问卷帘人\r\n却道海棠依旧\r\n知否，知否\r\n应是绿肥红瘦";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.textBox9);
            this.tabPage8.Location = new System.Drawing.Point(4, 50);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(235, 240);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "采桑子";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(0, 0);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox9.Size = new System.Drawing.Size(235, 240);
            this.textBox9.TabIndex = 5;
            this.textBox9.Text = "（毛泽东）\r\n\r\n人生易老天难老\r\n岁岁重阳\r\n今又重阳\r\n战地黄花分外香\r\n\r\n一年一度秋风劲\r\n不似春光\r\n胜似春光\r\n寥廓江天万里霜";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.textBox8);
            this.tabPage7.Location = new System.Drawing.Point(4, 50);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(235, 240);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "忆江南";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Margin = new System.Windows.Forms.Padding(5);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(235, 240);
            this.textBox8.TabIndex = 4;
            this.textBox8.Text = "（白居易）\r\n\r\n江南好\r\n风景旧曾谙\r\n日出江花红胜火\r\n春来江水绿如蓝\r\n能不忆江南";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 50);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(235, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "沁园春";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(235, 240);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "（毛泽东）\r\n\r\n北国风光\r\n千里冰封\r\n万里雪飘\r\n望长城内外\r\n惟余莽莽\r\n大河上下\r\n顿失滔滔\r\n山舞银蛇\r\n原驰蜡象\r\n欲与天公试比高\r\n须晴日\r\n看红装" +
                "素裹\r\n分外妖娆\r\n\r\n江山如此多娇\r\n引无数英雄竞折腰\r\n惜秦皇汉武\r\n略输文采\r\n唐宗宋祖\r\n稍逊风骚\r\n一代天骄\r\n成吉思汗\r\n只识弯弓射大雕\r\n俱往矣\r" +
                "\n数风流人物\r\n还看今朝";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Location = new System.Drawing.Point(4, 50);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage5.Size = new System.Drawing.Size(235, 240);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "念奴娇";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(235, 240);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "（苏轼）\r\n\r\n大江东去\r\n浪淘尽\r\n千古风流人物\r\n故垒西边\r\n人道是\r\n三国周郎赤壁\r\n乱石穿空\r\n惊涛拍岸\r\n卷起千堆雪\r\n\r\n江山如画\r\n一时多少豪杰\r\n" +
                "遥想公瑾当年\r\n小乔初嫁了\r\n雄姿英发\r\n羽扇纶巾\r\n谈笑间\r\n樯橹灰飞烟灭\r\n故国神游\r\n多情应笑我\r\n早生华发\r\n人生如梦\r\n一樽还酹江月";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "㈡ 请选择您的词牌";
            // 
            // txtPoetry
            // 
            this.txtPoetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPoetry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPoetry.Location = new System.Drawing.Point(270, 130);
            this.txtPoetry.Margin = new System.Windows.Forms.Padding(5);
            this.txtPoetry.Multiline = true;
            this.txtPoetry.Name = "txtPoetry";
            this.txtPoetry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPoetry.Size = new System.Drawing.Size(243, 294);
            this.txtPoetry.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "㈢ 请润色您的词";
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(523, 30);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(523, 71);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(5);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(111, 31);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "生成随机数";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCopyToClip
            // 
            this.btnCopyToClip.Location = new System.Drawing.Point(523, 130);
            this.btnCopyToClip.Margin = new System.Windows.Forms.Padding(5);
            this.btnCopyToClip.Name = "btnCopyToClip";
            this.btnCopyToClip.Size = new System.Drawing.Size(111, 31);
            this.btnCopyToClip.TabIndex = 4;
            this.btnCopyToClip.Text = "复制到剪贴板";
            this.btnCopyToClip.UseVisualStyleBackColor = true;
            this.btnCopyToClip.Click += new System.EventHandler(this.btnCopyToClip_Click);
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveTo.Location = new System.Drawing.Point(523, 170);
            this.btnSaveTo.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Size = new System.Drawing.Size(111, 31);
            this.btnSaveTo.TabIndex = 5;
            this.btnSaveTo.Text = "保存到文件";
            this.btnSaveTo.UseVisualStyleBackColor = true;
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(523, 250);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(523, 211);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(111, 31);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "查看说明";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "*.txt";
            this.dlgSave.Filter = "文本文件 (*.txt)|*.txt";
            this.dlgSave.Title = "保存到文本文件";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(648, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSaveTo);
            this.Controls.Add(this.btnCopyToClip);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoetry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宋词傻瓜机";
            this.tabTemplate.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabTemplate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtPoetry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCopyToClip;
        private System.Windows.Forms.Button btnSaveTo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

