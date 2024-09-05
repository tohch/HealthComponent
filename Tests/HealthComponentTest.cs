using System.Collections;
using System.Collections.Generic;
using HealthComponent;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthComponentTest
{
    
    private ModefineHealthComponent _health;

    [SetUp]
    public void SetUp()
    {
        GameObject gm = new GameObject();
        _health = gm.AddComponent<ModefineHealthComponent>();
    }


    // A Test behaves as an ordinary method
    [Test]
    public void ModifyneHealthPlus1must2()
    {
        var startHP = _health.Health;
        int delta = 1;
        int expectedHP = startHP + delta;

        _health.ModifyneHealth(delta);

        Assert.AreEqual(expectedHP, _health.Health);
    }

    [Test]
    public void ModifyneHealthMinus1must0()
    {
        var startHP = _health.Health;
        int delta = -1;
        int expectedHP = startHP + delta;

        _health.ModifyneHealth(delta);

        Assert.AreEqual(expectedHP, _health.Health);
    }

    [Test]
    public void ModifyneHealthMinus2MustMinus1()
    {
        var startHP = _health.Health;
        int delta = -2;
        int expectedHP = startHP + delta;

        _health.ModifyneHealth(delta);

        Assert.AreEqual(expectedHP, _health.Health);
    }
}
