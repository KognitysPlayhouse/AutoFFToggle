using System;
using EXILED;

namespace AutoFFToggle
{
    public class AutoFFToggle : EXILED.Plugin
    {
        public EventHandlers eh;
        public override string getName => "AutoFFToggle by Kognity";

        public override void OnDisable()
        {
			if (!Configs.PluginOn)
			{
				return;
			}


			Events.WaitingForPlayersEvent -= eh.onRoundStart;
            Events.RoundEndEvent -= eh.onRoundEnd;
            eh = null;
        }

        public override void OnEnable()
        {
			Configs.Reload();

			if (!Configs.PluginOn)
			{
				Log.Info("AutoFFToggle Disabled");
				return;
			}

			eh = new EventHandlers();
            Events.WaitingForPlayersEvent += eh.onRoundStart;
            Events.RoundEndEvent += eh.onRoundEnd;
			Log.Info("AutoFFToggle enabled");
		}

        public override void OnReload()
        {
            
        }
    }
}
