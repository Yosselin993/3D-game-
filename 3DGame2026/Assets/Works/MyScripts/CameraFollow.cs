 using UnityEngine;

public class CameraFollow : MonoBehaviour //Will make the behaviour of the camera

{
    private Transform Player;
    public float heightAboveBall = 10f; // This is going to be above, showing the bird eye view
    public float smoothspeed = 7f;



    void LateUpdate()
    {
        if (Player == null)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Player");
            if (obj != null)
            {
                Player = obj.transform;
              
            }
            else
            {
                return; //this practically waits for the sphere(Player) to appear
            }
        }
        Vector3 targetPosition = Player.position + Vector3.up * heightAboveBall;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothspeed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(90f, 0f, 0f); //camera position rotation. 90f, 0f, 0f, looks down
    }
}

