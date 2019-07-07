using UnityEngine;
using System.Collections.Generic;

public class FollowThePath : MonoBehaviour {

   public Transform[] waypoints;

   // public List<GameObject> waypoints = new List<GameObject>();

    [SerializeField]
    private float moveSpeed = 1f;

    public int waypointIndex = 0;

    public bool moveAllowed = false;


  

	// Use this for initialization
	private void Start () {

        transform.position = waypoints[waypointIndex].transform.position;
      
    }
	
	// Update is called once per frame
	private void Update () {
        
        
        if (moveAllowed)
        {
            Move();
        }
        
        
	}

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Red"))
        {
           
            gameObject.transform.position = waypoints[waypointIndex - 2].transform.position;
            Debug.Log("move");
            

            
        }
    }
}
/* aisa condition dena pade ga
 * agar waypoint red or bluer */