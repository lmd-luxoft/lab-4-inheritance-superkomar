using System;

namespace Chess.Models
{
    internal class King : ChessFigure
    {
        public King(string coord)
            : base(coord)
        { }

        internal override bool Move(string nextCoord)
        {
            return nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8'
                ? Math.Abs(nextCoord[0] - _currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - _currentCoord[1]) <= 1
                : false;
        }
    }
}
