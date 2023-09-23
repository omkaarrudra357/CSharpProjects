using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("stop");
        }
        public virtual void PauseMediaContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("continue");
        }
    }
    internal class AudioContent : MediaContent 
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("start");
        }
    }
    internal class VideoContent : MediaContent
    {

    }
    internal class MediaTester
    {
        public static void Testone()
        {

        }
    }
}
