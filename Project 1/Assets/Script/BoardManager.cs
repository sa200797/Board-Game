using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour
{
    [Serializable]
    public class Count
    {
        public int minimum;
        public int maximum;

        public Count(int min, int max)
        {
            minimum = min;
            maximum = max;

        }
    }

        int columns = 10;
        int rows = 10;

        public Count pitfall = new Count(2, 3);
        public Count shortcut = new Count(2, 3);

        public GameObject[] tiles;

        public GameObject exit;
        public GameObject start;

        public GameObject[] S_tile;
        public GameObject[] P_tile;

        private Transform boardHolder;

        private List<Vector3> gridPositiins = new List<Vector3>();

        void InitialiseList()
        {
            gridPositiins.Clear();

        for(int x =1; x < columns; x++)
        {
            for(int y =1; y< rows; y++)
            {
                gridPositiins.Add(new Vector3(x, y, 0f));

            }
        }
        }

        void BoardSteup()
        {
            boardHolder = new GameObject("Board").transform;

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    GameObject toInstantiate = tiles[Random.Range(0, tiles.Length)];

                    GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(boardHolder);
                }
            }
        }

    Vector3 RandomPosition()
    {
        int randomIndex = Random.Range(0, gridPositiins.Count);
        Vector3 randomPosition = gridPositiins[randomIndex];
        gridPositiins.RemoveAt(randomIndex);
        return randomPosition;
    }

    void LayoutObjectAtRandom(GameObject[] tileArray, int minimum, int maximum)
        {
            int objectCout = Random.Range(minimum, maximum + 1);
            for (int i = 0; i < objectCout; i++)
            {
               Vector3 randomPosition = RandomPosition();
                GameObject tileChoice = tileArray[Random.Range(0, tileArray.Length)];
                Instantiate(tileChoice, randomPosition, Quaternion.identity);
            }
    }


    public void SetupScene()
    {
        BoardSteup();
        InitialiseList();
        LayoutObjectAtRandom(S_tile,shortcut.minimum,shortcut.maximum);
        LayoutObjectAtRandom(P_tile, pitfall.minimum, pitfall.maximum);


        Instantiate(exit, new Vector3(columns -10 , rows  -1, 0f), Quaternion.identity);
        Instantiate(start, new Vector3(columns - 10, rows - 10, 0f), Quaternion.identity);
    }
}
   

