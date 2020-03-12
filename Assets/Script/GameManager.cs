using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completLevelUI;

    public GameObject gameLost;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over!");
            Invoke("Restart", restartDelay);
        }
    }

    internal void CompleteLevel()
    {
        completLevelUI.SetActive(true);
        gameHasEnded = true;
    }

    private void Restart()
    {
        gameLost.SetActive(true);
        gameHasEnded = true;
    }

    public bool isEnded()
    {
        return gameHasEnded;
    }
}