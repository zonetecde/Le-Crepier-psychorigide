using System.Collections.Generic;

namespace Le_Crêpier_psychorigide
{
    public class Step
    {
        public Step(List<string> stepL)
        {
            StepL = stepL;
        }

        public List<string> StepL { get; set; }
    }
}