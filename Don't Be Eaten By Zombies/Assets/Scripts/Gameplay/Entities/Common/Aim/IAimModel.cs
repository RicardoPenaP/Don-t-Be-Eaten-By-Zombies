using System;
using UnityEngine;

namespace Gameplay.Entities.Common.Aim
{
    public interface IAimModel
    {
        public event Action<Vector2> OnAimInputDetected;
    }
}