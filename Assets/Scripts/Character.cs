using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int atk;
    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(atk);
    }

    public void SetAtk(int atkValue)
    {
        atk = atkValue;
    }
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        throw new NotImplementedException();
    }

    public void Attack_AllEnimes()
    {
        throw new System.NotImplementedException();
    }
}
