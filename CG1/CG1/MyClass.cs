using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class MyClass
    {
        public void Draw(Graphics g)
        {

            int x1 = 100;
            int x2 = 400;
            int y = 230;
            int width1 = 150;
            int width2 = 120;
            int height1 = 150;
            int height2 = 120;
            g.DrawEllipse(Pens.Black, new Rectangle(x1, y, width1, height1));
            g.DrawEllipse(Pens.Black, new Rectangle(x2, y, width1, height1));
            g.DrawEllipse(Pens.Black, new Rectangle(115, 245, width2, height2));
            g.DrawEllipse(Pens.Black, new Rectangle(415, 245, width2, height2));
            g.DrawEllipse(Pens.Black, new Rectangle(340, 320, 33, 33));
            g.DrawEllipse(Pens.Black, new Rectangle(343, 323, 27, 27));
            g.DrawEllipse(Pens.Black, new Rectangle(461, 293, 25, 25));
            g.DrawLine(Pens.Black,
               new Point(155, 248), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(175, 245), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(196, 248), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(213, 259), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(224, 270), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(233, 289), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(235, 311), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(220, 346), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(231, 329), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(207, 356), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(191, 362), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(173, 365), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(150, 360), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(131, 346), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(121, 329), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(115, 303), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(119, 282), new Point(173, 306));
            g.DrawLine(Pens.Black,
                new Point(129, 266), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(141, 257), new Point(173, 306));
            g.DrawLine(Pens.Black,
               new Point(455, 248), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(475, 245), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(496, 248), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(513, 259), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(524, 270), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(533, 289), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(535, 311), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(520, 346), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(531, 329), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(507, 356), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(491, 362), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(473, 365), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(450, 360), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(431, 346), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(421, 329), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(415, 303), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(419, 282), new Point(473, 306));
            g.DrawLine(Pens.Black,
                new Point(429, 266), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(441, 257), new Point(473, 306));
            g.DrawLine(Pens.Black,
               new Point(363, 353), new Point(477, 319));
            g.DrawLine(Pens.Black,
               new Point(363, 353), new Point(465, 315));
            // Дуга над колесом
            Pen blackPen = new Pen(Color.Black, 1);
            Rectangle rect = new Rectangle(108, 220, 145, 140);
            g.DrawArc(blackPen, rect, 245, 100);
            Pen blackPen1 = new Pen(Color.Black, 1);
            Rectangle rect1 = new Rectangle(400, 220, 145, 140);
            g.DrawArc(blackPen, rect1, 210, 100);
            g.DrawLine(Pens.Black,
               new Point(250, 271), new Point(243, 272));
            g.DrawLine(Pens.Black,
               new Point(150, 228), new Point(154, 234));
            g.DrawLine(Pens.Black,
               new Point(519, 236), new Point(515, 242));
            g.DrawLine(Pens.Black,
               new Point(410, 254), new Point(415, 258));
            Pen blackPen2 = new Pen(Color.Black, 2);
            Point point1 = new Point(369, 326);
            Point point2 = new Point(472, 305);
            Point point3 = new Point(372, 329);
            Point point4 = new Point(469, 309);
            Point point5 = new Point(175, 302);
            Point point6 = new Point(194, 276);
            Point point7 = new Point(181, 305);
            Point point8 = new Point(199, 284);
            Point point9 = new Point(238, 113);
            Point point10 = new Point(244, 115);
            Point point11 = new Point(222, 204);
            Point point12 = new Point(343, 327);
            Point point13 = new Point(223, 197);
            Point point14 = new Point(346, 324);
            Point point15 = new Point(354, 320);
            Point point16 = new Point(392, 173);
            Point point17 = new Point(360, 320);
            Point point18 = new Point(396, 173);
            Point point19 = new Point(462, 300);
            Point point20 = new Point(383, 232);
            Point point21 = new Point(465, 297);
            Point point22 = new Point(384, 227);
            Point point23 = new Point(361, 291);
            Point point24 = new Point(229, 169);
            Point point25 = new Point(364, 286);
            Point point26 = new Point(231, 165);
            g.DrawLine(blackPen2, point1, point2);
            g.DrawLine(blackPen2, point3, point4);
            g.DrawLine(blackPen2, point5, point6);
            g.DrawLine(blackPen2, point7, point8);
            g.DrawLine(blackPen2, point6, point9);
            g.DrawLine(blackPen2, point8, point10);
            g.DrawLine(blackPen2, point11, point12);
            g.DrawLine(blackPen2, point13, point14);
            g.DrawLine(blackPen2, point15, point16);
            g.DrawLine(blackPen2, point17, point18);
            g.DrawLine(blackPen2, point19, point20);
            g.DrawLine(blackPen2, point21, point22);
            g.DrawLine(blackPen2, point23, point24);
            g.DrawLine(blackPen2, point25, point26);
            //сиденье
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            Pen blackPen3 = new Pen(Color.Black, 3);
            Point point27 = new Point(361, 157);
            Point point28 = new Point(409, 183);
            Point point29 = new Point(415, 158);
            Point[] curvePoints =
             {
                 point27,
                 point28,
                 point29
             };
            g.DrawPolygon(blackPen3, curvePoints);
            g.FillPolygon(brownBrush, curvePoints);
            //педаль
            Pen blackPen4 = new Pen(Color.Black, 4);
            Point point30 = new Point(356, 344);
            Point point31 = new Point(362, 360);
            g.DrawLine(blackPen4, point30, point31);
            g.DrawRectangle(blackPen, 354, 360, 15, 7);
            //руль
            Point point32 = new Point(232, 91);
            Point point33 = new Point(276, 101);
            g.DrawLine(blackPen3, point9, point32);
            g.DrawLine(blackPen3, point10, point33);
            Point point34 = new Point(217, 91);
            Point point35 = new Point(293, 101);
            g.DrawLine(blackPen3, point34, point32);
            g.DrawLine(blackPen3, point35, point33);
            Pen greenPen = new Pen(Color.Green, 3);
            Point point36 = new Point(237, 107);
            Point point37 = new Point(227, 116);
            Point point38 = new Point(226, 122);
            Point point39 = new Point(227, 133);
            Point point40 = new Point(220, 138);
            Point point41 = new Point(221, 147);
            Point point42 = new Point(224, 162);
            Point[] curvePoints2 = { point36, point37, point38, point39, point40, point41, point41 };
            g.DrawCurve(greenPen, curvePoints2);
            Font font1 = new Font("Calibri", 14);
            SolidBrush brush1 = new SolidBrush(Color.Black);
            g.DrawString("Велосипед после дтп", font1, brush1, 20, 10);
            //Font font2 = new Font("Arial", 18);
            //SolidBrush brush2 = new SolidBrush(Color.Black);
            //g.DrawString("Я люблю фкн", font2, brush2, 50, 50);
            //Font font3 = new Font("Courier New", 12);
            //SolidBrush brush3 = new SolidBrush(Color.Black);
            //g.DrawString("Я изобрела велосипед", font3, brush3, 220, 20);

        }
    }
}
