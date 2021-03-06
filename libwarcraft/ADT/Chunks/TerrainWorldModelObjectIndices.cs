﻿//
//  TerrainWorldModelObjectIndices.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2016 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Collections.Generic;
using System.IO;
using Warcraft.Core.Interfaces;

namespace Warcraft.ADT.Chunks
{
	/// <summary>
	/// MMID Chunk - Contains a list of WMO model indexes
	/// </summary>
	public class TerrainWorldObjectModelIndices : IIFFChunk, IBinarySerializable
	{
		public const string Signature = "MWID";

		/// <summary>
		/// List indexes for WMO models in an MWMO chunk
		/// </summary>
		public List<uint> WorldModelObjectFilenameOffsets = new List<uint>();

		public TerrainWorldObjectModelIndices()
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Warcraft.ADT.Chunks.TerrainWorldObjectModelIndices"/> class.
		/// </summary>
		/// <param name="inData">ExtendedData.</param>
		public TerrainWorldObjectModelIndices(byte[] inData)
		{
			LoadBinaryData(inData);
		}

		public void LoadBinaryData(byte[] inData)
        {
        	using (MemoryStream ms = new MemoryStream(inData))
			{
				using (BinaryReader br = new BinaryReader(ms))
				{
					int offsetCount = inData.Length / 4;
					for (int i = 0; i < offsetCount; ++i)
					{
						this.WorldModelObjectFilenameOffsets.Add(br.ReadUInt32());
					}
				}
			}
        }

        public string GetSignature()
        {
        	return Signature;
        }

		public byte[] Serialize()
		{
			using (MemoryStream ms = new MemoryStream())
            {
            	using (BinaryWriter bw = new BinaryWriter(ms))
            	{
		            foreach (uint filenameOffset in this.WorldModelObjectFilenameOffsets)
		            {
			            bw.Write(filenameOffset);
		            }
            	}

            	return ms.ToArray();
            }
		}
	}
}

