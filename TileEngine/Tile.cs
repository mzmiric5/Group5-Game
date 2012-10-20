using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.TileEngine
{
	/// <summary>
	/// Represents a single Tile in an area.
	/// </summary>
	class Tile
	{
		private const int NumLayers = 3;

		/// <summary>Index to tile in texture map for each layer.</summary>
		private int[] mLayerTextureIndex;

		public Tile()
		{
			mLayerTextureIndex = new int[NumLayers];
		}
	}
}
