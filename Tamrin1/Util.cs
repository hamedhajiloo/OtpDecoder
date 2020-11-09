﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tamrin1
{
    public static class Util
    {
        public static bool IsStandard(string input)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
            if (!asciiBytes.Any())
                return false;

            foreach (var asciiByte in asciiBytes)
            {
                var result = ((asciiByte >= 65 && asciiByte <= 90) || (asciiByte >= 97 && asciiByte <= 122));
                if (result == false)
                    return false;
            }

            return true;
        }

        public static List<string> Inpute()
        {
            return new List<string>
            {
                "1D1CF7534D161C015243171D1505490F4E1341004F011D5353140F0C0B004A00260748041E0441141259541841181959491E55041D54074E1C4F18435207550049030A0E4F4331480C0C0F535720424B650D1D530901",
                "101BE701000D061817001B1C4108490C0710451D4355011C00050301FC110E572E071C00521A544D0D10561E0F0B4B530619451807114845151C10BE5342191D460B4100424E365406170B003D0E0E18",
                "1E1CF707481C1D550B4F074F150C490F054459161A5511124E41031D4E1C41556F00000C1C1800140E0C00140002F954455459181CE61A45591D1C4B48165B540D4E2745011C1C00250E1C44",
                "1E1BE018001E0603175352160E11000C0B054E10011252124E054C1F1B175E4F3C1148041C170001081F4557081F4B450404540E4903015411000058000B015AB44EF9004F3D114513090B4E57290D1C4B001A47",
                "1918F31D53590E0717001C00150C490F095F000903141C1D490F0B4F07160E4539111A1C061B4903065700E1414C2F5700134803493046003C0606494E0A1A03451C",
                "061AFE0A00091A01524F140941114E150708000D00181D01520E1B4F190D4F546F0D071052125208410E491B0D05054749004F570D1D0D00110E03454E05551845081B001A00014F0D044000E1414C3B410B184F463F1B43181C0641",
                "0000B21A53590B0000491C08410B55134E00410B04100107000C03020B0B5A536F0000040653570841145504154C0D4F0A0153571D1B48531C0A55584807551849090754414EF30043201C490415031F4C0C546F080E0153101C",
                "0000B21A535901100445004F150B4F410205541C4F011D5342044C1806045A00361B1D451F1A47051559481617094B420C114E594954FE003E0A1A5E470755314C070054",
                "0D1BFCE1545918141B5452090E1600150601000B06121A07000E1C1F01175A55211D1C1C5C53631F0418541241051F0E4954B6572E1107521E0A556E45101B15520A4F73070F12",
                "1A01F110450A1C551B53520E41084F141D1D000D0A14111B4513424F27110E532A101D061700001E0C185203411C0E4F19184557001A1C4F591B1D454E091C1A474E1B480A174543020FFC54570D03184547540D462D1B4C154F324F544821",
                "061AF7534F1F4F341E42171D154465080017541C061B5500000C031C1A454841221B1D1652025502151C5357081F47004B334F13491007450A4F1B435442051841174F44060D000014081A485715040E001C1A49100A00531C4157"
            };
        }

    }
}