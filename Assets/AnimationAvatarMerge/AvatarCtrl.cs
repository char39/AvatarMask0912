using UnityEngine;

public class AvatarCtrl : MonoBehaviour
{
    public Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetLayerWeight(1, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ani.SetTrigger("Throw");
        }
    }

    void LateUpdate()
    {
        if (ani.GetCurrentAnimatorStateInfo(1).normalizedTime > 0.95f)
            ani.SetLayerWeight(1, Mathf.Lerp(ani.GetLayerWeight(1), 0, Time.deltaTime * 10));
        else if (ani.GetCurrentAnimatorStateInfo(1).normalizedTime > 0)
            ani.SetLayerWeight(1, Mathf.Lerp(ani.GetLayerWeight(1), 1, Time.deltaTime * 10));
    }
}
