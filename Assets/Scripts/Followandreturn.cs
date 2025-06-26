using Unity.VisualScripting;
using UnityEngine;

public class Followandreturn : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;
    [SerializeField] private float speed;
    private Vector3 startpos;
    private bool reset = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startpos = new Vector3(0,0,0);
        transform.position = startpos;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reset)
        {
            ReturnToStart();
        }
        else
        {
            FollowTarget();
        }
    }

    void FollowTarget()
    {
        transform.position = Vector3.Lerp(transform.position, PlayerTransform.position, speed * Time.deltaTime);
        float distance = Vector3.Distance(transform.position, PlayerTransform.position);
        if (distance < 0.1f)
        {
            reset = true;
        }
    }

    void ReturnToStart()
    {
        Vector3 direction = (startpos - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
        float distance2start = Vector3.Distance(transform.position, startpos);
        if (distance2start < .1f)
        {
            reset = false;
        }
    }
}
