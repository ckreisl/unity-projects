using UnityEngine;

public class Block : MonoBehaviour
{

    public float gravityScaleFactor = 20f;

    void Start ()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1f)
        {
            // hack to modify score
            FindObjectOfType<GameManager>().AddOneToScore();
            Destroy (gameObject);
        }       
    }
}
