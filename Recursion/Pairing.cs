class FriendsPairing {
    public static int Pairing(int n) {
        if (n <= 2) {
            return n; 
        }
        int single = Pairing(n - 1);
        int pair = (n - 1) * Pairing(n - 2);
        return single + pair;
    }
}