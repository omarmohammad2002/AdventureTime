using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisionManager : MonoBehaviour
{

    public GameObject decisionUI;
    public AudioSource decisionAudioSource;
    public float delayBeforeNextScene = 5f;
    public void GoToCliff()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 1")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 2");
        }
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 5")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 8");
        }
       if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 2")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 4");
       }
   }

   // Method called when "Go to Cave" button is pressed
    public void GoToCave()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 1")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 5");
        }
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 5")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 6");
        }
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 2")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 3");
        }
    }

    public void ShowDecisionUI()
   {
        if (decisionUI != null)
        {
            decisionUI.SetActive(true);
        }
        if (decisionAudioSource != null)
        {
            decisionAudioSource.Play();
        }
    }

    public void GoBackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScene");
    }
    public void Transition()
    {
        
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 6")
        {
            Invoke("LoadNextScene", delayBeforeNextScene);
        }
    }
    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 7");
    }
}
