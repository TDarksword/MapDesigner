﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace MapDesigner.Feature
{
    //public class ZMD_GenStep_Feature : GenStep
    //{
    //    public override int SeedPart
    //    {
    //        get
    //        {
    //            return 1427794901;
    //        }
    //    }


    //    public override void Generate(Map map, GenStepParams parms)
    //    {

    //        MapDesignerSettings settings = MapDesignerMod.mod.settings;
    //        if (settings.selectedFeature == MapDesignerSettings.Features.None)
    //        {
    //            return;
    //        }
    //        if (settings.selectedFeature == MapDesignerSettings.Features.RoundIsland)
    //        {
    //            if (map.Biome.defName.Contains("BiomesIsland"))
    //            {
    //                Log.Message("Can't make round islands, this is already an island!");
    //                return;
    //            }
    //            (new RoundIsland()).Generate(map, parms);
    //        }

    //        // FOR LAKE FEATURE
    //        else if (settings.selectedFeature == MapDesignerSettings.Features.Lake)
    //        {
    //            (new Lake()).Generate(map, parms);
    //        }

    //    }

    //}
}