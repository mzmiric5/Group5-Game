using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.TileEngine
{
	/// <summary>
	/// Represents a playable area, a grid of tiles and objects.
	/// </summary>
    class Area
    {
		private int mWidth;
		private int mHeight;
		private Tile[,] mTiles;

		public Area(int width, int height)
		{
			mWidth = width;
			mHeight = height;
			mTiles = new Tile[width, height];
		}

		public Tile[,] Tiles
		{
			get { return mTiles; }
		}
    }
}
