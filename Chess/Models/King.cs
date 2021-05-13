using System;

namespace Chess.Models
{
    internal class King : ChessFigure
    {
        public King(GameCoord coord)
            : base(coord)
        { }

        internal override bool Move(string nextCoordStr)
        {
            var nextCoord = new GameCoord(nextCoordStr);
            return Math.Abs(nextCoord.Col - _currentCoord.Col) <= 1
                && Math.Abs(nextCoord.Row - _currentCoord.Row) <= 1;
        }
    }
}
