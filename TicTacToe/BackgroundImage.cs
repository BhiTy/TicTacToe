using System;
using System.Windows.Forms;
using TicTacToe.Properties;
using TicTacToe;

namespace ButtonBackgroundImage
{
    public class BackgroundImage
    {
        public static Button Button1;
        public static Button Button2;
        public static Button Button3;
        public static Button Button4;
        public static Button Button5;
        public static Button Button6;
        public static Button Button7;
        public static Button Button8;
        public static Button Button9;

        public BackgroundImage(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            Button1 = button1;
            Button2 = button2;
            Button3 = button3;
            Button4 = button4;
            Button5 = button5;
            Button6 = button6;
            Button7 = button7;
            Button8 = button8;
            Button9 = button9;

        }
    }
    public class ButtonBackground
    {
        public void ChangeButtonBackgroundImage(int iPosition, int[] iData)
        {
            var button1 = BackgroundImage.Button1;
            var button2 = BackgroundImage.Button2;
            var button3 = BackgroundImage.Button3;
            var button4 = BackgroundImage.Button4;
            var button5 = BackgroundImage.Button5;
            var button6 = BackgroundImage.Button6;
            var button7 = BackgroundImage.Button7;
            var button8 = BackgroundImage.Button8;
            var button9 = BackgroundImage.Button9;

            if (iData[iPosition] == -1)
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = Resources.Cross; break;
                    case (1): button2.BackgroundImage = Resources.Cross; break;
                    case (2): button3.BackgroundImage = Resources.Cross; break;
                    case (3): button4.BackgroundImage = Resources.Cross; break;
                    case (4): button5.BackgroundImage = Resources.Cross; break;
                    case (5): button6.BackgroundImage = Resources.Cross; break;
                    case (6): button7.BackgroundImage = Resources.Cross; break;
                    case (7): button8.BackgroundImage = Resources.Cross; break;
                    case (8): button9.BackgroundImage = Resources.Cross; break;
                }
            }
            else if (iData[iPosition] == 1)
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = Resources.Circle; break;
                    case (1): button2.BackgroundImage = Resources.Circle; break;
                    case (2): button3.BackgroundImage = Resources.Circle; break;
                    case (3): button4.BackgroundImage = Resources.Circle; break;
                    case (4): button5.BackgroundImage = Resources.Circle; break;
                    case (5): button6.BackgroundImage = Resources.Circle; break;
                    case (6): button7.BackgroundImage = Resources.Circle; break;
                    case (7): button8.BackgroundImage = Resources.Circle; break;
                    case (8): button9.BackgroundImage = Resources.Circle; break;
                }
            }
            else
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = null; break;
                    case (1): button2.BackgroundImage = null; break;
                    case (2): button3.BackgroundImage = null; break;
                    case (3): button4.BackgroundImage = null; break;
                    case (4): button5.BackgroundImage = null; break;
                    case (5): button6.BackgroundImage = null; break;
                    case (6): button7.BackgroundImage = null; break;
                    case (7): button8.BackgroundImage = null; break;
                    case (8): button9.BackgroundImage = null; break;
                }
            }
        }
    }
}
