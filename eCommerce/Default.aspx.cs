using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace eCommerce
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(ConfigurationManager.AppSettings["Disclaimer"]);

            if (!IsPostBack)
            {
                Potion.CreatePotion();
                PotionRepeater.DataSource = Potion.PotionList;
                PotionRepeater.DataBind();
            }

            

        }

        public class Potion
        {

            public string Name { get; set; }
            public string PotionType { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
            public string ImageName { get; set; }


         

            public static List<Potion> PotionList { get; set; } = new List<Potion>();

            public Potion(string name, string potiontype, double price, string descritpion, string imagename)
            {
                this.Name = name;
                this.PotionType = potiontype;
                this.Price = price;
                this.Description = descritpion;
                this.ImageName = imagename;
            }

            public static void CreatePotion()
            {

                Potion UnderWater = new Potion("Deep Blue", "Curse", 210, "Allows you to breathe underwater (both types), BUT you may never return to the surface", "Assets/BreathUnderwater.jpg");
                Potion CannotDie = new Potion("Unkillable", "Ability", 1200, "No one can kill you. Your wounds regenerate instantly, and you never die, BUT you do age and get sick, so whatever would kill you would continue to do so until unless cured.", "Assets/CannotDie.jpg");
                Potion EternalLife = new Potion("Eternal Life", "Curse", 820, "You live forever, and don't age BUT you can still be killed and suffer diseases.", "Assets/EternalLife.jpg");
                Potion Flying = new Potion("FlyHigh", "Ability", 360, "You can fly, BUT suffer the consequences of speed and oxygen - the higher you go, the less oxygen you have; you are still mortal." , "Assets/Flying.jpg");
                Potion Invisible = new Potion("Invisibility", "Ability", 450 , "You can become invisible at will BUT only when you don't see a human, if you do you return visible." , "Assets/Invisibility.jpg");
                Potion Love = new Potion("Love4Ever", "Curse", 680, "Put one of your hairs in the potion, the person who drinks it will fall in love with you BUT only if that person is 70 years old, or more." , "Assets/Love.jpg");
                Potion Mind = new Potion("Mind Reader", "Ability", 1400 , "You can read minds at will, BUT when you do people hear your thoughts too." , "Assets/MindRead.jpg");
                Potion Thin = new Potion("Thin4Ever", "Curse", 9900, "You keep your current weight, forever, the moment you drink this potion, until you die (BUT that's when all the wight you didn't gain will come back!).", "Assets/StayThin.jpg");
                Potion Strength = new Potion("Lifter", "Ability",340 , "You have superstrength, BUT only in your sleep." , "Assets/SuperStrength.jpg");
                Potion Teleport = new Potion("Teleportation", "Ability", 630 , "You can teleport wherever you want, BUT each Km you travel takes 1 day from your life." , "Assets/Teleport.jpg");

                PotionList.Add(UnderWater);
                PotionList.Add(CannotDie);
                PotionList.Add(EternalLife);
                PotionList.Add(Flying);
                PotionList.Add(Invisible);
                PotionList.Add(Love);
                PotionList.Add(Mind);
                PotionList.Add(Thin);
                PotionList.Add(Strength);
                PotionList.Add(Teleport);
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string allDetails = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Dettagli.aspx?Description=" + allDetails);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string potionName = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Carrello.aspx?Name=" + potionName);
        }
    }

}