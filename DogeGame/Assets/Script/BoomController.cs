using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 target;
    [SerializeField] private float boomSpeed;
    private Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.position - target)*boomSpeed*Time.deltaTime*-1);
        StartCoroutine(Explosive(1.2f));
    }
    IEnumerator Explosive(float seconds){
        yield return new WaitForSeconds(seconds);
        anim.SetBool("exp", true);
    }
}
