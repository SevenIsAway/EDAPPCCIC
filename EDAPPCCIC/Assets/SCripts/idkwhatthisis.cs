using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idkwhatthisis : MonoBehaviour
{
    public GameObject MoveBlock;
    public bool moveBlock = true;
    public float speed;


    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            if (moveBlock == true)
            {
                moveBlock = false;
            }
        }

        else
        {
            moveBlock = true;
        }
    }
}
