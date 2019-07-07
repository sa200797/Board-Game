using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public int movepoint;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public int pointIndex;

    


    // Start is called before the first frame update
    void Start()
    {
        movepoint = Random.Range(2, 8);

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");

       

        




    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStays2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
           


        }
        if (collision.gameObject.CompareTag("Player2"))
        {
           
        }

    
        if (collision.gameObject.CompareTag("Player3"))
        {

           

        }
        if (collision.gameObject.CompareTag("Player4"))
        {
          
        }

    }
       
 }
       



    