using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGallery4UniversalV2
{
    static class clsUtil
    {

        public static string EmptyIfNull(this string prString)
        {
            return prString == null ? string.Empty : prString;
        }

    }
}
