namespace Chess.Models
{
    internal class Pawn : ChessFigure
    {
        public Pawn(string coord)
            : base(coord)
        { }

        internal override bool Move(string nextCoord)
        {
            return nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8'
                ? nextCoord[0] == _currentCoord[0] && nextCoord[1] > _currentCoord[1] &&
                    (nextCoord[1] - _currentCoord[1] == 1 || _currentCoord[1] == '2' && nextCoord[1] == '4')
                : false;
        }
    }
}
