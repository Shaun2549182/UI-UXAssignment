using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public void CameraChestMove()
    {
        if (transform.position.x == 0f)
        {
            transform.position = transform.position + new Vector3(-9f, 0f, 0f);
        }
    }
    public void CameraStoreMove()
    {
        if (transform.position.x == -9f)
        {
            transform.position = transform.position + new Vector3(9f, 0f, 0f);
        }
    }
}
