﻿
namespace AriaPlugin.Runtime.iTweenHelper
{
	public class ValueTo_Double : ValueTo<double> 
	{
		protected override void Reset()
		{
			base.Reset();

			from = 0;
			to = 1;
			onupdate = "SetDouble";
		}
	}
}