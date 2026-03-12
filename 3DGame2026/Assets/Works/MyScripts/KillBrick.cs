using UnityEngine; //This is necessary for unity :)

public class KillBrick : MonoBehaviour //focuses on destroying something (in this case the player)
{
    public PlayerManager playerManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerManager.SpawnPlayer();
        }
    }
}
