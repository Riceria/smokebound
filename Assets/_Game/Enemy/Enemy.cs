using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData;
    void Start()
    {
        enemyData.charName = "Triangle";
    }

}
