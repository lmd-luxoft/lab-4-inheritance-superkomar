namespace Chess.Models
{
    internal class Pawn : ChessFigure
    {
        public Pawn(GameCoord coord)
            : base(coord)
        { }

        internal override bool Move(string nextCoordStr)
        {
            var nextCoord = new GameCoord(nextCoordStr);
            return nextCoord.Col == _currentCoord.Col && nextCoord.Row > _currentCoord.Row
                && (nextCoord.Row - _currentCoord.Row == 1 || _currentCoord.Row == '2' && nextCoord.Row == '4');
        }
    }
}
