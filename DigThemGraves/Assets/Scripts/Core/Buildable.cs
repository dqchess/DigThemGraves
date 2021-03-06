﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigThemGraves
{
    public abstract class Buildable : MonoBehaviour, IBuildable
    {
        public abstract IActions AvailableActions { get; }
        public abstract BuildSlot OccupiedSlot { get; set; }

        public abstract void Build();
    }
}
