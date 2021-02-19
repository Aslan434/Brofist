using UnityEngine;
using static SelecatbleObjectStory;

public class OptionsManage : MonoBehaviour
{

    private SelectableObject SelectedOBJ;

    public void ProcessOptions(Rply RawRply, string name)
    {
        Debug.Log(RawRply);
        SelectedOBJ = GameObject.Find(name).GetComponent<SelectableObject>();
        SelectedOBJ.enabled = false;
    }
}
