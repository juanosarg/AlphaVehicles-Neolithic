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
    [HarmonyPatch("TryAddPawn")]
    [HarmonyPatch(new Type[] { typeof(Pawn), typeof(VehicleRoleHandler) })]
    public static class AlphaVehicles_VehiclePawn_TryAddPawn_Patch
    {

        public static void Postfix(Pawn pawn, VehiclePawn __instance)
        {

            if (__instance.TryGetComp<CompAddHediffToVehiclePassenger>() is CompAddHediffToVehiclePassenger comp && comp != null)
            {
                foreach (VehicleRoleHandler handler in __instance.handlers)
                {
                    foreach (HediffToRoles hedifftoroles in comp.Props.hediffsToAdd)
                    {

                        if (handler.role.key == hedifftoroles.role && handler.thingOwner.Contains(pawn))
                        {
                            pawn.health.AddHediff(hedifftoroles.hediff);
                        }

                    }
                }
            }

        }

    }




}
