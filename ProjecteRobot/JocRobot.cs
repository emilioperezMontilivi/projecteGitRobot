﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjecteRobot
{
    class JocRobot
    {
        public const int WIDTH = 5;
        public const int HEIGHT = 5;
        public int NPOMES = 5;

        Point cap;
        Point tresor;
        DireccioRobot direccio;
        int movimentARealitzar;

        bool dreta = false;
        bool esquerra = false;
        bool abaix = false;


        public DireccioRobot Direccio { get => direccio; set => direccio = value; }
        public Point Cap { get => cap; set => cap = value; }
        public Point Tresor { get => tresor; }


        public JocRobot()
        {
            cap = new Point(0, 0);
            Random r = new Random();

            //direccio = DireccioRobot.Sud;
            var x = r.Next(0, WIDTH - 1);
            var y = r.Next(0, HEIGHT - 1);

            //Distribuir les pomes

            tresor = new Point(x, y);

        }

        public void MoureRobot()
        {
            Random rndMoviment = new Random();

            movimentARealitzar = rndMoviment.Next(1, 101);

            //Direccio cap amun
            //if (direccio == DireccioRobot.Nord)
            if (movimentARealitzar >= 1 && movimentARealitzar <=50)
            {
                if (dreta== true)
                {
                    cap.X++; //moure cap a la dreta
                    dreta = false;
                }
                else if (esquerra == true)
                {
                    cap.X--;
                    esquerra = false;
                }
                else if(abaix == true)
                {
                    cap.Y++;
                    abaix = false;
                }
                else
                {
                    cap.Y--;
                }
            }
            //Direccio dreta
            else if (movimentARealitzar >= 51 && movimentARealitzar <= 75)
            {
                if(dreta == true)
                {
                    abaix = true;
                }
                dreta = true;
                esquerra = false;
            }
            //Direccio esquerra
            else if (movimentARealitzar >= 76 && movimentARealitzar <= 100)
            {
                esquerra = true;
                dreta = false;

            }
        }
    }
    public enum DireccioRobot
    {
        Nord,
        Sud,
        Est,
        Oest
    }
}
