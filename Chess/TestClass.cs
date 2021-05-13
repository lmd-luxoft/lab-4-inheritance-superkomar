// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

using Chess.Models;

using NUnit.Framework;

namespace Chess
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        [TestCase("L18")]
        [TestCase("L0")]
        [TestCase("0H")]
        [TestCase("2E")]
        public void FigureWithInvalidCoord(string coord)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ChessFigure.ConstructByType(FigureType.ROOK, coord));
        }

        [Test]
        [TestCase("L18")]
        [TestCase("L0")]
        [TestCase("0H")]
        [TestCase("2E")]
        public void FigureMoveToInvalidCoord(string coord)
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.ROOK, "E2");

            Assert.Throws<ArgumentOutOfRangeException>(() => figure.Move(coord));
        }

        [Test]
        public void RookShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.ROOK, "E2");
            Assert.AreEqual(true,figure.Move("C2"));
        }
        [Test]
        public void RookShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.ROOK, "E2");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KnightShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.KNIGHT, "B1");
            Assert.AreEqual(true,figure.Move("C3"));
        }
        [Test]
        public void KnightShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.KNIGHT, "B1");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void BishopShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.BISHOP, "C1");
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void BishopShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.BISHOP, "C1");
            Assert.AreEqual(false,figure.Move("C3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove0()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.PAWN, "E2");
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove1()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.PAWN, "E2");
            Assert.AreEqual(true,figure.Move("E4"));
        }
        [Test]
        public void PawnShouldBeCorrectMove2()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.PAWN, "E4");
            Assert.AreEqual(true,figure.Move("E5"));
        }   
        [Test]
        public void PawnShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.PAWN, "E2");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KingShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.KING, "E1");
            Assert.AreEqual(true,figure.Move("E2"));
        }
        [Test]
        public void KingShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.KING, "E1");
            Assert.AreEqual(false,figure.Move("E8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveVertical()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.QUEEN, "D1");
            Assert.AreEqual(true,figure.Move("D8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveDiagonal()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.QUEEN, "D1");
            Assert.AreEqual(true,figure.Move("H5"));
        }
        [Test]
        public void QueenShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigure.ConstructByType(FigureType.QUEEN, "D1");
            Assert.AreEqual(false,figure.Move("E3"));
        }
    }
}
