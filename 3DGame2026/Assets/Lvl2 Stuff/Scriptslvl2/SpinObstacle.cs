using UnityEngine;

public class SpinObstacle : MonoBehaviour
{
    [Header("Movement")]
    public float spinSpeed = 120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f); // magic spin
    }
}
