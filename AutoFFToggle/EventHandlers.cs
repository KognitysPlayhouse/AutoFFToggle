using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;
using System;

namespace AutoFFToggle
{
	public class EventHandler
	{
		public AutoFFToggle plugin;
		public EventHandler(AutoFFToggle plugin) => this.plugin = plugin;

		public void OnRoundStartEvent()
		{
			GameCore.Console.singleton.TypeCommand("/setconfig friendly_fire false");
		}

		public void OnEndingRoundEvent(EndingRoundEventArgs ev)
		{
			if (ev.IsRoundEnded)
			{
				GameCore.Console.singleton.TypeCommand("/setconfig friendly_fire true");
			}
		}
	}
}