using System.Reflection;

using KSL.API;

using UnityEngine;

namespace StreamerMod {
    [KSLMeta("StreamerMod", "0.0.1", "Elron_MacBong")]
    public class StreamerMod : BaseMod {
        private void Start() {
            Kino.Log.Info("StreamerMod started!");

            bool cfgRes = Config.Init();
            Kino.Log.Info($"Config initialization result: {cfgRes}");
        }

        public override Texture2D GetIcon() {
            Assembly assembly = Assembly.GetExecutingAssembly();

            return Kino.Utils.LoadEmbeddedTexture(assembly, "StreamerMod.Resources.adler.png");
        }

        public override void OnUIDraw() {
            Kino.UI.Label("Welcome to StreamerMod");
            if (Kino.UI.Button("Press me")) {
                Kino.Log.Info("Pressed");
            }
        }

        public override void OnAdditionalAboutUIDraw() {
            Kino.UI.Label("Additional about info...");
            Kino.UI.HyperlinkLabel("Visit our<link>", "discord", "https://discord.gg/");
        }
    }
}
