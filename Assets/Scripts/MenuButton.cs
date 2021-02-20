using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{

    public Button Credits;
    public Button start;
    public Button Quit;
    public GameObject CreditsCanvas;

    private bool IsCreditsActive = false;

    void Start()
    {
        Quit.onClick.AddListener(QuitGame);
        start.onClick.AddListener(StartGame);
        Credits.onClick.AddListener(ShowCredits);
    }

    private void ShowCredits()
    {
        IsCreditsActive = !IsCreditsActive;
        Debug.Log(IsCreditsActive);
        CreditsCanvas.SetActive(IsCreditsActive);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("White", LoadSceneMode.Single);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
