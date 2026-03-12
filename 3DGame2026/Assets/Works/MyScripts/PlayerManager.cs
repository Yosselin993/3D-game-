using UnityEngine; // Needed for all unity code

public class PlayerManager : MonoBehaviour // Very Important behaviour that WILL respawn out player
{
    public GameObject playerPrefab;
    public Vector3 spawnPosition = new Vector3(0f, 1f, 0f); // I want it to be a fixed spawn, always where you began
    // for the spawn point i just hardcoded here.
    private GameObject currentPlayer;

    void Start()
    {
        SpawnPlayer();
    }
    public void SpawnPlayer() //function for the respawning part
    {
        if (currentPlayer != null)
        {
            Destroy(currentPlayer);
          
        }
        currentPlayer = Instantiate(playerPrefab, spawnPosition, Quaternion.identity); //This is actually referencing from the unity document
    }
}
