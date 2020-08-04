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
			if (!AutoFFToggleRef.Config.IsEnabled)
				{
					Log.Info("AutoFFToggle Disabled");
					return;
				}

			Handler = new EventHandler(this);
			Exiled.Events.Handlers.Server.RoundStarted += Handler.OnRoundStartEvent;
			Exiled.Events.Handlers.Server.EndingRound += Handler.OnEndingRoundEvent;
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