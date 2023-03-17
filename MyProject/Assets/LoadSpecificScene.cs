using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSpecificScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Check if the trigger is in level 2
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                // Load level 3 when the player enters the trigger area in level 2
                SceneManager.LoadScene("Level 2");
            }
            // Check if the trigger is in level 3
            else if (SceneManager.GetActiveScene().name == "Level 2")
            {
                // Load the next level when the player enters the trigger area in level 3
                SceneManager.LoadScene("Level 3");
            }
        }
    }
}
