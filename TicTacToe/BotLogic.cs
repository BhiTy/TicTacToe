using System;
using TicTacToe;
using ButtonBackgroundImage;

namespace BotLogics
{
    public partial class BotLogic
    {
        private Form1 form;

        public BotLogic(Form1 form)
        {
            this.form = form;
        }

        public void RunBot(int iType, int iTurn, bool bEnableBot, int iLastMove, int[] iData)
        {
            //4 = Игра против друга, 0 = Игра окончена
            if (iType == 3 || iTurn == 0)
                return;

            bEnableBot = true;
            WaitNSeconds(1);

            //0 = Легко, 1 = Средне, 2 = Невозможно
            if (iType == 0)
            {
                RunEasyBot(iLastMove, iData, iTurn, bEnableBot);
            }
            else if (iType == 1)
            {
                RunMediumBot(iLastMove, iData, iTurn, bEnableBot);
            }
        }

        void RunEasyBot(int iLastMove, int[] iData, int iTurn, bool bEnableBot)
        {
            iLastMove = RandomPosition(iData);
            iData[iLastMove] = iTurn;
            form.Game(iLastMove, iData);
            bEnableBot = false;
            form.SetNextTurn();
        }

        void RunMediumBot(int iLastMove, int[] iData, int iTurn, bool bEnableBot)
        {
            int iOpponent;
            if (iTurn == -1) iOpponent = 1;
            else iOpponent = -1;

            if (iLastMove == -1)
            {
                iLastMove = RandomPosition(iData);
            }
            else
            {
                form.CheckWinAndDontLose(iOpponent); //Проверка на не проигрыш
                form.CheckWinAndDontLose(iTurn); //Проверка на выигрыш
                if (iData[iLastMove] != 0) iLastMove = RandomPosition(iData);
            }

            iData[iLastMove] = iTurn;
            form.Game(iLastMove, iData);
            bEnableBot = false;
            form.SetNextTurn();
        }

        void RunHardBot(int iLastMove, int[] iData, int iTurn, bool bEnableBot)
        {
            int iOpponent;
            //Проверка на победу и не проигрыш
            if (iTurn == -1) iOpponent = 1;
            else iOpponent = -1;

            if (iLastMove == -1)
            {
                //Поставить в центр
                if (iData[4] == 0)
                {
                    iLastMove = 4;
                }
            }
            else if (iData[iLastMove] != 0)
            {
                form.CheckWinAndDontLose(iOpponent); //Проверка на не проигрыш
                form.CheckWinAndDontLose(iTurn); //Проверка на выигрыш
                if (iData[iLastMove] != 0)
                {
                    //Последний ход - центр
                    if (iLastMove == 4)
                    {
                        //Поставить в угол
                        if (iData[0] == 0)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0)
                        {
                            iLastMove = 8;
                        }
                        else iLastMove = RandomPosition(iData);
                    }
                    //Последний ход - угол
                    else if (iLastMove == 0 || iLastMove == 2 || iLastMove == 6 || iLastMove == 8)
                    {
                        //Поставить в центр
                        if (iData[4] == 0)
                        {
                            iLastMove = 4;
                        }
                        //Поставить в противоположный угол
                        else if (iData[0] == 0 && iData[8] == iOpponent)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && iData[6] == iOpponent)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && iData[2] == iOpponent)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && iData[0] == iOpponent)
                        {
                            iLastMove = 8;
                        }
                        //Если противоположные углы являются противниками
                        else if ((iData[0] == iOpponent && iData[8] == iOpponent) || (iData[2] == iOpponent && iData[6] == iOpponent))
                        {
                            //Поставить в край
                            if (iData[1] == 0)
                            {
                                iLastMove = 1;
                            }
                            else if (iData[3] == 0)
                            {
                                iLastMove = 3;
                            }
                            else if (iData[5] == 0)
                            {
                                iLastMove = 5;
                            }
                            else if (iData[7] == 0)
                            {
                                iLastMove = 7;
                            }
                        }
                        //Поставить в угол
                        else if (iData[0] == 0)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0)
                        {
                            iLastMove = 8;
                        }
                        else iLastMove = RandomPosition(iData);
                    }
                    //Последний ход - край
                    else if (iLastMove == 1 || iLastMove == 3 || iLastMove == 5 || iLastMove == 7)
                    {
                        //Поставить на центр
                        if (iData[4] == 0)
                        {
                            iLastMove = 4;
                        }
                        //Поставить в угол если края - противник
                        else if (iData[0] == 0 && iData[1] == iOpponent && iData[3] == iOpponent)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && iData[1] == iOpponent && iData[5] == iOpponent)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && iData[3] == iOpponent && iData[7] == iOpponent)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && iData[5] == iOpponent && iData[7] == iOpponent)
                        {
                            iLastMove = 8;
                        }
                        //Поставить в угол рядом с краем
                        else if (iData[0] == 0 && ((iData[1] == iOpponent) || (iData[3] == iOpponent)))
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && ((iData[1] == iOpponent) || (iData[5] == iOpponent)))
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && ((iData[3] == iOpponent) || (iData[7] == iOpponent)))
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && ((iData[5] == iOpponent) || (iData[7] == iOpponent)))
                        {
                            iLastMove = 8;
                        }
                        //Поставить в край
                        else if (iData[0] == 0)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0)
                        {
                            iLastMove = 8;
                        }
                        //Поставить в край
                        else if (iData[1] == 0)
                        {
                            iLastMove = 1;
                        }
                        else if (iData[3] == 0)
                        {
                            iLastMove = 3;
                        }
                        else if (iData[5] == 0)
                        {
                            iLastMove = 5;
                        }
                        else if (iData[7] == 0)
                        {
                            iLastMove = 7;
                        }
                        else iLastMove = RandomPosition(iData);
                    }
                }

            }

            iData[iLastMove] = iTurn;
            form.Game(iLastMove, iData);
            bEnableBot = false;
            form.SetNextTurn();
        }

        int RandomPosition(int[] iData)
        {
            int Count = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (iData[i] == 0)
                {
                    Count++;
                }
            }
            Random rnd = new Random();
            int iRandom = rnd.Next(1, Count);

            Count = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (iData[i] == 0)
                {
                    Count++;
                    if (Count == iRandom)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        //https://stackoverflow.com/questions/22158278/wait-some-seconds-without-blocking-ui-execution
        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
