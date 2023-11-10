using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    

    public InputActionReference slashInput;

    public List<GameObject> Hitboxes;
    private IDictionary<string, HitboxScript> Attacks;
    // Start is called before the first frame update
    void Start()
    {
        Attacks = new Dictionary<string, HitboxScript>();
        for (int i = 0; i < Hitboxes.Count; i++) {
            Attacks.Add(Hitboxes[i].name, Hitboxes[i].GetComponent<HitboxScript>());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetHitboxActive(HitboxScript hitbox) {
        if (!hitbox.gameObject.activeSelf && !hitbox.coolingDown){
            StartCoroutine(StartAttack(hitbox));
        }
    }

    IEnumerator StartAttack(HitboxScript hitbox) {
        yield return new WaitForSeconds(hitbox.windupTimeSeconds);
        hitbox.gameObject.SetActive(true);
        yield return new WaitForSeconds(hitbox.activeTimeSeconds);
        hitbox.coolingDown = true;
        yield return new WaitForSeconds(hitbox.cooldownTimeSeconds);
        hitbox.coolingDown = false;

        yield return null;
    }
}
