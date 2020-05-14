namespace RussiaFormDemo
{
    using System.Drawing;
    using System.Windows.Forms;

    public class RussiaHelper
    {
        Point[] cakeArray = new Point[4];
        Control currentControl;
        public const int cakeSize = 20;
        /// <summary>
        /// 移动方块
        /// </summary>
        /// <param name="n">根据n值判断移动方向（下，左，右）</param>
        public void MoveRussiaCake(int n)
        {
            switch (n)
            {
                case 0://down
                    for (int i = 0; i < cakeArray.Length; i++)
                    {
                        cakeArray[i].Y += cakeSize;
                    }
                    break;
                case 1://left
                    for (int i = 0; i < cakeArray.Length; i++)
                    {
                        cakeArray[i].X -= cakeSize;
                    }
                    break;
                case 2://right
                    for (int i = 0; i < cakeArray.Length; i++)
                    {
                        cakeArray[i].X += cakeSize;
                    }
                    break;
                default:
                    break;
            }
        }
        //是否出界
        public bool IsOutSide(int n)
        {
            bool isOutSide = false;
            switch (n)
            {
                case 0://down
                    for (int i = 0; i < cakeArray.Length; i++)
                    {
                        isOutSide = cakeArray[i].Y + cakeSize > currentControl.Height ? true : false;
                    }
                    break;
                case 1://left
                    for (int i = 0; i < cakeArray.Length; i++)
                    {
                        isOutSide = cakeArray[i].X <= 0 ? true : false;
                    }
                    break;
                case 2://right
                    for (int i = 0; i < cakeArray.Length; i++)
                    {
                        isOutSide = cakeArray[i].X + cakeSize > currentControl.Width ? true : false;
                    }
                    break;
                default:
                    break;
            }
            return isOutSide;
        }

        //清空框架
        public void ControlClear(Control currentControl)
        {
            if (currentControl != null)
            {
                Graphics g = currentControl.CreateGraphics();
                Rectangle rect = new Rectangle(0, 0, currentControl.Width, currentControl.Height);
                g.FillRectangle(new SolidBrush(Color.Black), rect);
            }
        }

        public void ExchangeCake(Point[] arrayPoint, int size)
        {
            //"----"型 2种变换

        }
    }
}
