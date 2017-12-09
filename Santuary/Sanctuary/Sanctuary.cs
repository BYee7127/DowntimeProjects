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

        private Menu menuScreen;

        private const int SIZE_X = 1300;        // panel 1 = 1000 and panel 2 = 300
        private const int SIZE_Y = 1000;        // always equals to panel 1's width

        /// <summary>
        /// Constructor for the View
        /// </summary>
        public Sanctuary()
        {
            InitializeComponent();

            // panel 1 will always be 1000 x 1000
            // panel 2 will always be 300 x 1000
            this.ClientSize = new Size(SIZE_X, SIZE_Y);

            InitializeVariables();
        }

        private void InitializeVariables()
        {
            menuScreen = new Menu();

            this.Controls.Add(menuScreen);
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
