﻿using IPA;
using UnityEngine;
using IPALogger = IPA.Logging.Logger;

namespace ScoreSaberReplayWatermarkRemove
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        /// <summary>
        /// Called when the plugin is first loaded by IPA (either when the game starts or when the plugin is enabled if it starts disabled).
        /// [Init] methods that use a Constructor or called before regular methods like InitWithConfig.
        /// Only use [Init] with one Constructor.
        /// </summary>
        public void Init(IPALogger logger)
        {
            Instance = this;
            Log = logger;
            Log.Info("ScoreSaberReplayWatermarkRemove initialized.");
        }

        #region BSIPA Config
        //Uncomment to use BSIPA's config
        /*
        [Init]
        public void InitWithConfig(Config conf)
        {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
            Log.Debug("Config loaded");
        }
        */
        #endregion

        [OnStart]
        public void OnApplicationStart()
        {
            Log.Debug("OnApplicationStart");
            new GameObject("ScoreSaberReplayWatermarkRemoveController").AddComponent<ScoreSaberReplayWatermarkRemoveController>();

        }

        [OnExit]
        public void OnApplicationQuit()
        {
            Log.Debug("OnApplicationQuit");

        }
    }
}
