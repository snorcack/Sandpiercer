using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGBlock : MonoBehaviour
{
    public List<GameObject> BGProps;
    int maxChance = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetBlock()
    {
        int randomIndex = Random.Range(0, BGProps.Count - 1);

        for (int i=0;i<BGProps.Count;i++)
        {
            int randomId = Random.Range(0, 100);



            if (i!=randomIndex)
            {
                BGProps[i].SetActive(false);
            } else
            {
                BGProps[i].SetActive(true);
            }


        }


    }


}
