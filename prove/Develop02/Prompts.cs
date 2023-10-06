using System;

public class Prompt {
        public List<string> _prompts = new List<string>();

        public Prompt() {
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
            _prompts.Add("How do you feel today?");
    }

    public string PromptGenerator()
    {
        Random random = new Random();
        int rand_number = random.Next(0,_prompts.Count());
        return _prompts[rand_number];
    }
}