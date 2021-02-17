using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{

    private float DesiredRot;
    public float RotSpeed = 100;
    public float Damping = 4;

    private void OnEnable()
    {
        DesiredRot = transform.eulerAngles.y;
    }

    private void Update()
    {

        if(Input.GetAxisRaw("Horizontal") == -1)
        {
            DesiredRot += RotSpeed * Time.deltaTime;
        }
        else if(Input.GetAxisRaw("Horizontal") == 1)
        {
            DesiredRot -= RotSpeed * Time.deltaTime;
        }

        var DesiredRotQ = Quaternion.Euler(transform.eulerAngles.x, DesiredRot, transform.eulerAngles.z);
        transform.rotation = Quaternion.Slerp(transform.rotation, DesiredRotQ, Time.deltaTime * Damping);
    }
}