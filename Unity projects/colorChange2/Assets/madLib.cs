using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madLib : MonoBehaviour {
   public string[] verbs = {"medicate","blindside","boogie","flap","trip","swat","suck in","harass","trap","snoop",
"explode","sketchy","scatter","challenge","fight"};

   public string[] nouns = {"friendly grandma","french chef","president of the night",
"candlestick maker","coffee pot","national security agency","tank","international law enforcement agency",
"skinny woman","private investor","sketchy person","stock car driver","bloody pig intestine","telephone opperator","mad cow"};

   public string[] nounPlural = {"police squads","sneaky criminals","keepsake machetes","gaming laptops",
"hissy fits","dragons","patrolmen","perverts","toilet seats","haunted graveyards"};

   public string[] adjective = {"internet worthy","hilarious","sexy","hot","tactful","bearded",
"duck-like","violent","slimy","insanely creepy","self-centered","naked","angry","shaky",
"deep","sickly","zippy","sticky","fluffy","frozen"};
    public string[] verbPresentTense = { "yell", "hiss", "lie", "bathe", "shave", "convulse", "sigh", "plummet" };
    public string[] verbThirdPerson = { "snorts", "chokes", "frowns", "laughs", "waddles", "cries", "snarls" };
    public string[] bodyPartPlural = {"belly button","ankles","eye balls","knees","ears","nose","elbows","toe nails","forearms",
    "shoulders"};
    public string[] timePeriod = { "second", "minute", "morning", "weekend", "month", "year", "century", "millennium" };
    public string[] timePeroidPlural = { "nanoseconds", "hours", "days", "nights", "fortnights", "months", "years", "centuries" };
    public string[] colors = { "atomic tangerine","bicycle yellow","Caribbean green","chartreuse","enchanted forest green","pimpin' purple","Hawaii Aloha Aquamarine","fuzzy wuzzy brown",
    "deadly nightshade red"};
    public int[] number = { 3, 4, 5, 6, 7, 8, 9 };
    public string[] foodSingular = { "pumpkin seed", "blue cheese", "taco", "liver", "grilled cheese sandwich", "lima bean", "garlic crouton" };
    public string[] foodPlural = { "corndogs", "lentils", "meat balls", "wasibi chicken fingers", "ramen noodles", "deep fried pickles", "fire roasted peppers" };
    public string[] liquid = { "water", "oil", "tuna fish water", "vodka", "melted ice cream", "gasoline", "orange soda", "pineapple juice" };
    public string[] clothesPlural = { "boxers", "shirts", "socks", "hats", "ties", "pairs of pants", "belts" };
     
    // Use this for initialization
    void Start () {
        string verb = verbs[Random.Range(0,verbs.Length)];
        string noun = nouns[Random.Range(0, nouns.Length)];
        string nounP = nounPlural[Random.Range(0,nounPlural.Length)];
        string adj = adjective[Random.Range(0, adjective.Length)];
        string verbPT = verbPresentTense[Random.Range(0, verbPresentTense.Length)];
        string verbTP = verbThirdPerson[Random.Range(0, verbThirdPerson.Length)];
        string bodyPP = bodyPartPlural[Random.Range(0, bodyPartPlural.Length)];
        string timeP = timePeriod[Random.Range(0, timePeriod.Length)];
        string timePP = timePeroidPlural[Random.Range(0, timePeroidPlural.Length)];
        string color = colors[Random.Range(0, colors.Length)];
        int num = number[Random.Range(0, number.Length)];
        string foodS = foodSingular[Random.Range(0, foodSingular.Length)];
        string foodP = foodPlural[Random.Range(0, foodPlural.Length)];
        string liq = liquid[Random.Range(0, liquid.Length)];
        string clothesP = clothesPlural[Random.Range(0, clothesPlural.Length)];
        print("Kids' Ideas About Love");
        print("Love and Marriage: ");
        print("If falling in love is anything like learning how to ("+verbPT+"), I don't want to do it. It takes too long. -- Glenn, age 7");
        print("No one is sure why it happens, but I heard it has something to do with how you ("+verbPT+"). That's why ("+nounP+") and ("+liq+") are so popular. -- Mae, age("+num+")");
        print("Love is ("+adj+")...but I still might try it sometime. -- Floyd, age 9");
        print("Kissing:");
        print("Never kiss in front of other people. It's a big embarrassing thing if anybody sees you. But if nobody sees you, I might be willing to try it with a ("+adj+") boy, but just for a few ("+timePP+") . -- Kally, age 9");
        print("How People In Love Act:");
        print("Romantic adults usually are all dressed up, so if they are just wearing ("+clothesP+") it might mean they used to go out or they just broke up.-- Sarah, age("+num+")");
        print("Many daters just eat ("+foodP+") and ("+foodP+") and talk about love. -- Craig, age 9");
        print("Strategies For Making People Fall In Love With You:");
        print("Tell them that you own a whole bunch of ("+foodS+") stores. -- Del, age 6");
        print("Shake your ("+bodyPP+") and hope for the best. -- Camille, age 9");
        print("Don't do things like have ("+adj+"), ("+color+") ("+clothesP+"). You might get attention, but attention ain't the same thing as love. -- Alonzo, age 9");
        print("What Most People Are Thinking When They 'Say I Love You':");
        print("The person is thinking: 'Yeah, I really do love him. But I hope he ("+verbTP+") at least once a ("+timeP+"). -- Michelle, age 9");
        print("Titles of Love Ballads You Can Sing To Your Loved One:");
        print("'I Like ("+foodP+") from a ("+noun+"), and I Love You!' -- Eddie, age 6");
        print("'Honey, I Got Your ("+bodyPP+") and Your ("+clothesP+") On My Mind.' -- Sharon, age 9");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
