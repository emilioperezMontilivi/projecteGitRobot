using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjecteRobot
{
    class JocRobot
    {
        Point cap;
        DireccioRobot direccio;

        public DireccioRobot Direccio { get => direccio; set => direccio = value; }
        public Point Cap { get => cap; set => cap = value; }

        public JocRobot()
        {
            cap = new Point(0, 0);
            direccio = DireccioRobot.Sud;
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
