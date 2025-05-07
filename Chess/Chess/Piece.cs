using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {
        public const byte liber = 0;
        public const byte WPawn = 1;
        public const byte WKnight = 2;
        public const byte WBishop = 3;
        public const byte WRook = 4;
        public const byte WKing = 5;
        public const byte WQueen = 6;
        public const byte BPawn = 11;
        public const byte BKnight = 12;
        public const byte BBishop = 13;
        public const byte BRook = 14;
        public const byte BKing = 15;
        public const byte BQueen = 16;

        public static readonly Dictionary<byte, Image> Images = new Dictionary<byte, Image>
        {
            { WPawn, Image.FromFile(@"../../Images/WP.png")},
            { WKnight,Image.FromFile(@"../../Images/WN.png") },
            { WBishop, Image.FromFile(@"../../Images/WB.png") },
            { WRook,Image.FromFile(@"../../Images/WR.png") },
            { WQueen, Image.FromFile(@"../../Images/WQ.png") },
            { WKing, Image.FromFile(@"../../Images/WK.png") },
            { BPawn, Image.FromFile(@"../../Images/BP.png") },
            { BKnight, Image.FromFile(@"../../Images/BN.png") },
            { BBishop, Image.FromFile(@"../../Images/BB.png") },
            { BRook, Image.FromFile(@"../../Images/BR.png") },
            { BQueen, Image.FromFile(@"../../Images/BQ.png") },
            { BKing, Image.FromFile(@"../../Images/BK.png") }
        };
    }
}
