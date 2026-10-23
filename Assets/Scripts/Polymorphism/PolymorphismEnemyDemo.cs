using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismEnemyDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*PolymorphismEnemy enemy1 = new Goblin();
        PolymorphismEnemy enemy2 = new Archer();

        enemy1.Attack();
        enemy2.Attack();*/

        PolymorphismEnemy[] enemies =
        {
            new Goblin(),
            new Archer(),
            new Mage()
        };

        foreach(PolymorphismEnemy enemy in enemies)
        {
            enemy.Attack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
