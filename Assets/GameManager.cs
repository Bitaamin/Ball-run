using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float restartDelay = 1f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel(){
        CompleteLevelUI.SetActive(true);
    }
    bool gameEnded = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    

    void Restart(){
        SceneManager.LoadScene("Level01");
    }
}

