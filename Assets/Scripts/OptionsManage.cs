using UnityEngine;
using static SelecatbleObjectStory;
using UnityEngine.UI;

public class OptionsManage : MonoBehaviour
{

    public GameObject Canvas;
    public Text Text;

    private SelectableObject SelectedOBJ;

    public void ProcessOptions(Rply RawRply, string name)
    {
        Canvas.SetActive(true);
        Text.text = RawRply.GenieTalk;
        SelectedOBJ = GameObject.Find(name).GetComponent<SelectableObject>();
        SelectedOBJ.enabled = false;
    }
}
