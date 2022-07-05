using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterList.CharacterDataClasses
{

   public class SubClass
    {   
        public enum BARD
        { 
            SchoolOfKnowless, SchoolOfSwords, SchoolOfCharm, SchoolOfWhispers,
            SchoolOfOratory, SchoolOfCreation
        }; 
    //Знания, Мечи, Очарования, Шепот, Красноречие, созидание
        public enum BARBARIAN
        { 
            PathOfTheBerserk, PathOfTheTotemWarrior, PathOfPaffin, PathOfGuardianAncestor,
            PathOfFanatic, PathOfRagingInBattle, PathOfWildMagic, PathOfBeast
        };
    //Берсерк, тотемный воин, буревестник, предка-хранителя, фанатика, бушующего в бою, 
    //дикой магии, зверя


        public enum WARRIOR
        {
            MartialArtsMaster, MysticalKnight, Champion, Trooper,
            MysticArcher, Samurai, PurpleDragonKnight
        };
    //мастер боевых исскуств, мистический рыцарь, чемпион, кавалерист,
    //мистик лучник, самурай, рыцарь пурпурного дракона


        public enum WIZARD
        {
            SchoolOfIncarnation, SchoolOfConscription, SchoolOfIllusion, SchoolOfNecromancy,
            SchoolOfFencing, SchoolOfCharm, SchoolOfTransformation,
            SchoolOfDivination, SchoolOfWarMagic, SchoolOfBladesong, Chronomag, Graviturge, OrderOfScribes
        };
    //воплощение, вызов, иллюзия, некромантия, Ограждение, очарование, преобразование,
    //прорицание, военная магия, песнь клинка, Хрономаг, Гравитург,  Орден писцов


        public enum DRUID
        {
            CircleOfEarth, CircleOfMoon, CircleOfShepherd, CircleOfDreams, CircleOfDisputes,
            CircleOfStars, CircleOfWildFire

        };
    //круг земли, луны, пастыря, снов, спор, звёзд, дикого огня

        public enum PRIEST
        {
            DomainOfStorm, DomainOfWar, DomainOfLife, DomainOfKnowledge,
            DomainOfDeceit, DomainOfNature, DomainOfLight, DomainOfForge,
            DomainOfRest, DomainOfOrder, DomainOfDeath, DomainOfMagic,
            DomainOfTwilight, DomainOfPeace

        };
    //Домен бури, войны, жизни, знания, обмана, природы, света, кузни,
    //упокоения, порядка,смерти, магии, сумерек, мира


        public enum INVENTOR
        {
            Alchemist, Aritlerist, Warsmith, Armorsmith

        };
    //Алхимик, Аритллерист, Боевой кузнец, Бронник


        public enum WARLOCK
        {
            Archfea, Fiend, GreatAncient, Immortal, Witchblade, Celestial, Genius, Abyssal

        };
    //Арихифея, Исчадие, Великий древний, бессмертые, ведьмовский клинок, небожитель, гений, бездонный


        public enum MONK
        {
            PathOfTheOpenHand, Shadow, FourElements, Kensei, DrunkenMaster, LongDeath, SolarSoul,
            Mercy, AstralBody
        };
    //Путь открытой ладони, тени, четырех стихий, кенсея, пьяного мастера, долгой смерти, солнечной души,
    //милосердия, астрального тела
        public enum PALADIN
        {
            PathOfAllegiance, PathOfAncients, PathOfVengeance, PathOfRedemption,
            PathOfSubjugation, PathOfCrown, PathOfGlory, PathOfKeepers, Perjurer

        };
    //клятва преданности, Древних, мести, искупления, покорения, короны, славы, хрантелей, клятвопреступник 

        public enum DODGER
        {
            Thief, Assassin, MysticTrickster, Duelist, 
            Schemer, Scout, Investigator, Phantom, Soulblade

        };
    //Вор, убийца, мистический ловкач, дуэлянт, комбинатор, скаут, сыщик, фантом, клинок души


        public enum PATHFINDER
        {
            Hunter, Beastmaster, HorizonWalker, Shadowhunter,
            MonsterSlayer, FairyWanderer, SwarmKeeper
        };
    //Охотник, повелитель зверей, странник горизонта, сумрачный охотник,
    //убийца монстров, странник фей, хранитель роя


        public enum SORCERER
        {
            DragonBloodHeritage, WildMagic, DivineSoul, ShadowMagic,
            StormSorcery, AberrantMind, ClockworkSoul
        };
    //Наследие драконей крови, дикая магия,божественная душа, теневая магия,
    //штормовое колдовство, аберрантный разум, Заводная душа


   }
}
