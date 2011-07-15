using FubuMVC.Core.Continuations;
using FubuMVC.WebForms;

namespace MyApplication.Actions.Todo
{
    public class NewAction
    {
        public NewTodoOutput Get(NewTodo input)
        {
            return new NewTodoOutput{ Todo = new Todo()};
        }

        public FubuContinuation Post(CreateTodo input)
        {
            return FubuContinuation.RedirectTo(new ViewTodo());
        }
    }

    public class NewTodo{}
    public class NewTodoOutput
    {
        public Todo Todo { get; set; }
    }
    public class CreateTodo{}
    public class ViewTodo{}

    public class New : FubuPage<NewTodoOutput>{}
}