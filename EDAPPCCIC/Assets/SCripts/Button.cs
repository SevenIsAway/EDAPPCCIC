using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject MoveBlock;
    public bool moveblock;
    public int direction = 1;
    public Vector3 name;

    // Update is called once per frame
    void Update()
    {
        if (moveblock == true)
        {
          MoveBlock.transform.Translate(name * Time.deltaTime * 5);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            moveblock = true;
        }

    }
}
