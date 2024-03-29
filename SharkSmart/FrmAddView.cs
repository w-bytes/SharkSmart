﻿using EVClassLib;
using EVTechnology.Controls;
using System;
using System.Windows.Forms;

namespace SharkSmart
{
    public partial class FrmAddView : EVForm
    {
        public ViewPage Page { set; get; }

        public FrmAddView()
        {
            InitializeComponent();
        }

        private void FrmAddView_Load(object sender, EventArgs e)
        {
            if (Tag != null)
                tbName.Text = Tag.ToString();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("请输入单元名称!");
                return;
            }
            Page = new ViewPage();
            Page.Name = tbName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
