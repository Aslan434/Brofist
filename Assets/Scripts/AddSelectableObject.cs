using UnityEngine;

public class AddSelectableObject : MonoBehaviour
{

    private GameObject Var;

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
