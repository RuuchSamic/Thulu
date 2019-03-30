using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayGenerator : MonoBehaviour
{
    public KeyCode[] player1 = new KeyCode[10];
    public KeyCode[] player2 = new KeyCode[10];
    private int randomKey;
    //private Random randomGenerator = new Random();


    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 10; i++)
        {
            randomKey = Random.Range(0,4);

            if (randomKey == 0)
            {
                player1[i] = KeyCode.W;
                player2[i] = KeyCode.UpArrow;
            }
            else if (randomKey == 1)
            {
                player1[i] = KeyCode.A;
                player2[i] = KeyCode.LeftArrow;
            }
            else if(randomKey == 2)
            {
                player1[i] = KeyCode.S;
                player2[i] = KeyCode.DownArrow;
            }
            else
            {
                player1[i] = KeyCode.D;
                player2[i] = KeyCode.RightArrow;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
