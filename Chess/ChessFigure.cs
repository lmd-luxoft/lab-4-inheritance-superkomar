using System;

using Chess.Models;

namespace Chess
{

    internal abstract class ChessFigure
    {
        protected readonly GameCoord _currentCoord;

        public ChessFigure(GameCoord currentCoord)
        {
            _currentCoord = currentCoord;
        }

        internal abstract bool Move(string nextCoordStr);

        internal static ChessFigure ConstructByType(FigureType type, string startCoord)
        {
            switch (type)
            {
                case FigureType.QUEEN:  return new Queen(new GameCoord(startCoord));
                case FigureType.ROOK:   return new Rook(new GameCoord(startCoord));
                case FigureType.KNIGHT: return new Knight(new GameCoord(startCoord));
                case FigureType.BISHOP: return new Bishop(new GameCoord(startCoord));
                case FigureType.PAWN:   return new Pawn(new GameCoord(startCoord));
                case FigureType.KING:   return new King(new GameCoord(startCoord));
                default: throw new NotSupportedException();
            }
        }
    }
}
