/**
* Copyright (c) 2011 Digia Plc
* Copyright (c) 2011-2014 Microsoft Mobile and/or its subsidiary(-ies).
* All rights reserved.
*
* For the applicable distribution terms see the license text file included in
* the distribution.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlokGameObjects.GameLevelObjects.BlockActions
{
    public class EmitParticlesAction : IBlockAction
    {
        public String ParticlesName { get; set; }

        public void DoAction(Block block)
        {
            throw new NotImplementedException();
        }
    }
}
