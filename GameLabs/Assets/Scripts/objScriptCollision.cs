using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objScriptCollision : MonoBehaviour {

    public bool pego = false;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
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
