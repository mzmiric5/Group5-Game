using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.TileEngine
{
	/// <summary>
	/// Represents a playable area, a grid of tiles and objects.
	/// </summary>
    public class Area
    {
		private int mWidth;
		private int mHeight;
		private Tile[,] mTiles;

        private int index;

		public Area(int new_index, int width, int height)
		{
            this.index = new_index;

            mWidth = width;
			mHeight = height;
			mTiles = new Tile[width, height];
		}

        public Area(int new_index)
            : this(new_index, 100, 100)
        {
        }

		public Tile[,] Tiles
		{
			get { return mTiles; }
		}

        public int get_index()
        {
            return this.index;
        }

        public void set_index(int new_index)
        {
            this.index = new_index;
        }
    }
}
