using UnityEngine;

public class ResetIfOutOfBounds : MonoBehaviour
{
    public Vector3 respawnPosition = Vector3.zero;// reset to 0,0,0 if out of bounds
    public float fallThreshold = 0f; // -- this is based on Y location - if it is below the floor /reset

    void Update()
    {
        if (transform.position.y < fallThreshold) // checks location
        {
            transform.position = respawnPosition; // teleports back
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero; // stops all motion
        }
    }
}
