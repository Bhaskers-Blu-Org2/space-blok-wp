/**
* Copyright (c) 2011 Digia Plc
* Copyright (c) 2011 Nokia Corporation and/or its subsidiary(-ies).
* All rights reserved.
*
* For the applicable distribution terms see the license text file included in
* the distribution.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlokGameObjects.GameLevelObjects.BlockEvents
{
    /// <summary>
    /// Hit points event, that triggers the blok action.
    /// </summary>
    public class OnHitPointsEvent : BlockEvent
    {
        public int HitPoints { get; set; }

        public override void HandleEvent(Block block)
        {
            if (block.HitPoints <= HitPoints)
            {
                BlockAction.DoAction(block);
            }
        }
    }
}
