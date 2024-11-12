using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float delayBeforeNextScene = 5f; // Time in seconds before transitioning
    void Transition()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 6")
        {
            Invoke("LoadNextScene", delayBeforeNextScene);
        }
    }
    void LoadNextScene()
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 7");
    }

}
