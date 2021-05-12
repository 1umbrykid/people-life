using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Mod
{
    public class ShieldBehaviour : MonoBehaviour
    {
        public float shieldPower;
        public float initialPower;

        public bool shieldRegen;
        public float shieldRegenRate;
        public float shieldRegenCooldown;

        public bool shieldActive = true;
        public bool regenActive;

        public CircleCollider2D shieldCollider;
        public BoxCollider2D baseCollider;

        public SpriteRenderer shieldVisual;

        public PhysicalBehaviour properties;

        public int baseTier;

        void Start()
        {
            initialPower = shieldPower;
            properties = GetComponent<PhysicalBehaviour>();
            ActivateShield();
        }
        void Update()
        {
            if (shieldPower < 0)
            {
                DeactivateShield();
            }
        }
        private void Shot(global::Shot shot)
        {
            if (shieldPower - shot.damage >= 0)
            {
                shieldPower -= shot.damage;
            }
            else
            {
                shieldPower = -1;
            }
            ModAPI.Notify(shieldPower.ToString());
            if (regenActive)
            {
                StopCoroutine(Regen(shieldRegenCooldown, shieldRegenRate));
                StartCoroutine(Regen(shieldRegenCooldown, shieldRegenRate));
            }
        }
        public void DeactivateShield()
        {
            shieldPower = 0;
            ModAPI.Notify("Shield Deactivated");
            baseCollider.enabled = true;
            shieldCollider.enabled = false;
            shieldActive = false;
            if (baseTier == 2)
            {
                properties.Properties = ModAPI.FindPhysicalProperties("Bowling pin");
            }
            if (shieldRegen)
            {
                StartCoroutine(Regen(shieldRegenCooldown, shieldRegenRate));
            }
        }
        public void ActivateShield()
        {
            ModAPI.Notify("Shield Activated");
            baseCollider.enabled = false;
            shieldCollider.enabled = true;
            shieldActive = true;
            if (baseTier == 2)
            {
                properties.Properties = ModAPI.FindPhysicalProperties("Metal");
            }
            ModAPI.Notify("shield is " + shieldCollider.ToString());
            ModAPI.Notify("shield enabled/disabled state is " + shieldCollider.enabled.ToString());
            ModAPI.Notify("shield radius is " + shieldCollider.radius.ToString());
        }
        public IEnumerator Regen(float Cooldown, float Rate)
        {
            ModAPI.Notify("Shield Regenerating");
            regenActive = true;
            yield return new WaitForSeconds(Cooldown);
            for (float I = 0; I < initialPower; I += Time.deltaTime * Rate)
            {
                shieldPower = I;
            }
            ActivateShield();
            regenActive = false;
            ModAPI.Notify(shieldPower.ToString());
        }
    }
}