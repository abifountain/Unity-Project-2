using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class IceDamage : Weapon.WeaponAttackEffect
{
    public int damage;
    public float time;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        // Cold damage

        ElementalEffect iceBreath = new ElementalEffect(time, StatSystem.DamageType.Cold, damage, 1.0f);

        target.Stats.AddElementalEffect(iceBreath);
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        // Physical damage from defrosting
        
        ElementalEffect warmUp = new ElementalEffect(time/2, StatSystem.DamageType.Physical, damage/2, 1.0f);

        target.Stats.AddElementalEffect(warmUp);
    }
}