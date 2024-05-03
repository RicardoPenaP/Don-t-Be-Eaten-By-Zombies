using System;

namespace Gameplay.Entities.Common.Attack
{
    public interface IAttackView
    {
        public event Action OnAttackInputDetected;        
    }
}