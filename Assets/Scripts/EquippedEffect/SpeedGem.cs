using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class SpeedGem : EquipmentItem.EquippedEffect
{
     private int agilityModifier = 2; 
     public CreatorKitCode.StatSystem.StatModifier newModifier; 

     public override void Equipped(CharacterData user)
     {
          newModifier = new StatSystem.StatModifier {
          ModifierMode = StatSystem.StatModifier.Mode.Absolute, 
          Stats = new StatSystem.Stats{agility = agilityModifier}};

          user.Stats.AddModifier(newModifier);
     }
     public override void Removed(CharacterData user) 
     { 
          newModifier = new StatSystem.StatModifier {
          ModifierMode = StatSystem.StatModifier.Mode.Absolute, 
          Stats = new StatSystem.Stats{agility = agilityModifier}};

          user.Stats.RemoveModifier(newModifier);
     }
}
