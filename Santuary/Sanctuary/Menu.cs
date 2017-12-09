using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanctuary
{
    class Menu : Panel
    {

        private const int SIZE = 1000;
        private Button playButton;

        public Menu()
        {
            DoubleBuffered = true;

            BackColor = Color.DarkSeaGreen;
            Size = new Size(SIZE, SIZE);

            // TODO create a flashier button
            CreatePlayButton();
        }

        private void CreatePlayButton()
        {
            int x = 100;
            int y = 30;

            int pbx = (SIZE / 2) - (x / 2);
            int pby = (SIZE / 2) - (y / 2);

            playButton = new Button();

            playButton.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            playButton.Size = new Size(x, y);
            playButton.Location = new Point(pbx, pby);
            playButton.Text = "Play!";
            playButton.Click += new EventHandler(PBClick);
            playButton.BackColor = Color.Cornsilk;
            playButton.TabIndex = 1;

            Controls.Add(playButton);
        }

        private void PBClick(object sender, EventArgs e)
        {
            // TODO Connect this to the controller
            Console.WriteLine("Play was clicked.");
        }
    }
}
