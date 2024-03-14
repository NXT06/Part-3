using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;
    public float delay = 0.4f; 
    
    protected override void Attack()
    {
        
        base.Attack();
        destination = transform.position;
        Invoke("SpawnArrow", delay); 
    }
    void SpawnArrow()
    {
        Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Archer; 
    }
}
