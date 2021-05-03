using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class beanchat
    {

        public static bool whitesMoveRecieved = false;
        public static int channelSet = 1;

        public static string createBoardString(int[,] boardToUse, bool whitesMove)
        {
            string boardString = "";
            if (whitesMove)
            {
                boardString = "w";
            }
            else
            {
                boardString = "b";
            }

            for (int scannerY = 1; scannerY <= 8; scannerY++)
            {
                for (int scannerX = 1; scannerX <= 8; scannerX++)
                {
                    string newVal = boardToUse[scannerX, scannerY].ToString();
                    if (boardToUse[scannerX, scannerY] > 9)
                    {
                        if (boardToUse[scannerX, scannerY] == 10)
                        {
                            newVal = "a";
                        }
                        if (boardToUse[scannerX, scannerY] == 11)
                        {
                            newVal = "b";
                        }
                        if (boardToUse[scannerX, scannerY] == 12)
                        {
                            newVal = "c";
                        }

                    }
                    boardString = boardString + newVal;

                }
            }

            boardString = boardString + "STOP";
            return boardString;
        }

        public static int[,] createBoardFromString(string boardString)
        {
            int[,] internalBoard = new int[9, 9];
            int counter = 0;

            if (boardString[0]=='w')
            {
                whitesMoveRecieved = true;
            }
            else
            {
                whitesMoveRecieved = false;
            }

            for (int scannerY = 1; scannerY <= 8; scannerY++)
            {
                for (int scannerX = 1; scannerX <= 8; scannerX++)
                {
                    counter += 1;

                    string tester = "5555555";
                    
                    Debug.WriteLine(boardString[counter]);

                    switch (boardString[counter])
                    {
                        case '1':
                            internalBoard[scannerX, scannerY] = 1;
                            break;
                        case '2':
                            internalBoard[scannerX, scannerY] = 2;
                            break;
                        case '3':
                            internalBoard[scannerX, scannerY] = 3;
                            break;
                        case '4':
                            internalBoard[scannerX, scannerY] = 4;
                            break;
                        case '5':
                            internalBoard[scannerX, scannerY] = 5;
                            break;
                        case '6':
                            internalBoard[scannerX, scannerY] = 6;
                            break;
                        case '7':
                            internalBoard[scannerX, scannerY] = 7;
                            break;
                        case '8':
                            internalBoard[scannerX, scannerY] = 8;
                            break;
                        case '9':
                            internalBoard[scannerX, scannerY] = 9;
                            break;
                        case 'a':
                            internalBoard[scannerX, scannerY] = 10;
                            break;
                        case 'b':
                            internalBoard[scannerX, scannerY] = 11;
                            break;
                        case 'c':
                            internalBoard[scannerX, scannerY] = 12;
                            break;
                    }


                    }

            }
            return internalBoard;
        }


        public static void send(string sendString, int channel)
        {

            var url1 = "https://api.isaacthoman.me/api/Chess?message=" + sendString + "&channel=" + channel ;

            var httpRequest1 = (HttpWebRequest)WebRequest.Create(url1);
            httpRequest1.Method = "POST";
            httpRequest1.ContentType = "text/plain";
            httpRequest1.Headers["Content-Length"] = "0";
            var httpResponse1 = (HttpWebResponse)httpRequest1.GetResponse();



            using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
            {
                var result = streamReader1.ReadToEnd();
                string myresult = result;
                return;
            }



        }

        public static string recieve(int channel)
        {

            var url = "https://api.isaacthoman.me/api/Chess?channel="+ channel;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();



            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result.Trim('"');
            }


        }

        public static void pushBoard()
        {
            beanchat.send(beanchat.createBoardString(board.boardSquare, Interface.whitesMove), channelSet);

        }

        public static void pullBoard()
        {

            //board.boardSquare = beanchat.createBoardFromString(textBox1.Text);
            string recieved = beanchat.recieve(channelSet);
            board.boardSquare = beanchat.createBoardFromString(recieved);
            Interface.whitesMove = beanchat.whitesMoveRecieved;
        }

    }
}
