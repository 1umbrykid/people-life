using UnityEngine;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Events;
using UnityEditor;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            CategoryBuilder.Create("People-Life", "Rise and Shine", ModAPI.LoadSprite("category.png"));
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Pistol"),
                    NameOverride = "Glock 17",
                    NameToOrderByOverride = "Glock 17",
                    DescriptionOverride = "A semi-automatic 9mm pistol",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("pistol.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("pistolViewmodel.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "9mm Magzine";
                        customCartridge.Damage *= 0.8f;
                        customCartridge.StartSpeed *= 1.5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.1f;
                        customCartridge.Recoil *= 0.7f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("bang.wav"),
                        };


                        Instance.FixColliders();

                    }
                }
            );

ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Submachine Gun"),
                    NameOverride = "MP5",
                    NameToOrderByOverride = "MP5",
                    DescriptionOverride = "A automatic weapon with greande laucher that shares the same ammo from glock 17",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("mp5.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("mp5Viewmodel.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "9mm Magzine";
                        customCartridge.Damage *= 0.5f;
                        customCartridge.StartSpeed *= 1.5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.3f;
                        customCartridge.Recoil *= 0.9f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("mp5_1.wav"),
                            ModAPI.LoadSound("mp5_2.wav"),
                            ModAPI.LoadSound("mp5_3.wav"),
                        };


                        Instance.FixColliders();

                    }
                }
            );
            
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Shotgun"),
                    NameOverride = "SPAS-12",
                    NameToOrderByOverride = "SPAS-12",
                    DescriptionOverride = "A shotgun that can fire 2 barrels at the same time",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("spas.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("spasViewmodel.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "12 gauge";
                        customCartridge.Damage *= 0.3f;
                        customCartridge.StartSpeed *= 1.5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.1f;
                        customCartridge.Recoil *= 0.9f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("shotgun.wav"),
                        };


                        Instance.FixColliders();

                    }
                }
            );

ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Revolver"),
                    NameOverride = "357",
                    NameToOrderByOverride = ".357",
                    DescriptionOverride = "A revolver with capacity of 6 rounds, and incredible you can place 6 of they at the same time with only your hand",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("revolver.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("revolverViewmodel.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("38 Special");
                        customCartridge.name = "357 Bullets";
                        customCartridge.Damage *= 1.0f;
                        customCartridge.StartSpeed *= 1.7f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.6f;
                        customCartridge.Recoil *= 0.9f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("357_1.wav"),
                            ModAPI.LoadSound("357_2.wav"),
                        };


                        Instance.FixColliders();

                    }
                }
            );            
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Blaster Rifle"),
                    NameOverride = "(WIP) Tau Cannon",
                    NameToOrderByOverride = "Tau",
                    DescriptionOverride = "A experimental high velocity projectile weapon",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("tau.png"),
                    AfterSpawn = (Instance) =>
                    {
                        
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(0).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(1).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(2).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(4).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(5).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(6).gameObject);
                        UnityEngine.Object.Destroy(Instance.transform.GetChild(7).gameObject);

                        var firearm = Instance.GetComponent<BlasterBehaviour>();

                        var Bolt = firearm.Bolt;
                        Color c1 = new Color(244, 100, 1, 255);
                        Color c2 = new Color(244, 100, 1, 255);

                        Bolt.GetComponent<BlasterboltBehaviour>().Trail.startColor = c1;
                        Bolt.GetComponent<BlasterboltBehaviour>().Trail.endColor = c1;

                         firearm.Clips = new AudioClip[]
                        {
                            ModAPI.LoadSound("tau_1.wav"),
                            ModAPI.LoadSound("tau_2.wav"),
                            ModAPI.LoadSound("tau_3.wav")
                            
                        };

                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("tauViewmodel.png");
                        Instance.FixColliders();

                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Sniper Rifle"),
                    NameOverride = "Sniper",
                    NameToOrderByOverride = "Sniper",
                    DescriptionOverride = "A sniper with a high capacity of damage in long ranges",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("sniper.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("sniperViewmodel.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("38 Special");
                        customCartridge.name = "Sniper Magzines";
                        customCartridge.Damage *= 1.5f;
                        customCartridge.StartSpeed *= 1.7f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.8f;
                        customCartridge.Recoil *= 1.0f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("sniper_1.wav"),
                            ModAPI.LoadSound("sniper_2.wav"),
                            ModAPI.LoadSound("sniper_3.wav"),
                        };


                        Instance.FixColliders();

                    }
                }
            );
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), 
                    NameOverride = "Tranquilizer", // Name.
                    NameToOrderByOverride = "Bolt", //  
                    DescriptionOverride = "It was meant to be a tranquilizer but it actually a explosive bolts",// Description
                    CategoryOverride = ModAPI.FindCategory("Melee"),//Category
                    ThumbnailOverride = ModAPI.LoadSprite("bolt.png"),//Thumbnail
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("boltViewmodel.png", 1f);
 
                    }
                }
            );
           ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Crossbow"),
                    NameOverride = "Crossbow",
                    NameToOrderByOverride = "Crossbow",
                    DescriptionOverride = "A crossbow that throw tranquilizers",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("crossbow.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("crossbowViewmodel.png");
                        Instance.GetComponent<SpriteRenderer>().sortingOrder = 10;
                        Instance.GetComponent<ProjectileLauncherBehaviour>().projectileAsset = ModAPI.FindSpawnable("Tranquilizer");
                        Instance.GetComponent<ProjectileLauncherBehaviour>().launchSound = ModAPI.LoadSound("bow.wav");
                        Instance.FixColliders();
                    }
                }
           );
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Handgrenade"), 
                    NameOverride = "Grenade", 
                    DescriptionOverride = "An explosive that was used on uhhh... lets say into a war",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("grenade.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("gViewmodel.png");
                        Instance.FixColliders();
                        Instance.GetComponent<PhysicalBehaviour>().OverrideImpactSounds = new AudioClip[] 
						    {ModAPI.LoadSound("g_hit.wav")};
                    
                    }
                }
            );
           ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Stunner"),
                    NameOverride = "(Very WIP) Shock Roach",
                    NameToOrderByOverride = "Shock",
                    DescriptionOverride = "wait",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("shocker.png"),
                    AfterSpawn = (Instance) =>
                    {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("smodel.png");
                    Instance.FixColliders();
                }
             }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Pistol"),
                    NameOverride = "Desert Eagle",
                    NameToOrderByOverride = "Desert Eagle",
                    DescriptionOverride = "similiar to revolver but with more ammo",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("dmodel.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("desert.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "Deagle Magazines";
                        customCartridge.Damage *= 0.7f;
                        customCartridge.StartSpeed *= 1.7f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.3f;
                        customCartridge.Recoil *= 1.0f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("deagle.wav")
                        };

                        Instance.FixColliders();
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Pistol"),
                    NameOverride = "Assassin Glock",
                    NameToOrderByOverride = "Assasin Glock",
                    DescriptionOverride = "A glock used by the female assassins, it contains a silencer",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("spmodel.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("spistol.png");
                        
                        
                        var firearm = Instance.GetComponent<FirearmBehaviour>();

                        Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                        customCartridge.name = "9mm Magazines";
                        customCartridge.Damage *= 0.3f;
                        customCartridge.StartSpeed *= 1.7f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 0.1f;
                        customCartridge.Recoil *= 0.3f;
                        customCartridge.ImpactForce *= 0.7f;

                        firearm.Cartridge = customCartridge;

                        firearm.ShotSounds = new AudioClip[]
                        {
                            ModAPI.LoadSound("sp_1.wav"),
                            ModAPI.LoadSound("sp_2.wav"),
                        };

                        Instance.FixColliders();
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"),
                    NameOverride = "Battery",
                    NameToOrderByOverride = "Battery",
                    DescriptionOverride = "dudu power 15% dudu",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("prop1t.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("prop1.png");
                         Instance.FixColliders();
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"),
                    NameOverride = "Medkit",
                    NameToOrderByOverride = "Medkit",
                    DescriptionOverride = "just touch it and you will heal yourself lol",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("prop2t.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("prop2.png");
                         Instance.FixColliders();
                    }
                }
            );
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), 
                    NameOverride = "Crowbar", 
                    DescriptionOverride = "A crowbar that you slam against people to hurt they",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("ct.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("crowbar.png");
                        Instance.FixColliders();
                        Instance.GetComponent<PhysicalBehaviour>().OverrideImpactSounds = new AudioClip[] 
                            {ModAPI.LoadSound("crowbar.wav")};
                    
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Ion Cannon"),
                    NameOverride = "Displacer",
                    NameToOrderByOverride = "Displacer",
                    DescriptionOverride = "A weapon that throws giant engery ball that kills anything on their way, so yeah its a bfg, also cool fact: in portal 2, there is a line from Cave Johnson where he very encripted mention the displacer",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("displacer.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("gune.png");
                        Instance.FixColliders();
                    }
                }
            );
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), 
                    NameOverride = "Pipe Wreach", 
                    DescriptionOverride = "my a*s is heavy",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("p.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("pipe.png");
                        Instance.FixColliders();
                        Instance.GetComponent<PhysicalBehaviour>().OverrideImpactSounds = new AudioClip[] 
                            {ModAPI.LoadSound("pwhit.wav")};
                    
                    }
                }
            ); 
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Knife"), 
                    NameOverride = "Combat Knife", 
                    DescriptionOverride = "perfect for tatical cuts",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("k.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("knife.png");
                        Instance.FixColliders();
                        Instance.GetComponent<PhysicalBehaviour>().OverrideImpactSounds = new AudioClip[] 
                            {ModAPI.LoadSound("knifehit.wav")};
                    
                    }
                }
            ); 
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Red Barrel"), 
                    NameOverride = "Explosive Barrel", 
                    DescriptionOverride = "A barrel filled with gas, perfect to cause explosions heehhe",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("boom.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("b.png");
                        Instance.FixColliders();
                    }
                }
            );
			
 ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "(WIP)Hazardous EnVironment Suit", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "HEV",
                    DescriptionOverride = "For use in hazardious condtions.", //new item description
                    CategoryOverride = ModAPI.FindCategory("People-Life"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("hev/UpperBody.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("upperchestplate.png"); //get the SpriteRenderer and replace its sprite with a custom one

                        int PartCount = 9;

                        if (!Instance.GetComponent<ArmorBehaviour>())
                            Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();

                        ArmorProperties prop = new ArmorProperties();
                        
                        prop.armorPiece = "UpperBody";
                        prop.armorTier = 4;
                        prop.sprite = "hev/UpperBody.png";

                        armor.prop = prop;
                        armor.SetProperties();

                        ArmorProperties[] armProp = new ArmorProperties[PartCount - 1];

                        armProp[0].sprite = "hev/MiddleBody.png";
                        armProp[0].armorPiece = "MiddleBody";

                        armProp[1].sprite = "hev/LowerBody.png";
                        armProp[1].armorPiece = "LowerBody";

                        armProp[2].sprite = "hev/UpperLeg.png";
                        armProp[2].armorPiece = "UpperLeg";
                        armProp[2].clone = true;

                        armProp[3].sprite = "hev/LowerLeg.png";
                        armProp[3].armorPiece = "LowerLeg";
                        armProp[3].clone = true;

                        armProp[4].sprite = "hev/foot.png";
                        armProp[4].armorPiece = "Foot";
                        armProp[4].clone = true;

                        armProp[5].sprite = "hev/uparm.png";
                        armProp[5].armorPiece = "UpperArm";
                        armProp[5].clone = true;

                        armProp[6].sprite = "hev/la.png";
                        armProp[6].armorPiece = "LowerArm";
                        armProp[6].clone = true;

                        armProp[7].sprite = "hev/helmet.png";
                        armProp[7].armorPiece = "Head";

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                            armor.SpawnOtherParts(armProp);
                        }

                        Instance.FixColliders();
                    }
                }
            );
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Stormbaan"), 
                    NameOverride = "(WIP)Gluon Gun", 
                    DescriptionOverride = "Quantum Desitabilazer",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("egon/g1.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("egon/g1.png");
                        Instance.FixColliders();
                    }
                }
            );
             ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), 
                    NameOverride = "Gluon Gun BackPack", 
                    DescriptionOverride = "A prop for the Gluon Gun, You can connect they with a cable if you want",
                    CategoryOverride = ModAPI.FindCategory("People-Life"),
                    ThumbnailOverride = ModAPI.LoadSprite("egon/g2.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("egon/g2.png");
                        Instance.FixColliders();
                    }
                }
            );						
        }
    }
}
