using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject levelWonUI;
    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game over!");
            Invoke("Restart",restartDelay);
        }
    }

    private void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel(){
        levelWonUI.SetActive(true);
    }
}
