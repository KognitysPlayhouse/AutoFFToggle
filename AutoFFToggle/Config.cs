using static EXILED.Plugin;

namespace AutoFFToggle
{
	public static class Configs
	{
		public static bool PluginOn;

		internal static void Reload()
		{
			PluginOn = Config.GetBool("autofft_on", true);
		}
	}
}
