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
    [HarmonyPatch("Notify_Boarded")]
    public static class AlphaVehicles_VehiclePawn_Notify_Boarded_Patch
    {

        public static void Postfix(Pawn pawnToBoard, VehiclePawn __instance)
        {

            if (__instance.TryGetComp<CompAddHediffToVehiclePassenger>() is CompAddHediffToVehiclePassenger comp && comp != null)
            {
                
                foreach(VehicleHandler handler in __instance.handlers)
                {
                    foreach(HediffToRoles hedifftoroles in comp.Props.hediffsToAdd) {

                        if (handler.role.key == hedifftoroles.role && handler.handlers.Contains(pawnToBoard))
                        {
                            pawnToBoard.health.AddHediff(hedifftoroles.hediff);
                        }

                    }

                    
                }
                


                
            }

        }

    }




}
