using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    //public Camera mainCamera;
   // public Camera zoom;

    private float moveH;
   // private float view = 4;

    public Transform playerPosi;
    void Start()
    {
       // this.GetComponent<Camera>().orthographicSize = view;
    }

  
    void Update()
    {
        this.transform.position = new Vector3(playerPosi.position.x, transform.position.y, transform.position.z);

        moveH = Input.GetAxis("Horizontal");

        if (moveH > 0 && GetComponent<Camera>().orthographicSize > 1f)
        {
            this.GetComponent<Camera>().orthographicSize -= 0.01f;
        }
        else if (moveH < 0 && GetComponent<Camera>().orthographicSize < 5f)
        {
            this.GetComponent<Camera>().orthographicSize += 0.01f;
        }

    }
}
