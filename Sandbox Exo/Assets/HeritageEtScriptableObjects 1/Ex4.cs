using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weapon weapon = new Weapon(5, "iceSword",100);
        Armor armor = new Armor(10, "IceArmor", 520);
        weapon.Buy();
        weapon.Attack();
        armor.Buy();
        armor.Protect();
    }
}

public abstract class Item
{
    public int Price;
    public string Name;

    public void Buy()
    {
        Debug.Log(" You buy" + Name + " For " + Price + "Gold");
    }
}

public class Weapon : Item
{
    public int Damage;

    public Weapon(int weaponPrice, string weaponName, int weaponDamage)
    {
        this.Damage = weaponDamage;
        
    }

    public void Attack()
    {
        Debug.Log(" You deal " + Name + " damages with " + Damage);
    }
}

public class Armor : Item
{
    public int Prtotection;

    public Armor(int amorPrice, string armorName, int armorPrtotection)
    {
        Price = amorPrice;
        Name = armorName;
        Prtotection = armorPrtotection;
    }

    public void Protect()
    {
        Debug.Log(Prtotection + "damage ");
    }
}
