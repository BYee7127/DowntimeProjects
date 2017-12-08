using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanctuary
{
    public partial class Sanctuary : Form
    {

        /// <summary>
        /// Constructor for the View
        /// </summary>
        public Sanctuary()
        {
            InitializeComponent();
        }


        protected override bool IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }
    }
}
