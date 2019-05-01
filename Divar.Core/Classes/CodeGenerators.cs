using System;
using System.Collections.Generic;
using System.Text;

namespace Divar.Core.Classes
{
    public class CodeGenerators
    {
        public static string ActiveCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
        }

        public static string ImgCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
        }
    }
}
