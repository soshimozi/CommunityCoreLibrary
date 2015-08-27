﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace CommunityCoreLibrary
{

    public static class HelpCategoryDefOf
    {

        public static readonly string           HelpPostFix = "_HelpCategoryDef";

        public static readonly string           ApparelHelp = "Apparel" + HelpPostFix;
        public static readonly string           WeaponHelp = "Weapon" + HelpPostFix;

        public static readonly string           RecipeHelp = "Recipe" + HelpPostFix;

        public static readonly string           ResearchHelp = "Research" + HelpPostFix;
        public static readonly string           AdvancedResearchHelp = "AdvancedResearch" + HelpPostFix;

        public static readonly HelpCategoryDef  GizmoHelp = DefDatabase< HelpCategoryDef >.GetNamed( "GizmoHelp", true );

    }

}
