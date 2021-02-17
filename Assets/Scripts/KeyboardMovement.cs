using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{

    public int RotateSpeed = -100;

    public float Damping = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Damping <= 1f)
        {
            Damping += 0.001f;
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed * Time.deltaTime * Damping, 0);
    }
}