using System;

namespace Chess.Models
{
    public class GameCoord
    {
        public const int MinCol = 'A';
        public const int MinRow = '1';
        public const int MaxCol = 'H';
        public const int MaxRow = 'H';

        public GameCoord(string coord)
        {
            Col = coord[0];
            Row = coord[1];

            if (Col < MinCol || Col > MaxCol ||
                Row < MinRow || Row > MaxRow)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int Col { get; }

        public int Row { get; }
    }
}
