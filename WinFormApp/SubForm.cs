/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
Copyright © 2018 chibayuki@foxmail.com

Windows窗体应用程序模板 (WinFormAppTemplate)
Version 18.9.28.2200

This file is part of "Windows窗体应用程序模板" (WinFormAppTemplate)

"Windows窗体应用程序模板" (WinFormAppTemplate) is released under the GPLv3 license
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class SubForm : Form
    {
        private Com.WinForm.FormManager Me;

        public Com.WinForm.FormManager FormManager
        {
            get
            {
                return Me;
            }
        }

        private void _Ctor(Com.WinForm.FormManager owner)
        {
            InitializeComponent();

            //

            if (owner != null)
            {
                Me = new Com.WinForm.FormManager(this, owner);
            }
            else
            {
                Me = new Com.WinForm.FormManager(this);
            }

            //

            FormDefine();
        }

        public SubForm()
        {
            _Ctor(null);
        }

        public SubForm(Com.WinForm.FormManager owner)
        {
            _Ctor(owner);
        }

        private void FormDefine()
        {

        }
    }
}