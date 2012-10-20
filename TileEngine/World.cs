using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.TileEngine
{
	/// <summary>
	/// Represents a world containing loadable areas.
	/// </summary>
	class World
	{
		private List<Area> mAreas;

		public List<Area> Areas
		{
			get { return mAreas; }
		}
	}
}
