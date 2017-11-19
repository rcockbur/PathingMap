using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject obstacle;

    // Use this for initialization
    void Start()
    {
        for (int z = 0; z < 5; z++)
        {
            for (int x = 0; x < 5; x++)
            {
                Instantiate(obstacle, new Vector3((x-2)*20, 0, (z-2)*20), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
