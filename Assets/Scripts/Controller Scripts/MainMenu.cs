using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGameButton()
    {
     SceneManager.LoadScene("ChoseCharacters");
    }
    public void QuitGameButton()
    {
        Application.Quit();
    }
}
