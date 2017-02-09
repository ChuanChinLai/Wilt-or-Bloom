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

        List<string> dailyOption = new List<string>();
        List<string> dailyHint = new List<string>();
        //Day 1: 
        questions.Add("Something terrible happened to me. I don’t know what to do...");
        
        dailyOption.Add("I’m sorry this happened to you.");
        dailyOption.Add("Look on the bright side.");
        dailyOption.Add("We all go through struggles and hard times.");
        options.Add(dailyOption);

        dailyHint.Add("Acknowledge that the experience has affected their life. Phrases like “This must be really tough for you,” and, “I’m so glad you are sharing this with me,” help to communicate empathy.");
        dailyHint.Add("This may sound caring and optimistic, but this can lead to suppressing emotions and holding in the pain, in hope that it will go away.");
        dailyHint.Add("This response minimizes the severity of trauma's impact on a human being. It is important to note that everyone copes with trauma differently. Also, the ability to heal and recover from trauma is impacted by an individual’s  internal and external resources.");
        hints.Add(dailyHint);
        

        //Day 2:
        questions.Add("I want to be alone...");

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
        questions.Add("I’m so angry I could hurt someone...");

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
        questions.Add("I’m too overwhelmed to deal with anything...");

        dailyOption = new List<string>();
        dailyOption.Add("Maybe we can take it step-by-step.");
        dailyOption.Add("It won’t always be like that.");
        dailyOption.Add("Think positive, there are other ways to deal with this.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("Maybe there are some situations or issues which are bothering them and they don’t know how to communicate it to others. This response can help them figure out what they can do to alleviate the overwhelming feeling. Be cautious, as the person may not be looking for advice, and instead just want you to listen.");
        dailyHint.Add("With this response, the individual may feel that you are dismissing the challenges they are going through or underestimating the traumatic experience. We never want to make the person feel like their emotions and feelings are invalid, so this is most likely not a good response as it can be interpreted in a negative way.");
        dailyHint.Add("This is a vague response that may be perceived that you do not understand the seriousness of the situation they are in. Telling someone to think positive will likely not result in a solution or feeling of care from you.");
        hints.Add(dailyHint);

        //Day 5:
        questions.Add("I’m always messing up and can’t do anything right...");

        dailyOption = new List<string>();
        dailyOption.Add("Let me help you figure things out.");
        dailyOption.Add("Let’s go do something to take your mind off things.");
        dailyOption.Add("That’s not true, you do plenty of things right.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("The individual may appreciate the offer, but may also perceive this as overstepping boundaries. If the person says “no thank you,” it could be beneficial to not push the matter any further. If the person accepts the offer, listening to them about their struggles is very important. From there, you may be able to offer some advice or words of encouragement.");
        dailyHint.Add("Offering an outlet to take their mind off of the issues could be helpful temporarily, but it is important to not force the individual to do anything, as this may have the opposite effect and may close them off from asking others for help. If the person accepts the offer to go do something, this could be a good opportunity for them to talk about what they’re struggling with, but it is imperative that the never feel forced into discussion.");
        dailyHint.Add("This response could encourage a more positive mindset, especially if you bring up example of times they have done things right. With this response, it is still very important to listen to them and to ensure you do not dismiss their emotions.");
        hints.Add(dailyHint);


        //Day 6:
        questions.Add("I don’t want to talk to you about this right now...");

        dailyOption = new List<string>();
        dailyOption.Add("If you can't talk about it, you won’t get better.");
        dailyOption.Add("Okay, let me know if you need anything.");
        dailyOption.Add("Perhaps there is someone else you would like to speak to instead.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("Forcing or making someone feel obligated to discuss traumatic experiences almost always ends negatively for both people. One of the first priorities should be to respect the other person, and by trying to force them to speak is not a way to show your respect. We understand that this can be challenging, especially if you care deeply about the person, but this response could lead to more pain and the individual refusing to approach you again.");
        dailyHint.Add("This response allows the individual to not talk about their situation, but at the same time opens the door for them to approach you when they feel ready. Keep in mind they may not go to you for support, but just offering your time in this way can help them see how much you care for them.");
        dailyHint.Add("By trying to help the individual find an alternative person to speak with, this could help them think of another person they would be more comfortable speaking with. Depending on their mood though, trying to recommend anything at all could make them result in being defensive or shutting down. It is important to listen to them and how their current mood is before responding in this way.");
        hints.Add(dailyHint);


        //Day 7:
        questions.Add("I deserve to feel this way. This is my fault...");

        dailyOption = new List<string>();
        dailyOption.Add("You shouldn’t have put yourself in that situation.");
        dailyOption.Add("We all make mistakes.");
        dailyOption.Add("This isn’t your fault and you shouldn’t blame yourself.");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("Placing the blame on the individual and enabling this mindset is very counterproductive because it does not encourage recovery, but instead dwelling with regret.");
        dailyHint.Add("This response is very risky because it can be perceived by the individual as undermining their experiences which we never want the person to feel. Acknowledging that we all make mistakes could be beneficial because the individual may realize that they are not alone in the situation they are in.");
        dailyHint.Add("This response is usually the least detrimental because it does not encourage self-blame. It’s important that the individual does not get caught up in dwelling on regrets, so by directing the conversation away from that, we can then prevent further regret during the conversation.");
        hints.Add(dailyHint);
    }
	
	// Update is called once per frame
	void Update () 
    {

	}
}
