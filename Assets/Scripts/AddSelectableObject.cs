using UnityEngine;

public class AddSelectableObject : MonoBehaviour
{

    private GameObject Var;
    private SelectableObject SelectObj;
    private string LightName;
    private GameObject LightObj;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] SelecatableObjs = GameObject.FindGameObjectsWithTag("SelectableObj");
        foreach(GameObject SelecatableObj in SelecatableObjs)
        {
            Var = GameObject.Find(SelecatableObj.name);
            Var.AddComponent<SelectableObject>();
        }
    }
}
