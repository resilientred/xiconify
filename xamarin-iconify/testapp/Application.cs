﻿using System;
using Android.App;

namespace testapp
{
	[Android.App.Application]
	public class Application:Android.App.Application
	{
		public Application () : base ()
		{
		}

		public Application (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();
			JoanZapata.XamarinIconify.Iconify
				.with (new JoanZapata.XamarinIconify.Fonts.EntypoModule ())
				.with (new JoanZapata.XamarinIconify.Fonts.FontAwesomeModule ())
				;
		}
	}
}

