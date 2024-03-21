using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTimer : MonoBehaviour
{
    private float collisionTime;
    private bool isColliding;

    void Update()
    {
        if (isColliding)
        {
            collisionTime += Time.deltaTime;
            if (collisionTime >= 3f)
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false;
            collisionTime = 0f;
        }
    }
}
