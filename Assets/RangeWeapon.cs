using UnityEngine;

public class RangeWeapon : MonoBehaviour
{

	public Camera fpsCam;
	public float range = 100f;
	public float damage = 10f;
	public float impactForce = 200f;

	public ParticleSystem hitParticles;

    Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }


    void Update()
    {
    	if(Input.GetButtonDown("Fire1")){
            anim.SetInteger("Condition", 2);
    		Shoot();
    	}
        
    }

    void Shoot(){

    	RaycastHit hit;
    	if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){

    		Debug.Log(hit.transform.name);

    		Target target = hit.transform.GetComponent<Target>();

    		if(target != null){
    			target.TakeDamage(damage);

                Instantiate(hitParticles, hit.point, Quaternion.LookRotation(hit.normal));
    		}

    		if(hit.rigidbody != null){

    			hit.rigidbody.AddForce(-hit.normal * impactForce);

    		}

    	}
    }


}