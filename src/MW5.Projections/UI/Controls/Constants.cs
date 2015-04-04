﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Projections.UI.Controls
{
    internal class Constants
    {
        // icons of the image list
        public const int IconFolder = 0;
        public const int IconFolderOpen = 1;
        public const int IconGlobe = 2;
        public const int IconMap = 3;
        public const int IconPlus = 4;
        public const int IconMinus = 5;

        // top nodes keys
        public const string NodeUnspecifiedDatums = "Unknown datums";
        public const string NodeByRegion = "By Region";
        public const string NodeFavorite = "Favorite";
        public const string NodeGeographical = "Geographical";
        public const string NodeProjected = "Projected";
        public const string SearchResults = "Search results";

        // Context menu commands
        public const string ContextAddToFavorite = "Add to Favorite";
        public const string ContextRemoveFromFavorite = "Remove from Favorite";
        public const string ContextShowProperties = "Properties";
        public const string ContextNodeExpand = "Node Expand";
        public const string ContextNodeCollapse = "Node Collapse";

        public const string ScopeNotRecommended = "Not recommended.";
    }
}