using System;
using UnityEngine;

namespace Gameplay.Entities.Common.Aim
{
    public interface IAimView
    {
        public event Action<Vector2> OnAimInputDetected;
    }
}