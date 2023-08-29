using System;
using System.Collections.Generic;
using System.Linq;
using Verse;
using RimWorld;
using UnityEngine;
using Vehicles;


namespace AlphaVehicles
{
   
    public class CompProperties_AddHediffToVehiclePassenger : VehicleCompProperties
    {
        public HediffDef hediffToAdd;
    
        public CompProperties_AddHediffToVehiclePassenger()
        {
            compClass = typeof(CompAddHediffToVehiclePassenger);
        }

     
    }
}
