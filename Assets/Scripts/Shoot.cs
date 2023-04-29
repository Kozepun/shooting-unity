using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform cam;
    public float shootDistance;
    public float shootCD;
    bool isReady = true;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) 
            && isReady 
            && Physics.Raycast(cam.transform.position,
                cam.forward,
                out RaycastHit infoHit, 
                shootDistance))
        {
            if (infoHit.transform.gameObject.GetComponent<Enemy>() != null)
                infoHit.transform.gameObject.GetComponent<Enemy>().GetDamage();
            isReady = false;
            StartCoroutine(ReadyShoot());
        }
    }
    IEnumerator ReadyShoot()
    {
        yield return new WaitForSeconds(shootCD);
        isReady = true;
    }
}
