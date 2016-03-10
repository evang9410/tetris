using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeOTest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // no need since its 2x2
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            // Init
            ShapeO shapeO = new ShapeO(null);
            ShapeO shapeOTest = new ShapeO(null);

            // First rotation
            shapeOTest.blocks[0] = new Block(Color.Yellow, new Point(0, 0), null);
            shapeOTest.blocks[1] = new Block(Color.Yellow, new Point(1, 0), null);
            shapeOTest.blocks[2] = new Block(Color.Yellow, new Point(0, 1), null);
            shapeOTest.blocks[3] = new Block(Color.Yellow, new Point(1, 1), null);

            for (int i = 0; i < shapeO.blocks.Length; i++)
            {
                Assert.AreEqual(shapeOTest.blocks[i].Position, shapeO.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2), null);

            so.MoveLeft();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2), null);

            so.MoveRight();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 1), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 1), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1), null);

            so.MoveRight();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            so.Reset();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

    }
}
