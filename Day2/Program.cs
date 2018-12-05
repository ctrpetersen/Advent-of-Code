﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static List<string> crates = new List<string>
        {
            "asgwdcmbrkerohqoutfylvzpnx",
            "asgwjcmbrkejihqoutfylvipne",
            "asgwjcmbrkedihqoutvylizpnz",
            "azgsjcmbrkedihqouifylvzpnx",
            "asgwucmbrktddhqoutfylvzpnx",
            "asgwocmbrkedihqoutfylvzivx",
            "aqgwjcmbrkevihqvutfylvzpnx",
            "tsgljcmbrkedihqourfylvzpnx",
            "asgpjcmbrkedihqoutfnlvzsnx",
            "astwjcmbrktdihqrutfylvzpnx",
            "asgwjcmbrpedhhqoutfylvzynx",
            "xsgwjcmbrkedieqowtfylvzpnx",
            "asgwjcmbvkedihfoutnylvzpnx",
            "asgwjcmtrkedihqouafylvzcnx",
            "asgwjcmbrkedihqoutfylvxpvm",
            "usgwjcmbrkedihqortfyuvzpnx",
            "asgwjcmbrwedihqoutfylizpix",
            "asgrjcvbrkedixqoutfylvzpnx",
            "asgwjcmbrogdihqoutfelvzpnx",
            "aggwjcmbrkesihqoutoylvzpnx",
            "asgtjccbrkedihqoutfrlvzpnx",
            "asgcucmbrbedihqoutfylvzpnx",
            "esgwjcmbrkedihqsutfylvzcnx",
            "asgwjcmbrkedrhqoutfyobzpnx",
            "mngwjcbbrkedihqoutfylvzpnx",
            "asgwjcrbrkeoihqyutfylvzpnx",
            "apgwjcmbrkednhqogtfylvzpnx",
            "asgwjcwbrkedihqoutfylplpnx",
            "asgwjcmbrkfdihqoutfxlvzpyx",
            "aegwjcmbrkedihqoutfylbxpnx",
            "asgljcmbrkedixqoutaylvzpnx",
            "aigwjcmbrkedihqouhfylvzpex",
            "asgwjbmbrkedihqoutfylfzpnp",
            "asgwjcmzroedihqoutcylvzinx",
            "asgwjcwbrieuihqoutfylvzpnx",
            "aagwjcmbrkedjhqdutfylvzpnx",
            "ahgwjcmbrkedihqsutfylvzpfx",
            "asgwjcmbrkedihzosttylvzpnx",
            "aegwjcmbrkedioqnutfylvzpnx",
            "asgwjcmbykidihqoutfysvzpnx",
            "asgwkcxbrkeddhqoutfylvzpnx",
            "ashwjcmbrkeeihqoutfylvzknx",
            "acgwjcmbrqedihqoqtfylvzpnx",
            "asgwjcmtrkedihooutfylszpnx",
            "asgwjcmbrkmdihqfutrylvzpnx",
            "asgwjcmbrkedihqoutjylvapnn",
            "asgwjcmbwkedihqoutkylkzpnx",
            "asgwjrmbrkedihqoutfycnzpnx",
            "asgwtcmbrkedihqoqtfylozpnx",
            "asgajcmbrkedihqoutuylvzpny",
            "asgwjcmbykedihqoutfylfzpwx",
            "asgwjcsbrkedihpoutfylvvpnx",
            "hsdwjcmbrvedihqoutfylvzpnx",
            "asgwjcmbrkedihqoutfdmszpnx",
            "adgwjcmbrtidihqoutfylvzpnx",
            "augwjcmbriedihqoutgylvzpnx",
            "asgwjvmbreedihqoutfllvzpnx",
            "asgwjcnbfkedihqoltfylvzpnx",
            "asgwjcmbykddihqoutqylvzpnx",
            "ajgwjcmbrkedihqoutfylvpvnx",
            "asgwjcmbrkydihqoutfylszpnl",
            "xsgwjcmbrkqdihqoutfylvkpnx",
            "asgwjcmbrkedimqoutfklvzknx",
            "csgwjbmbrkedihqoftfylvzpnx",
            "asgwjcmbjkedihjoutfylvzpnn",
            "asgwjcmprkedihqoulfalvzpnx",
            "asgwjcmbrvediqqoutfyuvzpnx",
            "asgwjambrkedhhqoutkylvzpnx",
            "asgejcmbrkidihqoutfylvzpnk",
            "hsiwjcmbrkedihqoutfylvzpnq",
            "asswjczbrkedihqoutfylczpnx",
            "asgwjnmbrkedyhzoutfylvzpnx",
            "asgwscmbrkedihqoutfklvlpnx",
            "asgwlcmbrktdihqoutfylvzpax",
            "asfwjcmerkedihqoutfylvipnx",
            "asgwjcmbrkeditqoeafylvzpnx",
            "asgwgcmbrkesihqoutfylyzpnx",
            "fsgwjcmbrkedihqouvfyavzpnx",
            "asgwjcmbrpedwhqoutfylmzpnx",
            "asgwjcmbrkzdzhqoucfylvzpnx",
            "asgwjcmnrketmhqoutfylvzpnx",
            "asgwjcmbrkedihxoutsylvzpnh",
            "asgwjcobrkedihqoutfrlvzpox",
            "asgwjcmbrkedihqootfylxzpox",
            "asgjjcmcrkedihqoutfylmzpnx",
            "lsgwjcmbrkedihqoutfyqvzunx",
            "asgwjcmbrwedihqoutoylvzpnu",
            "aszwjcmbtkedihqoutfylczpnx",
            "asgwjcmbykedihqoutfylvgpex",
            "asgijcmbrkedilqoutkylvzpnx",
            "astwxcmzrkedihqoutfylvzpnx",
            "akgwjcmbnkedihqfutfylvzpnx",
            "asgwjcmbrqndivqoutfylvzpnx",
            "asgwjrmbrleqihqoutfylvzpnx",
            "asgwjcmbrkevihqoutfxlvzpvx",
            "asbwjcmbrkedihqoutfelvwpnx",
            "asewjcbbrkmdihqoutfylvzpnx",
            "asgwjcmbrkeaihxoutfylpzpnx",
            "asgwjzmbrkedihqrotfylvzpnx",
            "asgwjcmbrkedihqoutgdxvzpnx",
            "asgwjcwbrkmdihqoutfylvzlnx",
            "asgwjcmbrkegihqoutfylrzpax",
            "ajgwjcmbrkegihqhutfylvzpnx",
            "asgwjcmbrzedihqhutfylvkpnx",
            "asgwjcmwrkedihqouhfylkzpnx",
            "aygwjcmbrkedihqoutfdlvzpnr",
            "asgwjcmbrkednhqoutiylvypnx",
            "aqgwjcmbrkezihqoutfylvzonx",
            "bsgwjcmbrkedihqouhfylvzsnx",
            "asgwjcmcrkedihqokyfylvzpnx",
            "asgsjcmbrkewiyqoutfylvzpnx",
            "asgwpcmbrkejihqoutfylzzpnx",
            "asgwjumbrkedbeqoutfylvzpnx",
            "asgwjcmbrkedihpoutqylqzpnx",
            "awgwjcmbrredihqoutfylvzpna",
            "asgwjsmbraedihqoutfylvzpvx",
            "asgwncmbrkedihqoutfyljzrnx",
            "asgwncmbrkedihqohtfylvzonx",
            "asgwjcmbrkedihqlutfylvypux",
            "asgwjcmbbkedihooutfylkzpnx",
            "asghjcmsryedihqoutfylvzpnx",
            "asgwjcmbrkevihqoulfzlvzpnx",
            "asggjcmbrkedizqoutfylvzknx",
            "asbwjcmbriedihqoutfylvmpnx",
            "asgwjcmbrkedqbqoutfylvzenx",
            "asgwjcmprkedihqoutfylvzknp",
            "asgwjcmbrkerihqoutfwlvzpno",
            "asgwjcmvrkesihqoutrylvzpnx",
            "asgzjcmbrkedihqoutfnlvbpnx",
            "asfwjcmbrkhdihqoutfylpzpnx",
            "asgwjcmbskedihqdutfyyvzpnx",
            "asgwjcmzrkedihqoutcylvzinx",
            "asgwjcmbrkedibqoutfylvjonx",
            "asgwjcmbrbedihqoutfylmzbnx",
            "asgwjcmbrkedhhqoutmylczpnx",
            "asgwjcmbrkbgihqoutzylvzpnx",
            "asgwjcfbrkedihqoupfyxvzpnx",
            "asiwjcmbzkedihqoutfyluzpnx",
            "asvwjcmbrkedihqoitfylvzpns",
            "asgwjcmxikedihqoutfyevzpnx",
            "asgwjcmbrkedioqoutfylvzwox",
            "asgwjcmbrkedivqoutjyuvzpnx",
            "asgwjcmbkkydihqrutfylvzpnx",
            "asgwjcmbrkxdiuqoutfylvopnx",
            "asgwjcmbrkedihqouthylvzpra",
            "asgwjcmbrzedimloutfylvzpnx",
            "asgwjcmbrkedmhqoulfytvzpnx",
            "asgwjcmbrkzdihqrutfysvzpnx",
            "ssgwjcmxrkedihqoutftlvzpnx",
            "asgwjcmbrkedihqoutfajvzynx",
            "asgwjcmbrkqdihqxuufylvzpnx",
            "asmwjcabrkedihqouxfylvzpnx",
            "asgwjcmbrkeeihqoatfycvzpnx",
            "asgwjcjbrgedjhqoutfylvzpnx",
            "asgljcmtrkedihqoutoylvzpnx",
            "asgwjcmbrkedigqouzfylvzpvx",
            "ajgvjcmbkkedihqoutfylvzpnx",
            "asgwjcmbrkedihqtugfygvzpnx",
            "asgbjcmbrkedihboftfylvzpnx",
            "asgwjwmbrkedihqontfylhzpnx",
            "asgwjfmhrkedihqoutfylvqpnx",
            "asgwjxmbrkedihqoutzylvzpnj",
            "asgwjcrlrkedihqoutfylvzpsx",
            "aygwjcmbrkedihqoutsylvzdnx",
            "zsgwjcmbrkedihjogtfylvzpnx",
            "asgwjxmbrkegihqoutfylvopnx",
            "asgwjcmbrkedihqhutfylvzcnr",
            "asgwicmbrkewihvoutfylvzpnx",
            "asqwjcmbvkedihqoutfylvzknx",
            "asgwjcmbrkedihqoktfyevzpnu",
            "asgwjcmbrkudihqoutfylqzznx",
            "asgwjdmbrkedihqoutfylvvdnx",
            "asgwjcmbrkwmihqautfylvzpnx",
            "asgwjcmbrxedihqoctfyldzpnx",
            "asgwjdmbrkedjhqoutfyfvzpnx",
            "asgwjcmtrzedihqoutfylvzpnm",
            "bpgwjcmbrmedihqoutfylvzpnx",
            "asgwjctbrkedihqoqtfynvzpnx",
            "askhjcmbrkedihqoutfylvzrnx",
            "asgkjcmblkehihqoutfylvzpnx",
            "asgwjjmbrkedvhqoutfhlvzpnx",
            "asgwjcmbrkedihqoupzylvzknx",
            "asgwjcmbukedchqoutfylizpnx",
            "askwjcmdrkedihqoutwylvzpnx",
            "asgwjcmbtkcdihloutfylvzpnx",
            "asgwjcmbrkedwgqoutvylvzpnx",
            "asmwjcmbrkedihqoutfylozpnc",
            "asgwjcmbriedibqouofylvzpnx",
            "asgnjcmcrkedihqoupfylvzpnx",
            "asgzjcmbrksdihqoutiylvzpnx",
            "asgwjcrbkkedihqouafylvzpnx",
            "asgwjcmbkkvdihqqutfylvzpnx",
            "astwjcqbrkedihqoutfylvzpvx",
            "asgwjcmhrkehihqoutfylvzvnx",
            "asgwjcmbraeduhqoutmylvzpnx",
            "asgwjcmbrkedihquutnylvzptx",
            "asgwjcmbrkedilqoftfylvzpnz",
            "akgwjmmbrkedihqoutfylxzpnx",
            "asgwjcmbrkhxikqoutfylvzpnx",
            "asgcjcmetkedihqoutfylvzpnx",
            "fsgwjcmsrkedihooutfylvzpnx",
            "gsgwjcmbrkedihdoutfylvzdnx",
            "asgwtccbrkedihqoutfylvwpnx",
            "asuwjcmbrkedihqcutfylvzpox",
            "asgwacmbrkodihqlutfylvzpnx",
            "asgwjcmbrkediuqoutfylqhpnx",
            "asgwjcmbrkwdrhqoutfylvzpno",
            "angwjcsblkedihqoutfylvzpnx",
            "aigwjcmbyoedihqoutfylvzpnx",
            "adgwjcmbrkedihqtutfylyzpnx",
            "asgwjzmbrkeeihqputfylvzpnx",
            "asgwjcmbrkwdihqoutfylvzpwc",
            "asgpjcmbrkgdihqbutfylvzpnx",
            "osgwjmmbrkedijqoutfylvzpnx",
            "asgjjcmbrkkdihqoutfylvzynx",
            "asgwjcnerwedihqoutfylvzpnx",
            "azgwhcmbrkedicqoutfylvzpnx",
            "asnwjcmbrsedihqoutfylvzpnm",
            "hsgwjcmgrkedihqoutfilvzpnx",
            "asgwscmbrkjdihqoutfylvzpnm",
            "asgbjbmbrkedhhqoutfylvzpnx",
            "aswwjcmtrkedihqjutfylvzpnx",
            "asgwicmbrbedihqoutfylvzpnm",
            "asgwjcubrkedihqoutfylvbnnx",
            "asvwjcmbrkehihqoutfylhzpnx",
            "gsgwjcmbrkedihqoutsklvzpnx",
            "asgwjcubikedihqoitfylvzpnx",
            "asgwjpmbskedilqoutfylvzpnx",
            "aigwjcmbrxedihqoutyylvzpnx",
            "asgwjcpbrkedihxoutfynvzpnx",
            "asgwjcmbrkegihqoutfklvzcnx",
            "asgwjvubrkedjhqoutfylvzpnx",
            "asgwjcabrkedihqoutfyivzplx",
            "asgwjcxbrkedihqgutfylvepnx",
            "asgwlcmbrkedihqoutqylvwpnx",
            "asgwjhmbrkydihqhutfylvzpnx",
            "asgwjcmbrkedihqoutfylwzone",
            "asgwycmbrkadihqoutuylvzpnx",
            "asgwjcybrkedihqoftfylvzpne",
            "asgwjcmnrkedihrodtfylvzpnx",
            "asgwicmwrkedihqoutfyovzpnx",
            "aqgwjlmbrkedilqoutfylvzpnx",
            "asgwjcmzskwdihqoutfylvzpnx",
            "asgwjcmdrkebihqoutfylvjpnx",
            "asgwjcmbrkpdihqoutfylxzphx",
            "asgwjcmbrkedixqoutlylfzpnx",
            "asgwjcmbrkadihqoutfylvlpdx",
            "asgejcmqrkedyhqoutfylvzpnx",
            "asgwjcmvroedihpoutfylvzpnx",
            "asgwjcmxrkedihqoutfyivzpmx"
        };

        static void Main(string[] args)
        {
            PartOne();
            PartTwo();

            Console.ReadKey();
        }

        static void PartOne()
        {
            int twoLettersAmount = 0;
            int threeLettersAmount = 0;

            foreach (var crate in crates)
            {
                if (crate.ToCharArray()
                    .GroupBy(x => x)
                    .Any(g => g.Count() == 2)){twoLettersAmount++;}

                if (crate.ToCharArray()
                    .GroupBy(x => x)
                    .Any(g => g.Count() == 3)){threeLettersAmount++;}
            }
            Console.WriteLine(twoLettersAmount * threeLettersAmount);
            Console.WriteLine($"{twoLettersAmount} - {threeLettersAmount}");
        }


        static void PartTwo()
        {
            foreach (string crate in crates)
            {
                foreach (string crateToCompareTo in crates)
                {
                    int differingChars = 0;

                    for (int i = 0; i < crateToCompareTo.Length; i++)
                    {
                        if (crate[i] != crateToCompareTo[i])
                        {
                            differingChars++;
                        }
                    }

                    if (differingChars == 1)
                    {
                        string diff = "";
                        for (int i = 0; i < crateToCompareTo.Length; i++)
                        {
                            if (crate[i] == crateToCompareTo[i])
                            {
                                diff += crate[i];
                            }
                        }

                        Console.WriteLine(diff);
                        return;
                    }
                }
            }
        }
    }
}
