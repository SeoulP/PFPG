using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    GameObject cam;
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((cam.transform.position - transform.position).magnitude > 550)
        {
            transform.position += new Vector3(0, 0, 1000 + Random.Range(-50, 51));
        }

        if (gameObject.CompareTag("Bird"))
        {
            if ((player.transform.position - transform.position).magnitude > 550)
            {
                transform.position = new Vector3(0, player.transform.position.y + Random.Range(-80, 80), player.transform.position.z + Random.Range(325, 550));
            }
        }
    }
}
