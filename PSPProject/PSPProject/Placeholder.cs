﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PSPProject
{
    class Placeholder:TextBox
    {
        public Placeholder()
        { 
            this.Enter += new EventHandler(txt_Enter);
            this.Leave += new EventHandler(txt_Leave);
            base.ForeColor = Color.DimGray;
        }    

        private string placeHolder;
        [Description("Texto para el placeholder")]
        [Category("Placeholder")]
        public string PlaceHolder
        {
            get { return placeHolder; }
            set { placeHolder = value; }
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(txt.Text == placeHolder)
            {
                txt.Text = string.Empty;
                txt.ForeColor = Color.Black;
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(txt.Text == string.Empty)
            {
                txt.Text = placeHolder;
                txt.ForeColor = Color.DimGray;
            }
        }
    }
}
