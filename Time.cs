using PineappleMod.Console;

namespace Time
{
    public class Set : Command
    {
        public override int RequiredArgs => 1;

        public override string Namespace => "Time";
        public override bool Enabled => NetworkSystem.Instance.GameModeString.Contains("MODDED_");
        public override string GetCommandName() => "set";
        public override string GetOutput()
        {
            return "Set time";
        }

        public override void OnExecute(string[] args)
        {
            var manager = BetterDayNightManager.instance;
            string timeString = args[0].ToLower();

            switch (timeString) {
                case "day":
                    manager.SetTimeOfDay(3);
                    manager.currentTimeIndex = 3;
                    break;
                case "night":
                    manager.SetTimeOfDay(0);
                    manager.currentTimeIndex = 0;
                    break;
                case "evening":
                    manager.SetTimeOfDay(7);
                    manager.currentTimeIndex = 7;
                    break;
            }
        }
    }
}
