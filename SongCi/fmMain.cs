using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSongCi
{
    public partial class fmMain : Form
    {
        private static string[] strsKeyWords = {
            "东风", 
            "何处",
            "人间",
            "风流",
            "归去",
            "春风",
            "西风",
            "归来",
            "江南",
            "相思",
            "梅花",
            "千里",
            "回首",
            "明月",
            "多少",
            "如今",
            "阑干",
            "年年",
            "万里",
            "一笑",
            "黄昏",
            "当年",
            "天涯",
            "相逢",
            "芳草",
            "尊前",
            "一枝",
            "风雨",
            "流水",
            "依旧",
            "风吹",
            "风月",
            "多情",
            "故人",
            "当时",
            "无人",
            "斜阳",
            "不知",
            "不见",
            "深处",
            "时节",
            "平生",
            "凄凉",
            "春色",
            "匆匆",
            "功名",
            "一点",
            "无限",
            "今日",
            "天上",
            "杨柳",
            "西湖",
            "桃花",
            "扁舟",
            "消息",
            "憔悴",
            "何事",
            "芙蓉",
            "神仙",
            "一片",
            "桃李",
            "人生",
            "十分",
            "心事",
            "黄花",
            "一声",
            "佳人",
            "长安",
            "东君",
            "断肠",
            "而今",
            "鸳鸯",
            "为谁",
            "十年",
            "去年",
            "少年",
            "海棠",
            "寂寞",
            "无情",
            "不是",
            "时候",
            "肠断",
            "富贵",
            "蓬莱",
            "昨夜",
            "行人",
            "今夜",
            "谁知",
            "不似",
            "江上",
            "悠悠",
            "几度",
            "青山",
            "何时",
            "天气",
            "惟有",
            "一曲",
            "月明",
            "往事",
            "苍茫",   // appending by SUN Li
            "★★"    // Nil key word
        };

        private int conTotalKeyWords = strsKeyWords.Length;
        private int conNilKeyWord = strsKeyWords.Length - 1;
        private const int conMaxWords = 114;
        private int[] intsMagicNumber = new int[conMaxWords];

        private void GenerateRandomNumber()
        {
            Random rnd = new Random();
            int n;
            string str = "";

            for (int i = 0; i < conMaxWords; i++)
            {
                n = rnd.Next(0, conTotalKeyWords-1);
                if (n < 10)
                    str += "0";

                str += n;
            }

            txtNumber.Text = str;
        }

        private void RemoveNonDigit()
        {
            string str = "";

            for ( int i = 0; i < txtNumber.Text.Length; i++ )
                if ( char.IsDigit(txtNumber.Text[i]) )
                    str += txtNumber.Text[i];

            txtNumber.Text = str;
        }

        private void UpdateNumber()
        {
            if (txtNumber.Text.Length == 0)
            {
                for (int i = 0; i < conMaxWords; i++)
                    intsMagicNumber[i] = conNilKeyWord;

                txtPoetry.Text = "";
            }

            int j = 0;
            int l = txtNumber.Text.Length - (txtNumber.Text.Length % 2);
            for ( int i = 0; (i < l) && (j < conMaxWords); i+=2, j++ )
                intsMagicNumber[j] = (txtNumber.Text[i] - '0') * 10 + (txtNumber.Text[i+1] - '0');
            for (; j < conMaxWords; j++)
                intsMagicNumber[j] = conNilKeyWord;
        }

        private void ClearNumber()
        {
            txtNumber.Text = "";
            txtPoetry.Text = "";
        }

        private void GeneratePoetry()
        {
            if ( txtNumber.Text.Length == 0 )
                return;

            TextBox txtTemplate = (TextBox)tabTemplate.SelectedTab.Controls[0];

            txtPoetry.Text = tabTemplate.SelectedTab.Text + "\r\n";

            int k = 0;
            for (int i=2; i<txtTemplate.Lines.Length; i++)
            {
                txtPoetry.Text += "\r\n";

                int j = 0;
                while (j < txtTemplate.Lines[i].Length - 1)
                    if (txtTemplate.Lines[i][j] == '，')
                    {
                        txtPoetry.Text += "，";
                        j++;
                    }
                    else
                    {
                        txtPoetry.Text += strsKeyWords[intsMagicNumber[k]];
                        j += 2;
                        k++;
                    }

                if (j < txtTemplate.Lines[i].Length)
                    txtPoetry.Text += "★";
            }
        }

        public fmMain()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            GenerateRandomNumber();
            GeneratePoetry();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearNumber();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabTemplate_Selected(object sender, TabControlEventArgs e)
        {
            GeneratePoetry();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)13 )
            {
                e.Handled = true;
                return;
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            RemoveNonDigit();
            UpdateNumber();
            GeneratePoetry();
        }

        private void btnCopyToClip_Click(object sender, EventArgs e)
        {
            if (txtPoetry.Text.Length == 0)
                return;
            
            Clipboard.SetText(txtPoetry.Text);
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            if (txtPoetry.Text.Length == 0)
                return;

            if (dlgSave.ShowDialog() != DialogResult.OK)
                return;

            TextWriter tw = new StreamWriter(dlgSave.FileName);
            tw.WriteLine(txtPoetry.Text);
            tw.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form fm = new fmAbout();
            
            fm.ShowDialog();
        }


    }
}
