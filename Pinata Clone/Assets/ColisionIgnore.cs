using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionIgnore : MonoBehaviour
{
    public GameObject player;
    public GameObject weapon;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
        {
            //Do Stuff:
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            Destroy(weapon);
            enemy.Kill();

            Debug.Log($"Sword collided with {enemy.gameObject.name}");
        }
    }
}
