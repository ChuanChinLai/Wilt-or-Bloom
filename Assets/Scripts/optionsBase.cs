using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class optionsBase : MonoBehaviour 
{
    //question, options and hints 
    //Example: options[day][option index];
    public List<string> questions = new List<string>();

    public List<List<string>> options = new List<List<string>>();
    public List<List<string>> hints = new List<List<string>>();

	// Use this for initialization
	void Start () 
    {
        //Day 1: 
        questions.Add("Something terrible happened to me. I don’t know what to do.");
        
        List<string> dailyOption = new List<string>();
        dailyOption.Add("I’m sorry this happened to you.");
        dailyOption.Add("Look on the bright side.");
        dailyOption.Add("We all go through struggles and hard times.");
        options.Add(dailyOption);

        
        List<string> dailyHint = new List<string>();
        dailyHint.Add("Acknowledge that the experience has affected their life. Phrases like “This must be really tough for you,” and, “I’m so glad you are sharing this with me,” help to communicate empathy.");
        dailyHint.Add("This may sound caring and optimistic, but this can lead to suppressing emotions and holding in the pain, in hope that it will go away.");
        dailyHint.Add("This response minimizes the severity of trauma's impact on a human being. It is important to note that everyone copes with trauma differently. Also, the ability to heal and recover from trauma is impacted by an individual’s  internal and external resources.");
        hints.Add(dailyHint);

        //Day 2:
        questions.Add("I want to be alone.");

        dailyOption = new List<string>();
        dailyOption.Add("Let's go out somewhere, you’ll feel better.");
        dailyOption.Add("It is just a matter of time, you’ll be fine.");
        dailyOption.Add("Okay, I’ll leave you alone, but just know that I’m here for you.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("This response may be perceived as positive or negative, it’s  important that the person is not pushed. Slight encouragement to not be alone can be helpful, but the person may really need time alone as well.");
        dailyHint.Add("This answer could be acceptable if you have already listened to their story. If not, it can be perceived as though you are minimizing or dismissing the reasons behind them wanting to be alone.");
        dailyHint.Add("This response is often the best because you are validating their want/need to be alone without judgment.  It also reassures them that you are available for support if and when they choose to accept your help.");
        hints.Add(dailyHint);

        //Day 3:
        questions.Add("I’m so angry I could hurt someone.");

        dailyOption = new List<string>();
        dailyOption.Add("Let's go out somewhere, you’ll feel better.");
        dailyOption.Add("I can see you are very upset, I am sorry you have to deal with this.");
        dailyOption.Add("Yeah, maybe that would make you feel better.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("You should not use this response as it is dismissive and judgmental. It is possible that they are reacting this way because of previous life experiences.");
        dailyHint.Add("Although it might seem counter intuitive to acknowledge the fact that they feel like acting in violence, this is a good response because you are showing empathy towards them as well as acknowledging their anger.");
        dailyHint.Add("You should avoid making statements such as this as you might encourage the person to act on their anger instead of dealing with it in a healthy manner.");
        hints.Add(dailyHint);


        //Day 4:
        questions.Add("I’m so angry I could hurt someone.");

        dailyOption = new List<string>();
        dailyOption.Add("Let's go out somewhere, you’ll feel better.");
        dailyOption.Add("I can see you are very upset, I am sorry you have to deal with this.");
        dailyOption.Add("Yeah, maybe that would make you feel better.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("You know you shouldn’t hurt other people.");
        dailyHint.Add("I can see you are very upset, I am sorry you have to deal with this.");
        dailyHint.Add("Yeah, maybe that would make you feel better.");
        hints.Add(dailyHint);


	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
