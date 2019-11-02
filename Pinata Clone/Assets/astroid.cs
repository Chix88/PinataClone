using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    public GameObject asteriodPrefabs;
    private float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        
    }
    private void SpawnEnemy()
    {
        GameObject a = Instantiate(asteriodPrefabs);
    }
}
