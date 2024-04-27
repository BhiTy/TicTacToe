using System;
using TicTacToe;
using ButtonBackgroundImage;
using System.Runtime.InteropServices.ComTypes;

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

            //0 = Легко, 1 = Средне, 2 = Сложно
            if (iType == 0)
            {
                RunEasyBot(iType, iLastMove, iData, iTurn, bEnableBot);
            }
            else if (iType == 1)
            {
                RunMediumBot(iType, iLastMove, iData, iTurn, bEnableBot);
            }
            else if (iType == 2)
            {
                RunHardBot(iType, iLastMove, iData, iTurn, bEnableBot);
            }
        }

        void RunEasyBot(int iType, int iLastMove, int[] iData, int iTurn, bool bEnableBot)
        {
            iLastMove = RandomPosition(iData);
            iData[iLastMove] = iTurn;
            form.Game(iType, iLastMove, iData);
            bEnableBot = false;
            form.SetNextTurn();
        }

        void RunMediumBot(int iType, int iLastMove, int[] iData, int iTurn, bool bEnableBot)
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
            form.Game(iType, iLastMove, iData);
            bEnableBot = false;
            form.SetNextTurn();
        }

        void RunHardBot(int iType, int iLastMove, int[] iData, int iTurn, bool bEnableBot)
        {
            int opponentType = (iTurn == -1) ? 1 : -1;

            if (iLastMove == -1)
            {
                // Если это первый ход, ставим в центр
                if (iData[4] == 0)
                {
                    iLastMove = 4;
                }
            }
            else if (iData[iLastMove] != 0)
            {
                // Если последний ход не пустой
                form.CheckWinAndDontLose(opponentType); // Проверяем на не проигрыш
                form.CheckWinAndDontLose(iType);   // Проверяем на выигрыш

                if (iData[iLastMove] != 0)
                {
                    if (iLastMove == 4)
                    {
                        // Последний ход был в центре
                        // Ставим в угол
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
                        else
                        {
                            iLastMove = RandomPosition(iData);
                        }
                    }
                    else if (iLastMove == 0 || iLastMove == 2 || iLastMove == 6 || iLastMove == 8)
                    {
                        // Последний ход был в углу
                        // Ставим в центр, если доступно
                        if (iData[4] == 0)
                        {
                            iLastMove = 4;
                        }
                        // Ставим в противоположный угол, если возможно
                        else if (iData[0] == 0 && iData[8] == opponentType)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && iData[6] == opponentType)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && iData[2] == opponentType)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && iData[0] == opponentType)
                        {
                            iLastMove = 8;
                        }
                        else if ((iData[0] == opponentType && iData[8] == opponentType) || (iData[2] == opponentType && iData[6] == opponentType))
                        {
                            // Ставим в край, если противоположные углы заняты противником
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
                        else
                        {
                            // Ставим в любой доступный угол
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
                            else
                            {
                                iLastMove = RandomPosition(iData);
                            }
                        }
                    }
                    else if (iLastMove == 1 || iLastMove == 3 || iLastMove == 5 || iLastMove == 7)
                    {
                        // Последний ход был на краю
                        // Ставим в центр, если доступно
                        if (iData[4] == 0)
                        {
                            iLastMove = 4;
                        }
                        // Ставим в угол, если край занят противником
                        else if (iData[0] == 0 && iData[1] == opponentType && iData[3] == opponentType)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && iData[1] == opponentType && iData[5] == opponentType)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && iData[3] == opponentType && iData[7] == opponentType)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && iData[5] == opponentType && iData[7] == opponentType)
                        {
                            iLastMove = 8;
                        }
                        // Ставим в угол рядом с краем, если доступно
                        else if (iData[0] == 0 && ((iData[1] == opponentType) || (iData[3] == opponentType)))
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && ((iData[1] == opponentType) || (iData[5] == opponentType)))
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && ((iData[3] == opponentType) || (iData[7] == opponentType)))
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && ((iData[5] == opponentType) || (iData[7] == opponentType)))
                        {
                            iLastMove = 8;
                        }
                        else
                        {
                            // Ставим в любой доступный край
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
                            else
                            {
                                iLastMove = RandomPosition(iData);
                            }
                        }
                    }
                }
            }

            iData[iLastMove] = iTurn;
            form.Game(iType, iLastMove, iData);
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