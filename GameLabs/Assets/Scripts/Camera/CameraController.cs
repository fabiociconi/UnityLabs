using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    public Camera initialCamera;
    public Camera middleCamera;
    public Camera finalCamera;
    // Use this for initialization
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D aux)
    {

        switch (aux.gameObject.tag)
        {
            case "initialCamera":
                initialCamera.enabled = true;
                middleCamera.enabled = false;
                finalCamera.enabled = false;
                break;
            case "middleCamera":
                     initialCamera.enabled = false;
                middleCamera.enabled = true;
                finalCamera.enabled = false;
                break;

            case "finalCamera":
                initialCamera.enabled = false;
                middleCamera.enabled = false;
                finalCamera.enabled = true;
                break;
        }


        

    }
    // Update is called once per frame
    void Update()
    {


    }
}
