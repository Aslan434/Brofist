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

    void Start()
    {
        Quit.onClick.AddListener(QuitGame);
        start.onClick.AddListener(StartGame);
        Credits.onClick.AddListener(ShowCredits);
        Controls.onClick.AddListener(ShowControls);
    }

    private void ShowCredits()
    {
        CreditsCanvas.SetActive(true);
        ControlsText.SetActive(false);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("White", LoadSceneMode.Single);
    }

    private void ShowControls()
    {
        ControlsText.SetActive(true);
        CreditsCanvas.SetActive(false);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
