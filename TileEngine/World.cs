using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.TileEngine
{
	/// <summary>
	/// Represents a world containing loadable areas.
	/// </summary>
	public class World
	{
		private Dictionary<int, Area> mAreas;

        private int tile_size = 32;

        public World()
        {
            this.mAreas = new Dictionary<int, Area>();
        }

        public World(int new_tile_size)
            : this()
        {
            this.set_tile_size(new_tile_size);
        }

        public Dictionary<int, Area> Areas
		{
			get { return mAreas; }
		}

        public int get_tile_size()
        {
            return this.tile_size;
        }

        public void set_tile_size(int new_tile_size)
        {
            this.tile_size = new_tile_size;
        }
	}
}
