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
			Server.FriendlyFire = false;
		}

		public void OnEndingRoundEvent(EndingRoundEventArgs ev)
		{
			if (ev.IsAllowed)
			{
				if (ev.IsRoundEnded)
				{
					Server.FriendlyFire = true;
				}
			}
		}
	}
}