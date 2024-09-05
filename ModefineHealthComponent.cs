using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HealthComponent
{
    public class ModefineHealthComponent : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private bool _immun;
        [SerializeField] private UnityEvent _doAfterModifyneHealth;
        [SerializeField] private int _def;
        [SerializeField] private int _crid;
        [SerializeField] private int _crid2;
        [SerializeField] private int _crid3;
        [SerializeField] private int _crid4a;


        public int Health => _health;

        public void ModifyneHealth(int delta)
        {
            _health += delta;

            _doAfterModifyneHealth?.Invoke();
        }
    }
}

