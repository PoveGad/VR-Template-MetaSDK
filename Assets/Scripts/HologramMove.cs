using UnityEngine;

public class HologramMove : MonoBehaviour
{
    private float ChangeInY = 0.001f;

    private float TotalMovement = 0;

    private bool Up = true;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.1f, 0);
        if (Up)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + ChangeInY, transform.position.z);
            TotalMovement += ChangeInY;
            if (TotalMovement >0.1f)
            {
                Up = false;
            }
        }
        
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - ChangeInY, transform.position.z);
            TotalMovement -= ChangeInY;
            if (TotalMovement<0)
            {
                Up = true;
            }
        }
    }
}
