using KSL.API;

namespace StreamerMod {
    public interface IConfigData {
        bool Enabled { get; set; }
    }

    public static class Config {
        public static IConfigData Data { get; private set; }

        public static bool Init() {
            Data = Kino.Config
                .RegisterConfig<IConfigData>();

            if (Data == null) {
                return false;
            }

            EnsureDefaultValues();

            return true;
        }

        public static void Save() {
            Kino.Config.Save<IConfigData>();
        }

        private static void EnsureDefaultValues() { }
    }
}
