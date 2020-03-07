using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLoop : MonoBehaviour
{

    public GameObject ObstacleInstance;
    [SerializeField] private float ObstacleGenerateTime = 2;



    private IEnumerator GenerateObstacles()
    {
        while (true)
        {
            yield return new WaitForSeconds(ObstacleGenerateTime); // wait for ? long
            // do things
            Instantiate(ObstacleInstance, new Vector3(7, 0, 0), Quaternion.identity);
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TheBeastAwakens");
        StartCoroutine("GenerateObstacles");
    }




}
