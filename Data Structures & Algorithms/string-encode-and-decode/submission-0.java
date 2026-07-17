class Solution {

    public String encode(List<String> strs) {
        // Assuming charTotal within constraints 
        int charTotal = 0;
        for (int i = 0; i < strs.size(); i++) {
            charTotal += 1 + strs.get(i).length();
        }

        char[] chars = new char[charTotal];
        int count = 0;
        for (int i = 0; i < strs.size(); i++) {
            String s = strs.get(i);
            int len = s.length();
            chars[count++] = (char) len;
            s.getChars(0, len, chars, count);
            count += len;
        }
        return new String(chars);
    }

    public List<String> decode(String str) {
        List<String> strs = new ArrayList<>();
        for (int i = 0; i < str.length();) {
            int len = str.charAt(i);
            strs.add(str.substring(i + 1, i + 1 + len));
            i += 1 + len;
        }
        return strs;
    }
}
