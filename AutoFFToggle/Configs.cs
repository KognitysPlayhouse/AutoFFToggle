using System;
using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace AutoFFToggle
{
	public sealed class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;
	}
}