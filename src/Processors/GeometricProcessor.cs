using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class GeometricProcessor : DisplayProcessor
    {
        #region Constructor

        public GeometricProcessor()
        {
        }

        #endregion

        #region Properties

        #endregion

        public override void DrawShape(Graphics grfx, Shape item)
        {

            grfx.Transform = new Matrix();
            grfx.Transform.RotateAt(20, new PointF(item.Location.X + item.Width / 2, item.Location.Y + item.Height/2));

            base.DrawShape(grfx, item);
                        
            //item.DrawSelf(grfx);
        }

    }
}
