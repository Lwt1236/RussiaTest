namespace RussiaFormDemo
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    class Russia
    {
       
        public const int cakeSize = 20;
        public Point[] cakePointArray = new Point[4];
        public Color cakeColor;
        //1,随机生成方块形状,由n_Sharp决定
        public void CreateCake(Control control,int n_Sharp,Point firstPoint)
        {
            cakePointArray[0] = firstPoint;
            DrawAreaClear(control);
            switch (n_Sharp)
            {
                case 0://"----"
                    cakePointArray[1] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y);
                    cakePointArray[2] = new Point(cakePointArray[0].X - 2*cakeSize, cakePointArray[0].Y);
                    cakePointArray[3] = new Point(cakePointArray[0].X + cakeSize, cakePointArray[0].Y);
                    cakeColor = Color.Yellow;
                    break;
                case 1://L
                    cakePointArray[1] = new Point(cakePointArray[0].X , cakePointArray[0].Y - cakeSize);
                    cakePointArray[2] = new Point(cakePointArray[0].X , cakePointArray[0].Y + cakeSize);
                    cakePointArray[3] = new Point(cakePointArray[0].X + cakeSize, cakePointArray[0].Y+cakeSize);
                    cakeColor = Color.Red;
                    break;
                case 2://反L
                    cakePointArray[1] = new Point(cakePointArray[0].X, cakePointArray[0].Y - cakeSize);
                    cakePointArray[2] = new Point(cakePointArray[0].X, cakePointArray[0].Y + cakeSize);
                    cakePointArray[3] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y + cakeSize);
                    cakeColor = Color.Orange;
                    break;
                case 3://反Z
                    cakePointArray[1] = new Point(cakePointArray[0].X , cakePointArray[0].Y - cakeSize);
                    cakePointArray[2] = new Point(cakePointArray[0].X + cakeSize, cakePointArray[0].Y);
                    cakePointArray[3] = new Point(cakePointArray[0].X + cakeSize, cakePointArray[0].Y + cakeSize);
                    cakeColor = Color.Gray;
                    break;
                case 4://Z
                    cakePointArray[1] = new Point(cakePointArray[0].X , cakePointArray[0].Y - cakeSize);
                    cakePointArray[2] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y);
                    cakePointArray[3] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y+cakeSize);
                    cakeColor = Color.Green;
                    break;
                case 5://T
                    cakePointArray[1] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y);
                    cakePointArray[2] = new Point(cakePointArray[0].X + cakeSize, cakePointArray[0].Y);
                    cakePointArray[3] = new Point(cakePointArray[0].X, cakePointArray[0].Y + cakeSize);
                    cakeColor = Color.LightBlue;
                    break;
                case 6://田
                    cakePointArray[1] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y);
                    cakePointArray[2] = new Point(cakePointArray[0].X - cakeSize, cakePointArray[0].Y+cakeSize);
                    cakePointArray[3] = new Point(cakePointArray[0].X , cakePointArray[0].Y + cakeSize);
                    cakeColor = Color.OrangeRed;
                    break;
            }
            if(cakePointArray.Length>0)
            {
                DrawCake(control, cakeColor);
            }
        }

        //绘制单个方块
        public void DrawCake(Control control,Color cakeColor)
        {
            Graphics g = control.CreateGraphics();
            for (int i = 0; i < cakePointArray.Length; i++)
            {
                g.FillRectangle(new SolidBrush(cakeColor), cakePointArray[i].X, cakePointArray[i].Y,
                    cakeSize - 1, cakeSize - 1);
            }
        }

        //清空绘图区域
        public void DrawAreaClear(Control control)
        {
            Graphics g = control.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.Black), control.Location.X, control.Location.Y, control.Width, control.Height);
        }
    }

   

    
}
