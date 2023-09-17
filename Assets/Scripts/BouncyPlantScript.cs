using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPlantScript : MonoBehaviour
{
    float xOffset = 0;
    float yOffset = 0;
    float speedMultiplier = 1f;
    /// <summary>
    /// -108, -92, 4, -4
    /// </summary>
    float upperbound = 4f;
    float lowerbound = -4f;
    float rightBound = -92;
    float leftBound = -108;
    public MiniGameController gameRef;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveTile();
    }

    private void OnEnable()
    {
        speedMultiplier = Random.Range(0.6f, 2.3f);

        xOffset = 1f - Random.Range(0f, 1.9f) + 0.1f;
        yOffset = 1f - Random.Range(0, 1.9f) + 0.1f;

        Debug.Log("Xoffset"+xOffset + "yOffset"+yOffset);
    }


    void MoveTile()
    {
        transform.position = new Vector3(transform.position.x + (xOffset * speedMultiplier*Time.deltaTime), transform.position.y + (yOffset * speedMultiplier*Time.deltaTime), 0);

        if (transform.position.x < leftBound)
        {
            xOffset *= -1;
        }

        if (transform.position.x > rightBound)
        {
            xOffset *= -1;
        }

        if (transform.position.y < lowerbound)
        {
            yOffset *= -1;
        }

        if (transform.position.y > upperbound)
        {
            yOffset *= -1;
        }


    }

    private void OnMouseDown()
    {
        gameRef.UpdateScore(4);
        gameObject.SetActive(false);
    }


}
