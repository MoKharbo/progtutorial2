using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private ScoreManager ScoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (ScoreManager == null)
        {
            Debug.Log("missing script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Geld")
        {
            ScoreManager.AddScore(10);
            Debug.Log("you got a coin");
            Destroy(other.gameObject);
        }
    }
}
