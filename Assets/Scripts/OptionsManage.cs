using UnityEngine;
using static SelecatbleObjectStory;
using UnityEngine.UI;

public class OptionsManage : MonoBehaviour
{

    public GameObject Canvas;
    public Text Text;

    private Rply CurrentRply;
    private SelectableObject SelectedOBJ;
    private SelecatbleObjectStory SOS;

    public void GenieOptions(Rply RawRply, string name)
    {
        CurrentRply = RawRply;
        Canvas.SetActive(true);
        Text.text = "  Reshai:   " + RawRply.GenieTalk;
        SelectedOBJ = GameObject.Find(name).GetComponent<SelectableObject>();
        SelectedOBJ.enabled = false;
        SOS = GameObject.Find(name).GetComponent<SelecatbleObjectStory>();
        SOS.enabled = false;
    }

    public void NextOption()
    {
        Text.text = " " + CurrentRply.Name + ":   " + CurrentRply.DefaultRplyByChar;
    }

    public void LastStep()
    {
        Canvas.SetActive(false);
    }
}
