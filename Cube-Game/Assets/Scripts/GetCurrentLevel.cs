using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetCurrentLevel : MonoBehaviour
{
    private string currentLevel;
    public Text currentText;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().name;
        currentText.text = currentLevel;  
    }
}
