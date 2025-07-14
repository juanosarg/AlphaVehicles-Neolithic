using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using HarmonyLib;
using System.Reflection;

namespace AlphaVehicles
{

    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class MainAncient
    {
        static MainAncient()
        {
            var harmony = new Harmony("com.alphavehiclesancient");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }


    }

}
