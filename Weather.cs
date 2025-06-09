using PineappleMod.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace Time
{
    public class Weather : Command
    {
        public override string GetCommandName() => "set";
        public override int RequiredArgs => 1;
        public override string Namespace => "Weather";
        public override bool Enabled => NetworkSystem.Instance.GameModeString.Contains("MODDED_");
        public override string GetOutput() => "Set weather";

        public override void OnExecute(string[] args)
        {
            var manager = BetterDayNightManager.instance;
            string weatherString = args[0].ToLower();

            switch (weatherString)
            {
                case "clear":
                    SetWeather(BetterDayNightManager.WeatherType.None);
                    break;
                case "rain":
                    SetWeather(BetterDayNightManager.WeatherType.Raining);
                    break;
            }
        }

        public void SetWeather(BetterDayNightManager.WeatherType type) 
        {
            for (int i = 0; i < BetterDayNightManager.instance.weatherCycle.Length; i++)
            {
                BetterDayNightManager.instance.weatherCycle[i] = type;
            }
        }
    }
}
