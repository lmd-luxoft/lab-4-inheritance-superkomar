namespace Chess.Models
{
    internal class Rook : ChessFigure
    {
        public Rook(GameCoord coord)
            : base(coord)
        {}

        internal override bool Move(string nextCoordStr)
        {
            var nextCoord = new GameCoord(nextCoordStr);
            return (nextCoord.Col == _currentCoord.Col || nextCoord.Row == _currentCoord.Row)
                && (nextCoord.Col != _currentCoord.Col || nextCoord.Row != _currentCoord.Row);
        }
    }
}
