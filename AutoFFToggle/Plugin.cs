using System;
using System.Linq;
using Exiled.API.Features;

namespace AutoFFToggle
{
	public class AutoFFToggle : Plugin<Config>
	{
		public static AutoFFToggle Instance { get; set; }
		public override string Name => nameof(AutoFFToggle);
		public override string Author => "Kognity";

        public override Version Version => new Version(1, 7, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        public EventHandler Handler;

        public AutoFFToggle()
        {
            Instance = this;
        }

		public override void OnEnabled()
		{
			if (Server.FriendlyFire)
			{
				Log.Info("Friendly Fire is already enabled on this server. AutoFFToggle will now be disabled.");
				Config.IsEnabled = false;

                return;
			}

            base.OnEnabled();
			Log.Info("Thank you for installing my plugin <3 - Kognity");

			Handler = new EventHandler();
			Exiled.Events.Handlers.Server.RoundStarted += Handler.OnRoundStartEvent;
			Exiled.Events.Handlers.Server.EndingRound += Handler.OnEndingRoundEvent;
		}

		public override void OnDisabled()
		{
			Exiled.Events.Handlers.Server.RoundStarted -= Handler.OnRoundStartEvent;
			Exiled.Events.Handlers.Server.EndingRound -= Handler.OnEndingRoundEvent;

            base.OnDisabled();
			Handler = null;
		}
	}
}