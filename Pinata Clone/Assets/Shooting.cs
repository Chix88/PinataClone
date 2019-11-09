using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PointToShhotFrom;
    public GameObject Weapon;
    public float Force;
    public float SettingShootingSpeed;
    private float ShootingSpeed;
    Transform asteroidPosition;


    void Start()
    {
        ShootingSpeed = SettingShootingSpeed;
    }

    // Update is called once per frame
    void Update()
    {
            ShootingSpeed -= Time.deltaTime;
            if (ShootingSpeed <= 0f)
            {
            
                if (Input.GetMouseButton(0))
                {
                Vector3 position = PointToShhotFrom.transform.position;
                Quaternion rotation = PointToShhotFrom.transform.localRotation;
                GameObject objectWithForce;
                objectWithForce = Instantiate(Weapon, position, rotation);

                Rigidbody2D objectRigidBody = objectWithForce.GetComponent<Rigidbody2D>();

                    if (GameObject.FindGameObjectWithTag("Asteroid") != null) //check if there is a target with a tag "asteroid" to shhot at
                    {
                        asteroidPosition = GameObject.FindGameObjectWithTag("Asteroid").transform;
                        objectRigidBody.AddForce(asteroidPosition.position.normalized * Force, ForceMode2D.Impulse);

                    }
                    else
                    {
                        objectRigidBody.AddForce(new Vector2(2, 2) * 500f);
                    }
           

                }

            ShootingSpeed = SettingShootingSpeed;
            }
    }
    
}
