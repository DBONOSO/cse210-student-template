using System;

public class Prompt {
        public List<string> _prompts = new List<string>();

        public Prompt() {
            _prompts.Add("How do you feel today?");
            _prompts.Add("What brings you joy?");
            _prompts.Add("What is something that you would like to change about yourself?");
            _prompts.Add("Do you felt happy today?");
            _prompts.Add("What was your greatest fear?");
            _prompts.Add("What are your top priorities for the day?");
            _prompts.Add("What did you learn today?");
    }

    public string PromptGenerator()
    {
        Random random = new Random();
        int rand_number = random.Next(0,_prompts.Count());
        return _prompts[rand_number];
    }
}