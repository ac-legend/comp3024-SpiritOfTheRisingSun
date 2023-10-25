using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    [SerializeField] GameObject weapon;

    GameObject weaponHolder;
    GameObject weaponSheath;


    GameObject currentWeaponInHand;
    GameObject currentWeaponInSheath;

    void Start()
    {
        weaponSheath = GameObject.FindGameObjectWithTag("SheathHolder");
        currentWeaponInSheath = Instantiate(weapon, weaponSheath.transform);
    }

    public void DrawWeapon()
    {
        weaponHolder = GameObject.FindGameObjectWithTag("WeaponHolder");
        currentWeaponInHand = Instantiate(weapon, weaponHolder.transform);
        Destroy(currentWeaponInSheath);
    }

    public void SheathWeapon()
    {
        currentWeaponInSheath = Instantiate(weapon, weaponSheath.transform);
        Destroy(currentWeaponInHand);
    }

    //public void StartDealDamage()
    //{
    //    currentWeaponInHand.GetComponentInChildren<DamageDealer>().StartDealDamage();
    //}
    //public void EndDealDamage()
    //{
    //    currentWeaponInHand.GetComponentInChildren<DamageDealer>().EndDealDamage();
    //}
}
