using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.TileEngine
{
	/// <summary>
	/// Represents a single Tile in an area.
	/// </summary>
	public class Tile
	{
		private const int NumLayers = 3;

		/// <summary>Index to tile in texture map for each layer.</summary>
		private int[] mLayerTextureIndex;

		/// <summary>Type and associated general logic for the tile.</summary>
		private TileType mType;

		public Tile()
		{
			mLayerTextureIndex = new int[NumLayers];
		}

		/// <summary>
		/// Gets the indicies of all the layered textures.
		/// </summary>
		public int[] LayerTextureIndex
		{
			get { return mLayerTextureIndex; }
		}

		/// <summary>
		/// Gets or sets the type and general logic of the tile.
		/// </summary>
		public TileType Type
		{
			get { return mType; }
			set { mType = value; }
		}
	}
}
