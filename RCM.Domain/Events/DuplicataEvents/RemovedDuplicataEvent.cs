﻿using RCM.Domain.Models.DuplicataModels;

namespace RCM.Domain.Events.DuplicataEvents
{
    public class RemovedDuplicataEvent : DuplicataEvent
    {
        public RemovedDuplicataEvent(Duplicata duplicata) : base(duplicata)
        {
        }

        public override void Normalize()
        {
            Args.Add(nameof(Duplicata.Id), Duplicata.Id);
        }
    }
}
