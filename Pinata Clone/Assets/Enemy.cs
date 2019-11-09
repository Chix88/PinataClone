using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private float HP;

    public void TakeDamage(float damage)
    {
        HP -= damage;
    }
    public void Kill()
    {
        Destroy(this.gameObject);
    }
}
