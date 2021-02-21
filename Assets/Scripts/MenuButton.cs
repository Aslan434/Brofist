using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{

    public Button Credits;
    public Button start;
    public Button Quit;
    public Button Controls;
    public GameObject ControlsText;
    public GameObject CreditsCanvas;

    private bool IsCreditsActive = false;
    private bool IsControlsActive = false;

    void Start()
    {
        Quit.onClick.AddListener(QuitGame);
        start.onClick.AddListener(StartGame);
        Credits.onClick.AddListener(ShowCredits);
        Controls.onClick.AddListener(ShowControls);
    }

    private void ShowCredits()
    {
        IsCreditsActive = !IsCreditsActive;
        CreditsCanvas.SetActive(IsCreditsActive);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("White", LoadSceneMode.Single);
    }

    private void ShowControls()
    {
        IsControlsActive = !IsControlsActive;
        ControlsText.SetActive(IsControlsActive);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
