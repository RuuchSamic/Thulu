using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorecard : MonoBehaviour
{

    public NoteContainer nC1;
    public NoteContainer2 nC2;
    private int gameScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameScore = nC2.player2Count - nC1.player1Count;
        print("Total game score: " + gameScore);
    }
}
