using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour {

    public  GameObject whoWinsTextShadow, player1MoveText, player2MoveText, player3MoveText, player4MoveText;

    private static GameObject player1, player2,player3,player4;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;

    public static bool gameOver = false;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow.SetActive(false);
        player1MoveText.SetActive(true);
        player2MoveText.SetActive(false);
        player3MoveText.SetActive(false);
        player4MoveText.SetActive(false);



        /*  whoWinsTextShadow = GameObject.Find("WhoWinsText");
           player1MoveText = GameObject.Find("Player1MoveText");
           player2MoveText = GameObject.Find("Player2MoveText");*/

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
       
        player4 = GameObject.Find("Player4");

            



        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;


       

        
    }

    // Update is called once per frame
    void Update()
    {
        //Player1

        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        // Player2

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(true);
            player4MoveText.gameObject.SetActive(false);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        //Player3 
        if (player3.GetComponent<FollowThePath>().waypointIndex >
           player3StartWaypoint + diceSideThrown)
        {
            player3.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(true);
            player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;

            
        }

         //Player 4

        if (player4.GetComponent<FollowThePath>().waypointIndex >
           player4StartWaypoint + diceSideThrown)
        {
            player4.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        
        //Player 1

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<TextMeshPro>().text = "Player 1 Wins";
            gameOver = true;
        }

         // player 2

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);

            whoWinsTextShadow.GetComponent<TextMeshPro>().text = "Player 2 Wins";
            gameOver = true;
        }
        //Player3

        if (player3.GetComponent<FollowThePath>().waypointIndex ==
           player3.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);

            whoWinsTextShadow.GetComponent<TextMeshPro>().text = "Player 3 Wins";
            gameOver = true;
        }

        //player4

        if (player4.GetComponent<FollowThePath>().waypointIndex ==
           player4.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<TextMeshPro>().text = "Player 4 Wins";
            gameOver = true;
        }


    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                break;


        }
    }

    
}
