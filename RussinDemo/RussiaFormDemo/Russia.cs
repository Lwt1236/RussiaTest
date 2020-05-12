namespace RussiaFormDemo
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    class Russia
    {
        public Point firstPoi = new Point(140, 20);//定义方块的起始位置
        public static Color[,] PlaceColor;//
        public static bool[,] Place;//
        public static int conWidth = 0;//记录列数
        public static int conHeight = 0;//记录行数
        public static int maxY = 0;//方块在行中的最小高度
        public static int conMax = 0;//方块落下后的最大位置
        public static int conMin = 0;//方块落下后的最小位置
        bool[] tem_Array = { false, false, false, false };//记录方块组中那一块所在行中已满
        Color ConColor = Color.Coral;
        Point[] ArryPoi = new Point[4];//方块的数组
        Point[] Arryfront = new Point[4];//前一个方块的数组
        int Cake = 20;//定义方块的大小
        int Convertor = 0;//变换器
        Control Mycontrol = new Control();//实例化Control
        public Label Label_Linage = new Label();//实例化Label，用于显示去除的行数
        public Label Label_Fraction = new Label();//实例化Label，用于显示分数
        public static int[] ArrayCent = new int[] { 2, 5, 9, 15 };//记录加分情况
        public Timer timer = new Timer();

        public void CakeMode(int n)
        {
            ArryPoi[0] = firstPoi;//记录方块起始位置
            switch (n)
            {
                case 1://:L方块
                    ArryPoi[1] = new Point(ArryPoi[0].X, ArryPoi[0].Y - Cake);
                    ArryPoi[2] = new Point(ArryPoi[0].X, ArryPoi[0].Y -2* Cake);
                    ArryPoi[3] = new Point(ArryPoi[0].X+Cake, ArryPoi[0].Y);
                    ConColor = Color.Fuchsia;//设置当前方块颜色
                    Convertor = 2;//方块的变换样式
                    break;
                case 2://组合“Z”方块
                     ArryPoi[1] = new Point(firstPoi.X, firstPoi.Y - Cake);
                     ArryPoi[2] = new Point(firstPoi.X - Cake, firstPoi.Y - Cake);
                     ArryPoi[3] = new Point(firstPoi.X + Cake, firstPoi.Y);
                     ConColor = Color.Yellow;
                     Convertor = 6;
                     break;
                         
                case 3://组合倒“L”方块
                     ArryPoi[1] = new Point(firstPoi.X, firstPoi.Y - Cake);
                     ArryPoi[2] = new Point(firstPoi.X, firstPoi.Y + Cake);
                     ArryPoi[3] = new Point(firstPoi.X - Cake, firstPoi.Y + Cake);
                     ConColor = Color.CornflowerBlue;
                     Convertor = 8;
                     break;
                case 4://组合倒“Z”方块
                     ArryPoi[1] = new Point(firstPoi.X, firstPoi.Y - Cake);
                     ArryPoi[2] = new Point(firstPoi.X + Cake, firstPoi.Y - Cake);
                     ArryPoi[3] = new Point(firstPoi.X - Cake, firstPoi.Y);
                     ConColor = Color.Blue;
                     Convertor = 12;
                     break;
                case 5://组合“T”方块
                     ArryPoi[1] = new Point(firstPoi.X, firstPoi.Y - Cake);
                     ArryPoi[2] = new Point(firstPoi.X + Cake, firstPoi.Y - Cake);
                     ArryPoi[3] = new Point(firstPoi.X - Cake, firstPoi.Y - Cake);
                     ConColor = Color.Silver;
                     Convertor = 14;
                     break;
                case 6://组合“一”方块
                     ArryPoi[1] = new Point(firstPoi.X + Cake, firstPoi.Y);
                     ArryPoi[2] = new Point(firstPoi.X - Cake, firstPoi.Y);
                     ArryPoi[3] = new Point(firstPoi.X - Cake * 2, firstPoi.Y);
                     ConColor = Color.Red;
                     Convertor = 18;
                     break;
                case 7://组合“田”方块
                     ArryPoi[1] = new Point(firstPoi.X - Cake, firstPoi.Y);
                     ArryPoi[2] = new Point(firstPoi.X - Cake, firstPoi.Y - Cake);
                     ArryPoi[3] = new Point(firstPoi.X, firstPoi.Y - Cake);
                     ConColor = Color.LightGreen;
                     Convertor = 19;
                     break;
                default:
                    break;
            }
        }

        public void ConvertorClear()
        {
            if(Mycontrol!=null)
            {
                Graphics g = Mycontrol.CreateGraphics();
                Rectangle rect = new Rectangle(0, 0, Mycontrol.Width, Mycontrol.Height);
                MyPaint(g, new SolidBrush(Color.Black), rect);
            }
        }

        public void MyPaint(Graphics g,Brush colorBrush,Rectangle rect)
        {
            g.FillRectangle(colorBrush, rect);
        }
        //1,随机产生方块
        public void CreateCake()
        {
            Random rd = new Random();
            int n = rd.Next();
        }
    }
    //生成小方块
    public class SmallCake
    {
        public Point point { get; set; }
        public const int cake = 20;
        public SmallCake(Graphics g)
        {

        }
    }
}
