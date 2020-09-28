using System;
using System.Linq;
using Exiled.API.Features;
using UnityEngine;

namespace AutoFFToggle
{
	public class AutoFFToggle : Plugin<Config>
	{

		public static AutoFFToggle AutoFFToggleRef { get; private set; }
		public override string Name => nameof(AutoFFToggle);
		public override string Author => "Kognity";
		public EventHandler Handler;

		public AutoFFToggle()
		{
			AutoFFToggleRef = this;
		}

		public override void OnEnabled()
		{
			if (Server.FriendlyFire)
			{
				Log.Info("Friendly Fire is already enabled on this server. AutoFFToggle will now be disabled.");
				Config.IsEnabled = false;
			}
			else
			{
				Log.Info("AutoFFToggle Plugin Enabled!");
				Log.Info("Thank you for installing my plugin <3 - Kognity");
				Handler = new EventHandler(this);
				Exiled.Events.Handlers.Server.RoundStarted += Handler.OnRoundStartEvent;
				Exiled.Events.Handlers.Server.EndingRound += Handler.OnEndingRoundEvent;
			}
		}

		public override void OnDisabled()
		{
			Exiled.Events.Handlers.Server.RoundStarted -= Handler.OnRoundStartEvent;
			Exiled.Events.Handlers.Server.EndingRound -= Handler.OnEndingRoundEvent;
			Handler = null;
		}

		public override void OnReloaded() { }
	}
}