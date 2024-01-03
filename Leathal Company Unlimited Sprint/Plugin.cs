using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Lethal_Company_Unlimited_Sprint.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lethal_Company_Unlimited_Sprint
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class UltSprintMod : BaseUnityPlugin
    {
        private const string modGUID = "Test.LCultSprintMod";
        private const string modName = "Unlimited Sprint";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static UltSprintMod Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Unlimited Sprint has been bestowed");

            harmony.PatchAll(typeof(UltSprintMod));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
