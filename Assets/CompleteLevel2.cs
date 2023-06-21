
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel2 : MonoBehaviour
{
   public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}

