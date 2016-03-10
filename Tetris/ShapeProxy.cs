﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeProxy: IShape, IShapeFactory
    {
        private static Random rnd;
        private IShape current;
        private IBoard board;

        public ShapeProxy(IBoard board)
        {
            this.board = board;
            
        }

        public void DeployNewShape()
        {
            int shape = rnd.Next(0, 7);

            switch (shape)
            {
                case 0: 
                    current = new ShapeI(board);
                    onJoinPile(current);
                    break;
                case 1:
                    current = new ShapeJ(board);
                    onJoinPile(current);
                    break;
                case 2:
                    current = new ShapeL(board);
                    onJoinPile(current);
                    break;
                case 3:
                    current = new ShapeO(board);
                    onJoinPile(current);
                    break;
                case 4:
                    current = new ShapeS(board);
                    onJoinPile(current);
                    break;
                case 5:
                    current = new ShapeT(board);
                    onJoinPile(current);
                    break;
                case 6:
                    current = new ShapeZ(board);
                    onJoinPile(current);
                    break;
            }
        }

        public int Length
        {
            get { return current.Length; }
        }

        public Block this[int i]
        {
            get { return current[i]; }
        }

        public event JoinPileHandler JoinPile;
        protected virtual void onJoinPile(IShape current)
        {
            if (JoinPile != null)
            {
                JoinPile(current);
            }
        }

        public void MoveLeft()
        {
            for (int i = 0; i < current.Length; i++)
            {
                current[i].MoveLeft();
            }
        }

        public void MoveRight()
        {
            for (int i = 0; i < current.Length; i++)
            {
                current[i].MoveRight();
            }
        }

        public void MoveDown()
        {
            for (int i = 0; i < current.Length; i++)
            {
                current[i].MoveDown();
            }
        }

        public void Drop()
        {
            current.Drop();
        }

        public void Rotate()
        {
            current.Rotate();
        }

        public void Reset()
        {
            current.Reset();
        }
    }
}
