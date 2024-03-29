﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BSGO_Server
{
    class MovementCard : Card
    {
        public float minYawSpeed = 3f;

        public float maxPitch = 55f;

        public float maxRoll = 50f;

        public float pitchFading = 0.3f;

        public float yawFading = 0.3f;

        public float rollFading = 0.6f;

        public MovementCard(uint cardGUID, CardView cardView)
            : base(cardGUID, cardView)
        {
        }

        public MovementCard(uint cardGUID, CardView cardView, float minYawSpeed, float maxPitch, float maxRoll, float pitchFading, float yawFading, float rollFading)
            : base(cardGUID, cardView)
        {
            this.minYawSpeed = minYawSpeed;
            this.maxPitch = maxPitch;
            this.maxRoll = maxRoll;
            this.pitchFading = pitchFading;
            this.yawFading = yawFading;
            this.rollFading = rollFading;
        }

        public override void Write(BgoProtocolWriter w)
        {
            base.Write(w);
            w.Write(minYawSpeed);
            w.Write(maxPitch);
            w.Write(maxRoll);
            w.Write(pitchFading);
            w.Write(yawFading);
            w.Write(rollFading);
        }
    }
}
