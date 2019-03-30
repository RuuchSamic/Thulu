using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorecard : MonoBehaviour
{

    public NoteContainer nC1;
    public NoteContainer2 nC2;
    public GameObject Player1;
    public GameObject Player2;
    public int gameScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameScore = nC2.player2Count - nC1.player1Count;
        print("Total game score: " + gameScore);

        //if(gameScore)
    }
}
