using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject coin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float random = Random.Range(-10, 10);
        Instantiate(coin, new Vector3(random, 1, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * input * Time.deltaTime);
    }
}
