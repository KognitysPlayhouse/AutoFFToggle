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
			//Server.FriendlyFire = false;

			//Server.FriendlyFire = false;

			foreach (Player Ply in Player.List)
			{
				Ply.IsFriendlyFireEnabled = true;
			}



		}

		public void OnEndingRoundEvent(EndingRoundEventArgs ev)
		{
			foreach (Player Ply in Player.List)
			{
				Ply.IsFriendlyFireEnabled = false;
				//Ply.Broadcast(3, "REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
			}
			//Server.FriendlyFire = true;
			//ServerConsole.FriendlyFire = true;

		}
	}
}