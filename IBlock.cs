﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class IBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] { new(0,0), new(0,1), new(0,2), new(0,3) },
            new Position[] { new(0,0), new(1,0), new(2,0), new(3,0) },
            new Position[] { new(0,0), new(0,1), new(0,2), new(0,3) },
            new Position[] { new(0,0), new(1,0), new(2,0), new(3,0) }
        };

        public override int Id => 1;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}
