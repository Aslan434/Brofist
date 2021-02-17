using UnityEngine;

public class SelectObjectMouseClick : MonoBehaviour
{

    public Material SelectingMat;

    private Renderer SelectedRenderer;
    private Material DefaultMat;
    private Transform Location;

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

        RaycastHit HitInfo = new RaycastHit();
        bool Hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out HitInfo);
        if (Hit)
        {
            if(HitInfo.transform.gameObject.GetComponent<SelectableObject>() != null)
            {
                SelectedRenderer = HitInfo.transform.gameObject.GetComponent<Renderer>();
                if ( SelectedRenderer != null)
                {
                    SelectedRenderer.material = SelectingMat;
                }
                Location = HitInfo.transform;
            }
        }
    }
}
