using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float snelheid = 5f;
    [SerializeField] private float remainingtijd = 60f;
    private float Tijd = 1f;
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0f, moveZ) * snelheid * Time.deltaTime;
        transform.Translate(movement);

        remainingtijd -= Time.deltaTime;
        Tijd -= Time.deltaTime;

        if (remainingtijd <= 0f)
        {
            Debug.Log("Game Over! Eindscore: " + score);
            enabled = false;
            return;
        }

        if (Tijd <= 0f && remainingtijd > 0f)
        {
            Debug.Log("Overgebleven tijd: " + Mathf.CeilToInt(remainingtijd) + " seconden / score " + score);
            Tijd = 1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Geld"))
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
