using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Select : MonoBehaviour
{
    public static int playerOne;
    public void Player1Choose(int charNum)
    {
        playerOne = charNum;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
