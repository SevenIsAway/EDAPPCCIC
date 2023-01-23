using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject MoveBlock;
    public bool moveblock

    // Update is called once per frame
    void Update()
    {
        if (moveblock == true)
        {
            MoveBlock.transform.Translate(Vector3.left * Time.deltaTime * 5);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("True");
        }
    }
}
