using System;
using System.Linq;
using System.Media;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using static MotivationBuddy.Menus;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;


namespace MotivationBuddy
{
    internal class Program
    {

        public static AIHeroClient myhero
        {
            get { return ObjectManager.Player; }
        }
        
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }
        


        public static void Loading_OnLoadingComplete(EventArgs args)
        {
            Chat.Print("FlameBuddy | Movee Version ", System.Drawing.Color.Violet);
            Chat.Say("/all Good lags and have feeders!");

            Menus.CreateMenu();
            Game.OnTick += Game_OnTick;
            Game.OnNotify += OnGameNotify;
            Game.OnEnd += Game_OnEnd;
        }

        private static void Game_OnEnd(EventArgs args)
        {
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");


            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");
            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");


            Chat.Say("/all IZI GAME IZI LIFE UNINSTALL LOL RETARDS");

        }

        private static void Game_OnTick(EventArgs args)
        {
        }

        internal static void OnGameNotify(GameNotifyEventArgs args)
        {
            var Sender = args.NetworkId;

            var Ally = EntityManager.Heroes.Allies.FirstOrDefault(e => e.HealthPercent > 20);
            var AllyD = EntityManager.Heroes.Allies.FirstOrDefault(e => e.HealthPercent < 30);
            var AllyK = EntityManager.Heroes.Allies.LastOrDefault();
            var AllyDead = EntityManager.Heroes.Allies.FirstOrDefault(e => e.IsDead);
            

            if (FirstMenu["EnableM"].Cast<CheckBox>().CurrentValue)
            {
                switch (args.EventId)
                {
                    case GameEventId.OnChampionKill:
                        if ((Sender == AllyK.NetworkId || Sender == AllyD.NetworkId ) && Sender != myhero.NetworkId)
                        {
                            string[] Motivation1 = { "REPORTED for ksing", "/all how did you die from this retard?"};

                            Random RandName = new Random();
                            string Temp1 = Motivation1[RandName.Next(0, Motivation1.Length)];

                            Core.DelayAction(() => Chat.Say(Temp1), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                            Core.DelayAction(() => Chat.Say("/Masterybadge"), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                        }
                        if (Sender == myhero.NetworkId)
                        {

                            string[] KillMessages = {"/all REPORTED FOR INTING", "/ALL ez", "/all pls uninstall lol", "/all u are getting reported for intentional feeding" };
                            Random RandNamex = new Random();
                            string Temp11 = KillMessages[RandNamex.Next(0, KillMessages.Length)];

                            Core.DelayAction(() => Chat.Say(Temp11), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                            Core.DelayAction(() => Chat.Say("/Masterybadge"), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                            Player.DoEmote(Emote.Laugh);

                        }
                        break;
                    case GameEventId.OnChampionDie:

                        if ((Sender == myhero.NetworkId)) {
                            string[] Flame = { "/all KYS", "/all COMMIT SUICIDE IRL", "/all JUMP OFF A BRIDGE", "/all REPORTED FOR SCRIPT", "/all GET CANCER EB0LA KID", "/all U ARE A WASTE OF OXYGEN", "/all NICE COUNTERPLAY", "/all GET AIDS", "/all JUST KILL YOURSELF"};

                            Random RandNamee = new Random();
                            string Temp10 = Flame[RandNamee.Next(0, Flame.Length)];

                            Core.DelayAction(() => Chat.Say(Temp10), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                            Core.DelayAction(() => Chat.Say("/Masterybadge"), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                           

                        }

                        if ((Sender == AllyD.NetworkId || Sender == AllyK.NetworkId) && Sender != myhero.NetworkId)
                        {
                            string[] Motivation2 = { "/ALL REPORT THIS RETARD FOR FEEDING" , "JUMP OFF A BRIDGE RETARD" , "COMMIT SUICIDE" , "NICE BRAIN", "REPORTED FOR FEEDING", "/ALL PLZ REPORT THIS RETARD" };

                            Random RandName = new Random();
                            string Temp2 = Motivation2[RandName.Next(0, Motivation2.Length)];

                            Core.DelayAction(() => Chat.Say(Temp2), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                            Core.DelayAction(() => Chat.Say("/Masterybadge"), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                        }
                        break;
                }
            }
            if (FirstMenu["EnableT"].Cast<CheckBox>().CurrentValue)
            {
                var Enemy = EntityManager.Heroes.Enemies.LastOrDefault(e => e.HealthPercent < 30 && !e.IsDead);
                var EnemyD = EntityManager.Heroes.Enemies.FirstOrDefault(e => !e.IsDead);
                var EnemyDD = EntityManager.Heroes.Enemies.First();
                var EnemyDDD = EntityManager.Heroes.Enemies.Last();
                var EnemyDead = EntityManager.Heroes.Enemies.FirstOrDefault(e => e.IsDead);
                





                switch (args.EventId)
                {
                    case GameEventId.OnChampionDie:
                        if (Sender == Enemy.NetworkId || Sender == EnemyD.NetworkId || Sender == EnemyDD.NetworkId || Sender == EnemyDDD.NetworkId || Sender != myhero.NetworkId)
                        {
                            string[] Tilt2 = { "/all REPORT " + EnemyDead.ChampionName + "FOR INTING", "/all x9 this " +EnemyDead.ChampionName+" for troll ty", "/all " + EnemyDead.ChampionName +" you are reported for trolling enjoy ban" };

                            Random RandName = new Random();
                            string Temp2 = Tilt2[RandName.Next(0, Tilt2.Length)];

                            Core.DelayAction(() => Chat.Say(Temp2), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                            Player.DoEmote(Emote.Laugh);
                            Core.DelayAction(() => Chat.Say("/Masterybadge"), FirstMenu["Delay"].Cast<Slider>().CurrentValue);
                        }
                        break;
                }
            }
        }
        


    }
}