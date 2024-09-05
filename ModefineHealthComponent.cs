using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HealthComponent
{
    public class ModefineHealthComponent : MonoBehaviour
    {
        [SerializeField] private int _health;

        public int Health => _health;

        public void ModifyneHealth(int delta)
        {
            _health += delta;
        }
    }
}

