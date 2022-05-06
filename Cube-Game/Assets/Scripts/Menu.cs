using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayLevel2(){
        SceneManager.LoadScene(2);
    }

    public void PlayLevel3(){
        SceneManager.LoadScene(3);
    }

    public void GoToCredits(){
        SceneManager.LoadScene(4);
    }
}
