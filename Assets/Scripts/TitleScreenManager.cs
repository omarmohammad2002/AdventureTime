using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using TMPro; // Required for TextMeshPro
using UnityEngine.UI; // Required for UI components

public class TitleScreenManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public AudioSource audioSource; 
    public AudioClip slowTrack; 

    void Start()
    {
        optionsPanel.SetActive(false);
        PlaySlowTrack();
    }

    // Method to start the game
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene 1"); 
    }

    // Method to show options
    public void ShowOptions()
    {
        optionsPanel.SetActive(true); 
    }

    // Method to hide options
    public void HideOptions()
    {
        optionsPanel.SetActive(false); 
    }

    // Method to quit the game
    public void QuitGame()
    {
        Application.Quit(); 
        Debug.Log("Game Closed"); 
    }
    public void PlaySlowTrack()
    {
        if (audioSource != null && slowTrack != null)
        {
            audioSource.clip = slowTrack;
            audioSource.loop = true; 
            audioSource.Play();
        }
    }
}
