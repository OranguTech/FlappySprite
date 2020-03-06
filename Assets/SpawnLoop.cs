using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLoop : MonoBehaviour
{

    public GameObject ObstacleInstance;






    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(ObstacleInstance, new Vector3(7, 0, 0), Quaternion.identity);
        Debug.Log("TheBeastAwakens");
        StartCoroutine("GenerateObstacles");
    }


    private IEnumerator GenerateObstacles()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f); // wait half a second
            // do things
            Instantiate(ObstacleInstance, new Vector3(7, 0, 0), Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
