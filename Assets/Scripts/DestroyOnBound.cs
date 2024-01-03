using UnityEngine;

public class DestroyOnBound : MonoBehaviour
{
    private float TopBound = 30f;
    private float BottomBound = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //destroy gameobjects over zTopBound. Destroy and show GAME OVER when under BottomBound.
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < BottomBound)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
        }

    }
}
