using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    public GameObject asteriodPrefabs;
    public float Timer = 2.0f;
    public GameObject SpawningPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the timer is decreasing every frame by a Time.DeltaTime
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            SpawnEnemy();
            Timer = 2f;
        }

    }
    private void SpawnEnemy()
    {
        // instantiate a new prefabs of asteriod 
        // at the Y location of the empty object Spawnposition , and in a range of Random.range(-10,10) from the positon of the empty gameobject Spawnposition 
        // the object is rotated arround the Z axe in a random angle (0,360)
        GameObject a = Instantiate(asteriodPrefabs, new Vector3(Random.Range(-10, 10), SpawningPosition.transform.localPosition.y), Quaternion.Euler(0, 0, Random.Range(0,360)));
    }
}
