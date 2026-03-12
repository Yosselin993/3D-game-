using UnityEngine;

public class PlayerRoll: MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 torque = new Vector3(vertical, 0f, -horizontal) * moveSpeed;

        rb.AddTorque(torque);

    }
}
