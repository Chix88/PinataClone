using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    public GameObject asteriodPrefabs;
    public float SettingSpawningSpeed;
    private float SpawningSpeed;
    public GameObject SpawningPosition;
    // Start is called before the first frame update
    void Start()
    {
        SpawningSpeed = SettingSpawningSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //the timer is decreasing every frame by a Time.DeltaTime
        SpawningSpeed -= Time.deltaTime;
        if (SpawningSpeed <= 0f)
        {
            SpawnEnemy();
            SpawningSpeed = SettingSpawningSpeed;
        }

    }
    private void SpawnEnemy()
    {
        // instantiate a new prefabs of asteriod 
        // at the Y location of the empty object Spawnposition , and in a range of Random.range(-10,10) from the positon of the empty gameobject Spawnposition 
        // the object is rotated arround the Z axe in a random angle (0,360)
        GameObject a = Instantiate(asteriodPrefabs, new Vector3(Random.Range(-4f, 4f), SpawningPosition.transform.localPosition.y), Quaternion.Euler(0, 0, Random.Range(0,360)));
        a.tag = "Asteroid";
    }
}
