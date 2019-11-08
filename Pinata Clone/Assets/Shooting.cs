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
        
        

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = PointToShhotFrom.transform.position;
            Quaternion rotation = PointToShhotFrom.transform.localRotation;
            GameObject objectWithForce;
            objectWithForce = Instantiate(Weapon, position, rotation);

            Rigidbody2D objectRigidBody = objectWithForce.GetComponent<Rigidbody2D>();

            if (GameObject.FindGameObjectWithTag("Asteroid") != null) //check if there is a target with a tag "asteroid" to shhot at
            {
                asteroidPosition = GameObject.FindGameObjectWithTag("Asteroid").transform;
                objectRigidBody.AddForce(asteroidPosition.position * 100f);

            }
            else
            {
                objectRigidBody.AddForce(new Vector2(2, 2) * 500f);
            }
           

        }
    }
    
}
