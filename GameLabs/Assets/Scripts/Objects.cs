using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objects : MonoBehaviour {

    public GameObject object_1;
    public GameObject object_2;
    public GameObject object_3;

    //public GameObject[] arrayObject;

    public Vector3 objectValues;

    public Text seconds;

    public float sec = 30f;

    public float  spawnInterval = 1.0f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("SpawnObject",0.0f, spawnInterval);
	}
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    private void SpawnObject()
    {
        Vector3 sPosition = new Vector3(UnityEngine.Random.Range(-objectValues.x, objectValues.x), objectValues.y, objectValues.z);
        //Quaternion spawnRotation = Quaternion.identity;
        var item = UnityEngine.Random.Range(0, 3);
        if (item == 0)
        {
            Instantiate(object_1, sPosition, Quaternion.identity);
        }
        else if(item == 1)
        {
            Instantiate(object_2, sPosition, Quaternion.identity);
        }
        else if (item == 3)
        {
            Instantiate(object_3, sPosition, Quaternion.identity);
        }
        //Instantiate(arrayObject[item], sPosition, Quaternion.identity);

    }
  


    private void FixedUpdate()
    {
        sec  -= Time.deltaTime;
        seconds.text = sec.ToString();
    }
    // Update is called once per frame
    void Update ()
    {
		if (sec <= 0)
        {
            SceneManager.LoadScene("Lab5-Total");
           
        }
	}
}
