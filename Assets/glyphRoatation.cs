using UnityEngine;

public class glyphRoatation : MonoBehaviour
{
    public Transform Box1, Box2;
    public float rotVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Box1.Rotate(0, 0, rotVelocity);
        Box2.Rotate(0, 0, -rotVelocity);
    }
}
