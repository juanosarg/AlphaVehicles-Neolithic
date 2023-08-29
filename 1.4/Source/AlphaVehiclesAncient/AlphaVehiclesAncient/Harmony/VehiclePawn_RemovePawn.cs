using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using Vehicles;


namespace AlphaVehicles
{



    [HarmonyPatch(typeof(VehiclePawn))]
    [HarmonyPatch("RemovePawn")]
    public static class AlphaVehicles_VehiclePawn_RemovePawn_Patch
    {

        public static void Postfix(Pawn pawn, VehiclePawn __instance)
        {

            if (__instance.TryGetComp<CompAddHediffToVehiclePassenger>() is CompAddHediffToVehiclePassenger comp && comp != null)
            {
                if (pawn.health.hediffSet.GetFirstHediffOfDef(comp.Props.hediffToAdd) != null)
                {
                    pawn.health.RemoveHediff(pawn.health.hediffSet.GetFirstHediffOfDef(comp.Props.hediffToAdd));
                }
                
            }

        }

    }




}
