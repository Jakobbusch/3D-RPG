using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    private Animator anim;
    private AudioSource audioSource;
    [SerializeField] 
    private AudioClip clip;
    private float timer = 0.0f;
    public GameObject barrel;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            anim.SetBool("Roll",true);
            timer = 0;
            StartCoroutine(wait());
            //Instantiate(barrel, transform.position, Quaternion.identity);

            StartCoroutine(yell());
        }
    }

    IEnumerator wait()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1.3f);
        anim.SetBool("Roll",false);
        GameObject barrelClone = Instantiate(barrel, transform.position+new Vector3(0,0.03f,0.25f), Quaternion.Euler(0,0,90));
        barrelClone.GetComponent<Rigidbody>().AddForce(transform.forward*50);
        Destroy(barrelClone,25);
    }

    IEnumerator yell()
    {
        yield return new WaitForSeconds(35);
        audioSource.PlayOneShot(clip);
    }
}
