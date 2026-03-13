using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerRoll>() != null)
        {
            Debug.Log("Something touched the goal");
            SceneManager.LoadScene("Level_2");
        }
    }
}
