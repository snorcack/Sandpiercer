using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovementManager : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    [SerializeField]
    float panelWidth;

    [SerializeField]
    int panelCount;

    [SerializeField]
    float panelLimit;

    public List<BGBlock> SpawnedBGBlocks;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBG();
    }

    void MoveBG()
    {
        foreach (BGBlock block in SpawnedBGBlocks)
        {
            block.transform.position = new Vector3(block.transform.position.x - movementSpeed*Time.deltaTime, block.transform.position.y, block.transform.position.z);

        }

        foreach (BGBlock block in SpawnedBGBlocks)
        {
            if (block.transform.position.x < panelLimit)
            {
                ResetBlockPosition(SpawnedBGBlocks.IndexOf(block));
            }

        }
    }

        void ResetBlockPosition (int index)
    {
        float maxPos = 0;

        for (int i=0;i<SpawnedBGBlocks.Count; i++)
        {
            if (SpawnedBGBlocks[i].transform.position.x > maxPos)
                maxPos = SpawnedBGBlocks[i].transform.position.x;

        }
        SpawnedBGBlocks[index].ResetBlock();

        SpawnedBGBlocks[index].transform.position = new Vector3(maxPos + panelWidth, 0, 0);

    }



}
