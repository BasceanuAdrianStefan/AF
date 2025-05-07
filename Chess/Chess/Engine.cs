using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    internal class Engine
    {
        public byte[,] tabla = new byte[8,8];
        public Dictionary<byte, string> PieceCode;
        public static string PozInitialAlb = "WR WN WB WQ WK WB WN WR WP WP WP WP WP WP WP WP";
        public static string PozIntialNegru = "BR BN BB BQ BK BB BN BR BP BP BP BP BP BP BP BP";

        public Engine()
        {
            PieceCode = new Dictionary<byte, string>
            {
                { Piece.WPawn, "WP" },
                { Piece.WKnight, "WN" },
                { Piece.WBishop, "WB" },
                { Piece.WRook, "WR" },
                { Piece.WQueen, "WQ" },
                { Piece.WKing, "WK" },
                { Piece.BPawn, "BK" },
                { Piece.BKnight, "BN" },
                { Piece.BBishop, "BB" },
                { Piece.BRook, "BR" },
                { Piece.BQueen, "BQ" },
                { Piece.BKing, "BK" }
            };

        }

    }
}
