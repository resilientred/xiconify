﻿using System.Linq;
using JoanZapata.XamarinIconify;

namespace JoanZapata.XamarinIconify.Fonts
{
	public class FontAwesomeModule : IIconFontDescriptor
	{

		public string FontFileName {
			get {
				return "android-iconify-fontawesome.ttf";
			}
		}

		private readonly ILookup<string, Icon> _characters=EnumToLookup.ToLookup<FontAwesomeIcons>();

		public ILookup<string, Icon> Characters {
			get{ return _characters; }
		}
	}
}