﻿//
//  ColourSource.cs
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

namespace Warcraft.Core.Shading.Blending
{
	/// <summary>
	/// Different algorithms to use for source RGB blending factors.
	/// The given values are taken from OpenGL for ease of use.
	/// </summary>
	public enum ColourSource
	{
		One								= 1,
		SourceAlpha						= 770,
		OneMinusSourceAlpha				= 771,
		DestinationColour				= 774,
		OneMinusDestionationColour		= 775,
		ConstantAlpha					= 32771
	}
}