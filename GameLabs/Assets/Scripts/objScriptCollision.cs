using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objScriptCollision : MonoBehaviour {

    public bool pego = false;



    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    
    
    // Use this for initialization
    void Start () {
	}
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            pego = true;
            //Debug.Log("Peguei");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
