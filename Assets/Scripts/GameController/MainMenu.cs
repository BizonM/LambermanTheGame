using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameSceneName;
    [SerializeField] private GameObject howToPlay;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowTutorial()
    {
        howToPlay.SetActive(true);
    }
}

