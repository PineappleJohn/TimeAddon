using BepInEx;
using Photon.Pun;
using System;
using UnityEngine;

namespace Time
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }

        public void Awake() => Instance = this;
    }

    public class PluginInfo
    {
        internal const string
            GUID = "John.Time",
            Name = "Time Command",
            Version = "1.0.0";
    }
}
