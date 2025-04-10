using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using NUnit.Framework;
using UnityEngine;
using Enemy_1 = Enemy;

public class CharacterTests
{
    // [Test (Description="角色攻擊敵人")]
    //
    // public void Character_Attack_Enemy()
    // {
    //     //arrange
    //     //建立玩家角色
    //     var characterGo = new GameObject();
    //     characterGo.AddComponent<Character>();
    //     var character = characterGo.GetComponent<Character>();
    //     character.SetAtk(10);
    //     //建立敵人
    //     var EnemyGo=new GameObject();
    //     EnemyGo.AddComponent<Enemy>();
    //     var enemy = EnemyGo.GetComponent<Enemy>();
    //     enemy.Sethp(100);
    //     
    //     //act
    //     //攻擊
    //     character.Attack(enemy);
    //     
    //     //assert
    //     var enemyhp = enemy.Gethp();
    //     Assert.AreEqual(90, enemyhp);
    //
    //
    // }
    //
    // [Test(Description = "角色攻擊死亡的敵人")]
    // public void Character_Attack_DeadEnemy()
    // {
    //     
    //     //arrange
    //     //建立玩家角色
    //     var character = new GameObject().AddComponent<Character>();
    //     character.SetAtk(30);
    //     //建立敵人
    //     var enemy=new GameObject().AddComponent<Enemy>();
    //     enemy.Sethp(20);
    //
    //     //act
    //     //攻擊
    //     character.Attack(enemy);
    //
    //     //assert
    //     var enemyhp = enemy.Gethp();
    //     Assert.AreEqual(0 , enemyhp);
    //
    //
    // }
    [Test(Description="偵測並攻擊範圍所有敵人")]
    public void Attack_AllEnimes()
    {
        var characterGo   = new GameObject();
        var character     =characterGo.AddComponent<Character>();
        var characterCo = characterGo.AddComponent<BoxCollider2D>();
        character.SetAtk(10);
        
        var enemyGo1      = new GameObject();
        var enemy1        = enemyGo1.AddComponent<Enemy>();
        var enemy1Co = enemyGo1.AddComponent<BoxCollider2D>();
        enemy1.Sethp(100);

        var enemyGo2      = new GameObject();
        var enemy2        = enemyGo2.AddComponent<Enemy>();
        var enemy2Co      =enemyGo2.AddComponent<BoxCollider2D>();
        enemy2.Sethp(50);
        
        character.OnTriggerEnter2D(enemy1Co);
        character.OnTriggerEnter2D(enemy2Co);
        
        character.Attack_AllEnimes();
        
        Assert.AreEqual(90, enemy1.Gethp());
        Assert.AreEqual(40,enemy2.Gethp());
    }
}
