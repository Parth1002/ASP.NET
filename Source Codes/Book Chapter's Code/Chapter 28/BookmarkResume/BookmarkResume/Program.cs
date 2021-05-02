using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Threading;

namespace BookmarkResume
{

    class Program
    {
        static void Main(string[] args)
        {
            Variable<string> name = new Variable<string>
            {
                Name = "name"
            };

            Activity wf = new Sequence
            {
                Variables =
    {
        name
    },
                Activities =
    {
        new WriteLine()
        {
            Text = "Enter your name:"
        },
        new ReadLine()
        {
            BookmarkName = "YourName",
            Result = name
        },
        new WriteLine()
        {
            Text = new InArgument<string>((env) => "Hello, " + name.Get(env)+"\nYou are reading C# 2010 Black book")
        }
    }
            };

            AutoResetEvent syncEvent = new AutoResetEvent(false);

           
            WorkflowApplication wfApp = new WorkflowApplication(wf);

           
            wfApp.Completed = delegate(WorkflowApplicationCompletedEventArgs e)
            {
              
                syncEvent.Set();
            };

       
            wfApp.Run();

         
            wfApp.ResumeBookmark("YourName", Console.ReadLine());

          
            syncEvent.WaitOne();
        }
        public sealed class ReadLine : NativeActivity<string>
        {
            [RequiredArgument]
            public InArgument<string> BookmarkName { get; set; }

            protected override void Execute(NativeActivityContext context)
            {
               
                context.CreateBookmark(BookmarkName.Get(context),
                    new BookmarkCallback(OnResumeBookmark));
            }

         
            protected override bool CanInduceIdle
            {
                get { return true; }
            }

            public void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark, object obj)
            {
              
                Result.Set(context, (string)obj);
            }
        }
    }
}
