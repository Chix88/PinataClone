using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PointToShhotFrom;
    public GameObject Weapon;
    Transform asteroidPosition;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        asteroidPosition = GameObject.FindGameObjectWithTag("Asteroid").transform;
        Debug.Log(asteroidPosition.position);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = PointToShhotFrom.transform.position;
            Quaternion rotation = PointToShhotFrom.transform.localRotation;
            GameObject objectWithForce;
            objectWithForce = Instantiate(Weapon, position, rotation);

            Rigidbody2D objectRigidBody = objectWithForce.GetComponent<Rigidbody2D>();
            objectRigidBody.AddForce(asteroidPosition.position *100);

        }
    }
    
}
