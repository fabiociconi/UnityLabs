using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class total : MonoBehaviour {


    public Text obj_1;
    public Text obj_2;
    public Text obj_3;

    private int obj1 = 0;
    private int obj2 = 0;
    private int obj3 = 0;
    // Use this for initialization
    void Start () {
        // var objects[] = GameObject.FindGameObjectsWithTag("obj_2");


        GameObject[] obj = UnityEngine.Object.FindObjectsOfType<GameObject>();
        Debug.Log("Peguei"+ obj);
        foreach (GameObject item in obj)
        {
            if (item.tag == "obj_1" && item.GetComponentInParent<objScriptCollision>().pego)
            {
                Debug.Log("Peguei");
                obj1++;
            }
            else if (item.tag == "obj_2" && item.GetComponentInParent<objScriptCollision>().pego)
            {
                obj2++;
            } else if (item.tag == "obj_3" && item.GetComponentInParent<objScriptCollision>().pego)
            {
                obj3++;
            }
        }

        obj_1.text = obj1.ToString();
        obj_2.text = obj2.ToString();
        obj_3.text = obj3.ToString();



    }

}
