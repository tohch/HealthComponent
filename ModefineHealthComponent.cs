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
<<<<<<< HEAD
<<<<<<< HEAD
        [SerializeField] private int _crid;
=======
=======
>>>>>>> 174bbaa (add modefinehealth)
>>>>>>> 3556b16 (add modefinehealth)
=======
>>>>>>> 05cb9fa (df)


        public int Health => _health;

        public void ModifyneHealth(int delta)
        {
            _health += delta;

            _doAfterModifyneHealth?.Invoke();
        }
    }
}

