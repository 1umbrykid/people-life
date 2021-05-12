using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Mod
{
    public class SMGBehaviour : MonoBehaviour
    {
        private FirearmBehaviour firearm;
        private AudioSource audio;
        private AudioClip launch;
        private bool altFire;
        private ProjectileLauncherBehaviour launcher;

        private void Start()
        {
            firearm = GetComponent<FirearmBehaviour>();
            audio = GetComponent<AudioSource>();
            launch = ModAPI.LoadSound("mp5g1.wav");
            launcher = GetComponent<ProjectileLauncherBehaviour>();
            firearm.ShotSounds = new AudioClip[]
            {
                ModAPI.LoadSound("mp5_1.wav"),
                ModAPI.LoadSound("mp5_2.wav"),
                ModAPI.LoadSound("mp5_3.wav"),
            };
            launcher.projectileLaunchStrength = 1f;

            Cartridge customCartridge = ModAPI.FindCartridge("9mm");
            customCartridge.name = "9mm Magazines";
            customCartridge.Damage *= .5f;
            customCartridge.StartSpeed *= 6f; //change the bullet velocity
            customCartridge.PenetrationRandomAngleMultiplier *= 1.1f; //change the accuracy when the bullet travels through an object
            customCartridge.Recoil *= .5f;
            customCartridge.ImpactForce *= 1f; //change how much the bullet pushes the target

            //set the cartridge to the FirearmBehaviour
            firearm.Cartridge = customCartridge;
            firearm.AutomaticFireInterval = 0.077f;
            firearm.InitialInaccuracy = 0.1f;
        }
        private void ContextMenu()
        {
            GetComponent<PhysicalBehaviour>().ContextMenuOptions.Buttons.Add(new ContextMenuButton("altbut", "Switch fire mode", "Switch between grenades and bullets.", new UnityAction[1]
            {
                (UnityAction)(() => ChangeFireMode())
            }));
        }
        private void Awake()
        {
            ContextMenu();
        }
        void ChangeFireMode()
        {
            if (!altFire)
            {
                // why doesnt this work the way i want it to? why cant i disable the launcher script? why must i do this?
                altFire = true;
                launcher.enabled = true;
                firearm.BulletsPerShot = 0;
                firearm.IgnoreUse = true;
                launcher.projectileAsset = ModAPI.FindSpawnable("mp5grenade");
            }
            else
            {
                altFire = false;
                firearm.BulletsPerShot = 1;
                firearm.IgnoreUse = false;
                launcher.enabled = false;
                launcher.projectileAsset = null;
            }
        }
        void Use()
        {
            if (altFire)
            {
                audio.PlayOneShot(launch, 1f);
            }
        }
    }
}