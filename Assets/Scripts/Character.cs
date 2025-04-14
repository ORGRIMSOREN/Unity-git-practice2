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

    [SerializeField]
    private List<Enemy> enemies = new List<Enemy>();
    
    public void OnTriggerEnter2D(Collider2D collder2D)
    {
        var enemy = collder2D.GetComponent<Enemy>();
        enemies.Add(enemy);
    }
    [ContextMenu("攻擊所有偵測範圍敵人")]
    public void Attack_AllEnimes()
    {
        foreach (var enemy in enemies)
        {
            enemy.TakeDamage(atk);
        }
        
    }
}
