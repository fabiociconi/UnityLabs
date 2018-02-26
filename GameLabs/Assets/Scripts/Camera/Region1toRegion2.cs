using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region1toRegion2 : MonoBehaviour
{
    public Transform playerPosition;
    public Transform playerMoveThresholdRight;
    public Transform playerMoveThresholdLeft;


    void Start()
    {
        playerMoveThresholdRight = transform.GetChild(0);
        playerMoveThresholdLeft = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition.position.x > playerMoveThresholdRight.position.x)
        {
            this.transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
        }
        if (playerPosition.position.x < playerMoveThresholdLeft.position.x)
        {
            this.transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(playerMoveThresholdRight.position, new Vector3(playerMoveThresholdRight.position.x, playerMoveThresholdRight.position.y + 100, playerMoveThresholdRight.position.z));
        Gizmos.DrawLine(playerMoveThresholdRight.position, new Vector3(playerMoveThresholdRight.position.x, playerMoveThresholdRight.position.y - 100, playerMoveThresholdRight.position.z));

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(playerMoveThresholdLeft.position, new Vector3(playerMoveThresholdLeft.position.x, playerMoveThresholdLeft.position.y + 100, playerMoveThresholdLeft.position.z));
        Gizmos.DrawLine(playerMoveThresholdLeft.position, new Vector3(playerMoveThresholdLeft.position.x, playerMoveThresholdLeft.position.y - 100, playerMoveThresholdLeft.position.z));
    }
}
