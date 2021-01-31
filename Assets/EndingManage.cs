using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;


public class EndingManage : MonoBehaviour
{
    public Inventory inventory;
    public LookingThroughObjective objective;
    public Transform player, ghost;
    bool startEnding = false;
   // public PlayableDirector end1,end2,end3;
    public GameObject e1, e2, e3;

    void Start()
    {

      //  end1.Stop();
     //   end2.Stop();
      //  end3.Stop();

    }

    void Update()
    {
        if(!startEnding)
        {
            //insanity end
           
            //good end
            if(objective.finishedCount == 3)
            {

                player.gameObject.SetActive(false);
                ghost.gameObject.SetActive(false); e1.SetActive(true);
              //  end1.Play();
                
                Debug.Log("GOOD");
                startEnding = true;
                Time.timeScale = 0f;
                StartCoroutine(waiting());
            }
            if (inventory.sanityPoint <= 0f)
            {
                player.gameObject.SetActive(false);
                ghost.gameObject.SetActive(false);

                e3.SetActive(true);
              //  end3.Play();
                
                Debug.Log("INSANE");
                startEnding = true;
                Time.timeScale = 0f;
                StartCoroutine(waiting());
            }
            else if(Vector3.Distance(player.position, ghost.position) <= 0.5f)
            {
                player.gameObject.SetActive(false);
                ghost.gameObject.SetActive(false); e2.SetActive(true);
              //  end2.Play();
                
                ForceDeadEnd();
               
            }
        }
    }
    
    public void ForceDeadEnd()
    {
        player.gameObject.SetActive(false);
        ghost.gameObject.SetActive(false);
        e2.SetActive(true);
       // end2.Play();
       
        Debug.Log("DEAD");
        startEnding = true;
        Time.timeScale = 0f;
        StartCoroutine(waiting());
    }


    IEnumerator waiting()
    {
        yield return new WaitForSeconds(8);
        Application.Quit();
    }
}
