using System;

namespace Chess.Models
{
    internal class Bishop : ChessFigure
    {
        public Bishop(GameCoord coord)
            : base(coord)
        { }

        internal override bool Move(string nextCoordStr)
        {
            var nextCoord = new GameCoord(nextCoordStr);
            return Math.Abs(nextCoord.Col - _currentCoord.Col)
                == Math.Abs(nextCoord.Row - _currentCoord.Row);
        }
    }

}
