using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismEnemy : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Enemy health = " + health);
    }

    public virtual void Attack()
    {
        Debug.Log("Enemy attacks");
    }
}

public class Goblin : PolymorphismEnemy
{
    public override void Attack()
    {
        //base.Attack();
        Debug.Log("Goblin swings its sword");
    }
}

public class Archer : PolymorphismEnemy
{
    public override void Attack()
    {
        //base.Attack();
        Debug.Log("The archer fires an arrow");
    }
}

public class Mage : PolymorphismEnemy
{
    public override void Attack()
    {
        //base.Attack();
        Debug.Log("The mage shoots a fireball");
    }
}