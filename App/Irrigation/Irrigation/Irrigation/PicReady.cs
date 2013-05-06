using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Irrigation
{
    class PicReady
    {
        bool _IsOpenL = true;
        public bool IsOpenL
        {
            get { return _IsOpenL;}
            set { _IsOpenL = value; }
        }
        bool _IsOpenB = true;
        public bool IsOpenB
        {
            get { return _IsOpenB;}
            set { _IsOpenB = value; }
        }
        bool _IsOpenT = true;
        public bool IsOpenT
        {
            get { return _IsOpenT; }
            set { _IsOpenT = value; }
        }
        bool _IsOpenR = true;
        public bool IsOpenR
        {
            get { return _IsOpenR; }
            set { _IsOpenR = value; }
        }
        int _FiledNum;
        public int FiledNum
        {
            get { return _FiledNum; }
            set { _FiledNum = value; }
        }
        public PicReady(int Num)
        {
            FiledNum = Num;
            switch (Num)
            {
                case 0: _IsOpenL = false; _IsOpenT = false;
                    break;
                case 1: _IsOpenT = false; _IsOpenR = false;
                    break;
                case 2: _IsOpenB = false; _IsOpenR = false;
                    break;
                case 3: _IsOpenL = false; _IsOpenB = false;
                    break;
                case 4: _IsOpenR = false;
                    break;
                case 5: _IsOpenB = false;
                    break;
                case 6: _IsOpenL = false;
                    break;
                case 7: _IsOpenT = false;
                    break;
                case 8: _IsOpenT = false; _IsOpenB = false;
                    break;
                case 9: _IsOpenL = false; _IsOpenR = false;
                    break;
                case 10:
                    break;
                case 11: _IsOpenL = false; _IsOpenR = false; _IsOpenT = false; _IsOpenB = false;
                    break;   
            }
        }
    }
}
