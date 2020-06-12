using UnityEngine;

public class SwordAnim : MonoBehaviour {

    public Animator anim;

    public void EndAnimation()
    {
        anim.SetBool("Swing", false);
    }
}
