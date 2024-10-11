  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator Lookat;
    [SerializeField] Animator turnaround;
    bool isclicked;
    // Start is called before the first frame update
    void Start()
    {
        isclicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && isclicked == false)
        {
            isclicked = true;
            animator.SetBool("SceneChange", true);
            Lookat.SetBool("Look", true);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            turnaround.SetBool("Turning", true);
        }
    }

    public void Turn()
    {
        turnaround.SetBool("Turning", true);
    }
}
