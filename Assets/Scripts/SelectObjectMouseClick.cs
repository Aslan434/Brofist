using UnityEngine;

public class SelectObjectMouseClick : MonoBehaviour
{

    public Material SelectingMat;

    private Renderer SelectedRenderer;
    private Material DefaultMat;
    private Transform Location;
    private RaycastHit HitInfo;
    private RaycastHit TapHitInfo;

   // Update is called once per frame
    void Update()
    {

        if (Location != null)
        {
            SelectedRenderer = Location.gameObject.GetComponent<Renderer>();
            DefaultMat = Location.gameObject.GetComponent<SelectableObject>().ReturnDefaultMat();
            SelectedRenderer.material = DefaultMat;
            Location = null;
        }

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out HitInfo))
        {
            if(HitInfo.transform.gameObject.GetComponent<SelectableObject>() != null)
            {
                SelectedRenderer = HitInfo.transform.gameObject.GetComponent<Renderer>();
                SelectedRenderer.material = SelectingMat;
                Location = HitInfo.transform;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out TapHitInfo))
            {
                if (TapHitInfo.transform.gameObject.GetComponent<SelectableObject>())
                {
                    if (TapHitInfo.transform.gameObject.GetComponent<SelectableObject>().ReturnHasLight())
                    {
                        TapHitInfo.transform.gameObject.GetComponent<SelectableObject>().SetLight();
                    }
                }
            }
        }
    }
}
