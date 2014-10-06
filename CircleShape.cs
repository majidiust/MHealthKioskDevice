using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Telerik.WinControls.UI;

namespace MHealthKiosk
{
    class CircleShape : UserControl
    {
        // Draw the new button. 
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            // Draw the button in the form of a circle
            graphics.DrawEllipse(myPen, 0, 0, ClientSize.Width, ClientSize.Height);
            myPen.Dispose();
        }
    }
}
