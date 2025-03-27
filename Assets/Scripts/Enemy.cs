using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;
    public void TakeDamage(int damage)
    {
          hp -= damage;
         
        
    }

    public void Sethp(int hpvalue)
    {
        hp = hpvalue;
    }

    public int Gethp()
    {
        return hp;
    }
}
