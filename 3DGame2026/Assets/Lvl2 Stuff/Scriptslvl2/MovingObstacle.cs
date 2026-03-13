using Unity.VisualScripting;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{

    [Header("Movement")]
    public Vector3 moveDirection = Vector3.right;
    public float moveDistance = 3f;
    public float moveSpeed = 2f;

    private Vector3 startPos; //start position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + moveDirection * Mathf.Sin(Time.time * moveSpeed) * moveDistance; // the movement magic
    }
}
