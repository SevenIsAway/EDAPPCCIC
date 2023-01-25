using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idkwhatthisis : MonoBehaviour
{
    public GameObject MoveBlock;
    public bool moveBlock;
    public bool right;
    public bool left;
    public bool up;
    public bool down;
    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            moveBlock = true;
        }
        if (moveBlock == true)
        {
            Right();
            Left();
            Up();
            Down();
        }
    }
    void Right()
    {
        if (right == true)
        {
            MoveBlock.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    void Left()
    {
        if (left == true)
        {
            MoveBlock.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    void Up()
    {
        if (up == true)
        {
            MoveBlock.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    void Down()
    {
        if (down == true)
        {
            MoveBlock.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    //void OnCollisionEnter(Collision Other)
    //{
    //if (other.CompareTag("Wall"))
    //{
    //    moveBlock = false;
    //}
    //}
}
