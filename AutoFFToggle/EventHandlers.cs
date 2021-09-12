using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace AutoFFToggle
{
    public class EventHandler
	{
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