using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractableChest : Interactable
{
    private Animator animator;
    [Header("Locked Chest Options")]
    public bool isOpen;

    public override void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
        isOpen = false;
    }

    protected override void Interaction()
    {
        base.Interaction();

            if (!isOpen)
            {
                OpenChest();
                print("Opening the chest");
                
            }
            else
            {
                CloseChest();
                print("Closing the chest");
            }
    }


    void CloseChest()
    {
        animator.SetTrigger("CloseChest");
        isOpen = !isOpen;
    }

    void OpenChest()
    {
        animator.SetTrigger("OpenChest");
        isOpen = !isOpen;
    }
}
