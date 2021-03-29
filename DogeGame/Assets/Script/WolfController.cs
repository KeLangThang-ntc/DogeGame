using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject boom;
    private float minBoomTime = 2f;
    private float maxBoomTime = 4f;
    private float boomTime = 0;
    private float lastBoomtime = 0;
    
    private GameObject Sheep;
    void Start()
    {
        Sheep = GameObject.FindGameObjectWithTag("Player");
        UpdateBoomTime();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > lastBoomtime + boomTime){
            ThrowBoom();
        }

    }
    
    private void UpdateBoomTime(){
        lastBoomtime = Time.time;
        boomTime = Random.Range(minBoomTime, maxBoomTime);
    }
    private void ThrowBoom(){
         UpdateBoomTime();
         GameObject bom = Instantiate(boom, transform.position, Quaternion.identity) as GameObject;
         bom.GetComponent<BoomController>().target = Sheep.transform.position;
    }
}
