using System;

namespace Chess.Models
{
    internal class Knight : ChessFigure
    {
        public Knight(GameCoord coord)
            : base(coord)
        { }

        internal override bool Move(string nextCoordStr)
        {
            var nextCoord = new GameCoord(nextCoordStr);
            return Math.Abs(nextCoord.Col - _currentCoord.Col) == 1 && Math.Abs(nextCoord.Row - _currentCoord.Row) == 2
                || Math.Abs(nextCoord.Col - _currentCoord.Col) == 2 && Math.Abs(nextCoord.Row - _currentCoord.Row) == 1;
        }
    }
}
