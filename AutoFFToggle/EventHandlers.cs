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
			foreach(Player Ply in Player.List)
			{
				Ply.IsFriendlyFireEnabled = false;
			}
		}

		public void OnEndingRoundEvent(EndingRoundEventArgs ev)
		{
			if (ev.IsAllowed && ev.IsRoundEnded)
			{
				foreach (Player Ply in Player.List)
				{
					Ply.IsFriendlyFireEnabled = true;
				}
			}
		}
	}
}