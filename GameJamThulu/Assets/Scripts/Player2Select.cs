using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Select : MonoBehaviour
{
    public static int playerTwo;
    public void Player2Choose(int charNum)
    {
        do
        {
          playerTwo = charNum;
        } while (playerTwo != Player1Select.playerOne);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
