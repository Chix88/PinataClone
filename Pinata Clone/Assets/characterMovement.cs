using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float speed;
    private bool direction;
    // Start is called before the first frame update
    void Start()
    {
       direction = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int directionOfWalking = Direction(direction);
        controller.Move(speed * directionOfWalking *Time.fixedDeltaTime, false, false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        direction = !direction;
    }
    private int Direction(bool direction)
    {
        if (direction)
            return 1;
        else
            return -1;
    }
}
