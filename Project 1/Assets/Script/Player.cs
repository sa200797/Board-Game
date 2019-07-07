using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int movepoint;


    // Start is called before the first frame update
    void Start()
    {
        movepoint = Random.Range(2, 8) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {

           // gameObject.GetComponent<FollowThePath>().moveAllowed = true;
           gameObject.transform.position = gameObject.GetComponent<FollowThePath>().waypoints[+movepoint].transform.position;
            //  gameObject.GetComponent<FollowThePath>().waypointIndex =movepoint;
            gameObject.GetComponent<FollowThePath>().waypointIndex += 1;

        }
    }
}
