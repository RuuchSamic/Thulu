using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteResizer : MonoBehaviour
{
    Scorecard scoreKeep;

    public GameObject player1;
    public GameObject player2;
    public List<GameObject> player1StackListA = new List<GameObject>();
    public List<GameObject> player2StackListA = new List<GameObject>();
    //sprites
    public GameObject frogSprite1;
    public GameObject frogSprite2;
    public GameObject frogSprite3;
    public GameObject frogSprite4;
    public GameObject frogSprite5;

    public GameObject snakeSprite1;
    public GameObject snakeSprite2;
    public GameObject snakeSprite3;
    public GameObject snakeSprite4;
    public GameObject snakeSprite5;

    public GameObject starSprite1;
    public GameObject starSprite2;
    public GameObject starSprite3;
    public GameObject starSprite4;
    public GameObject starSprite5;


    public GameObject snakeFrog;
    public GameObject snakeStar;

    public GameObject starSnake;
    public GameObject starFrog;

    public GameObject frogStar;
    public GameObject frogSnake;

    public Vector3 p1 = new Vector3(-5.541f, 4.408f, -25f);
    public Vector3 p2 = new Vector3(5.42f, 4.5f, -25f);



    // Start is called before the first frame update
    void Start()
    {

        GameObject p1Sprite = Instantiate(player1, p1, Quaternion.identity);
        GameObject p2Sprite = Instantiate(player2, p2, Quaternion.identity);

        HitNote note1 = player1.AddComponent<HitNote>();
        HitNote note2 = player2.AddComponent<HitNote>();

        Debug.Log(Player1Select.playerOne);
        Debug.Log(Player2Select.playerTwo);

        if (Player1Select.playerOne == 0)
        {
            player1.GetComponent<SpriteRenderer>().sprite = snakeSprite1.GetComponent<SpriteRenderer>().sprite;
        }
        else if(Player1Select.playerOne == 1)
        {
            player1.GetComponent<SpriteRenderer>().sprite = starSprite1.GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            player1.GetComponent<SpriteRenderer>().sprite = frogSprite1.GetComponent<SpriteRenderer>().sprite;
        }

        if (Player2Select.playerTwo == 0)
        {
            player2.GetComponent<SpriteRenderer>().sprite = snakeSprite1.GetComponent<SpriteRenderer>().sprite;
        }
        else if (Player2Select.playerTwo == 1)
        {
            player2.GetComponent<SpriteRenderer>().sprite = starSprite1.GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            player2.GetComponent<SpriteRenderer>().sprite = starSprite1.GetComponent<SpriteRenderer>().sprite;
        }

        //GameObject p1Sprite = Instantiate(player1, p1, Quaternion.identity);
        //GameObject p2Sprite = Instantiate(player2, p2, Quaternion.identity);

        player1StackListA.Add(player1);
        player2StackListA.Add(player2);


    }

    // Update is called once per frame
    void Update()
    {
        int currentScore = scoreKeep.gameScore;

        if (currentScore > 0)
        {
            if(currentScore < 10)
            {
                if (Player1Select.playerOne == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeSprite1.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starSprite1.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogSprite1.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if(currentScore >= 10 && currentScore < 20)
            {
                if (Player1Select.playerOne == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeSprite2.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starSprite2.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogSprite2.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (currentScore >= 20 && currentScore < 30)
            {
                if (Player1Select.playerOne == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeSprite3.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starSprite3.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogSprite3.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (currentScore >= 30 && currentScore < 40)
            {
                if (Player1Select.playerOne == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeSprite4.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starSprite4.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogSprite4.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (currentScore >= 40 && currentScore < 50)
            {
                if (Player1Select.playerOne == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeSprite5.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starSprite5.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogSprite5.GetComponent<SpriteRenderer>().sprite;
                }
            }
            /////////////////////////////////////////////////////
            else
            {
                if (Player1Select.playerOne == 0 && Player2Select.playerTwo == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeStar.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 0 && Player2Select.playerTwo == 2)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = snakeFrog.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1 && Player2Select.playerTwo == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starSnake.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1 && Player2Select.playerTwo == 2)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = starFrog.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 2 && Player2Select.playerTwo == 0)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogSnake.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 2 && Player2Select.playerTwo == 1)
                {
                    player1.GetComponent<SpriteRenderer>().sprite = frogStar.GetComponent<SpriteRenderer>().sprite;
                }
            }
        }

        if (currentScore < 0)
        {
            if (0 - currentScore < 10)
            {
                if (Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeSprite1.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite1.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite1.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (0 - currentScore >= 10 && 0 - currentScore < 20)
            {
                if (Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeSprite2.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite2.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite2.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (0 - currentScore >= 20 && 0 - currentScore < 30)
            {
                if (Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeSprite3.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite3.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite3.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (0 - currentScore >= 30 && 0 - currentScore < 40)
            {
                if (Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeSprite4.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite4.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite4.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else if (0 - currentScore >= 40 && 0 - currentScore < 50)
            {
                if (Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeSprite5.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite5.GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSprite5.GetComponent<SpriteRenderer>().sprite;
                }
            }
            else
            {
                if (Player1Select.playerOne == 0 && Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starSnake.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 0 && Player2Select.playerTwo == 2)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = frogStar.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1 && Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeStar.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 1 && Player2Select.playerTwo == 2)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = frogStar.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 2 && Player2Select.playerTwo == 0)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = snakeFrog.GetComponent<SpriteRenderer>().sprite;
                }
                else if (Player1Select.playerOne == 2 && Player2Select.playerTwo == 1)
                {
                    player2.GetComponent<SpriteRenderer>().sprite = starFrog.GetComponent<SpriteRenderer>().sprite;
                }
            }
        }
    }
}
