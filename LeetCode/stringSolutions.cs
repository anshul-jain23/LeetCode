namespace LeetCode
{
    internal static class stringSolutions
    {
        /// <summary>
        /// Time Complexity: O(M)
        /// Space Complexity: O(1) as max 26 letters keys can be created which is constant
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public static bool _383_RansomNote(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;

            //step1: constrruct dictionary from magzine and count
            var dictMagzine = new Dictionary<string, int>();
            foreach (char let in magazine)
            {
                var k = let.ToString();
                if (dictMagzine.ContainsKey(k))
                {
                    dictMagzine[k]++;
                    continue;
                }
                dictMagzine.Add(k, 1);
            }

            //step2: for each letter in ransom note, decrease the count in dict untill 0 detects
            foreach (var let in ransomNote)
            {
                var k = let.ToString();
                if (!dictMagzine.ContainsKey(k)) return false;

                var count = dictMagzine[k];
                if (count < 1) return false;

                dictMagzine[k]--;
            }

            return true;
        }
    }
}
