using System;

using Chess.Models;

namespace Chess
{

    internal abstract class ChessFigure
    {
        protected readonly string _currentCoord;

        public ChessFigure(string currentCoord)
        {
            _currentCoord = currentCoord;
        }

        internal abstract bool Move(string nextCoord);

        internal static ChessFigure ConstructByType(FigureType type, string startCoord)
        {
            switch (type)
            {
                case FigureType.QUEEN:  return new Queen(startCoord);
                case FigureType.ROOK:   return new Rook(startCoord);
                case FigureType.KNIGHT: return new Knight(startCoord);
                case FigureType.BISHOP: return new Bishop(startCoord);
                case FigureType.PAWN:   return new Pawn(startCoord);
                case FigureType.KING:   return new King(startCoord);
                default: throw new NotSupportedException();
            }
        }
    }
}
