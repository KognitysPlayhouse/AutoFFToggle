using System;
using EXILED;
using EXILED.Extensions;

namespace AutoFFToggle
{
    public class EventHandlers
    {
        public void onRoundStart()
        {
            foreach (ReferenceHub hub in Player.GetHubs())
            {
                hub.SetFriendlyFire(false);
            }
        }

        public void onRoundEnd()
        {
            foreach (ReferenceHub hub in Player.GetHubs())
            {
                hub.SetFriendlyFire(true);
            }
        }
    }
}
