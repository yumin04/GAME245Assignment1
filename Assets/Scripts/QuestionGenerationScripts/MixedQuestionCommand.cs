using UnityEngine;
using System.Collections.Generic;


public class MixedQuestionCommand : QuestionCommand
{
    List<QuestionCommand> commands = new List<QuestionCommand>();

    public MixedQuestionCommand()
    {
        commands.Add(new AdditionQuestionCommand());
        commands.Add(new SubtractionQuestionCommand());
        commands.Add(new ProductQuestionCommand());
        commands.Add(new DivisionQuestionCommand());
    }

    public override void Execute()
    {
        if (commands.Count == 0)
            return;

        int index = Random.Range(0, commands.Count);

        commands[index].Execute();
    }
}