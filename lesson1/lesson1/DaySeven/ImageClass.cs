using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DaySeven
{
    internal class ImageClass
    {
        public static byte[] Logo
        {
            get
            {
                byte[] _logoBytes = null;
                if(_logoBytes == null)
                {
                    _logoBytes = File.ReadAllBytes(@"c: \temp\html_Logo.png");
                }
                return _logoBytes;
            }
        }
    }
}
